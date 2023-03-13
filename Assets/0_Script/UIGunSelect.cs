using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class UIGunSelect : MonoBehaviour
{

    public static UIGunSelect instance;
    private void Awake()
    {
        instance = this;
    }

    public GameObject contents;
    public void OnClickSelectGun(GameObject go)
    {
        UIManager.instance.gunFireUI.SpawnGun(go);
        contents.SetActive(false);


        Regex re = new Regex(@"\d+");
        Match m = re.Match(go.name);

        int index = int.Parse(m.Value);

    }






}
