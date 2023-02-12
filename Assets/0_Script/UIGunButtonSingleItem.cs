using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using TMPro;
public class UIGunButtonSingleItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetupSelf();
    }






    public int myID;
    public List<Sprite> backgroundSprite;
    public Sheet1 dataGun;
    public void SetupSelf()
    {
        var rd = UnityEngine.Random.Range(0, backgroundSprite.Count);
        gameObject.GetComponent<Image>().sprite = backgroundSprite[rd]; //random background


        myID = Int32.Parse(Regex.Match(gameObject.name, @"\d+").Value);

        gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = dataGun.dataArray[myID].Name;

        GetComponent<Button>().onClick.AddListener(() => { OnClickMe(); });

    }


    public void OnClickMe()
    {
        UIManager.instance.selectGunUI.OnClickSelectGun(gameObject);
    }

}
