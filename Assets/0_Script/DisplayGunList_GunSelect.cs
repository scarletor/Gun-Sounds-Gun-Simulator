using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;
using DG.Tweening;
public class DisplayGunList_GunSelect : MonoBehaviour
{





    // Start is called before the first frame update
    void Start()
    {

        SetupSelf();

    }


    public void SetupSelf()
    {
        //var index = 0;

        //foreach (Transform gun in gunImageListParent.transform)
        //{
        //    gun.transform.GetChild(0).GetComponent<Image>().sprite = gunSpriteList[index];      //gun sprite
        //    gun.transform.GetChild(0).GetComponent<Image>().SetNativeSize();
        //    index++;
        //}
    }

    public GameObject gunImageListParent;
    public List<Sprite> gunSpriteList;

















}
