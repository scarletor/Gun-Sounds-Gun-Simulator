using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AdManager : MonoBehaviour
{

    public static AdManager instance;

    private void Awake()
    {
        instance = this;
    }




    public void CallInterstitialAd()
    {



    }

    public void CallBotBannerAd()
    {

    }



    public void CallVideoAd(Action cb=null)
    {

        

    }


}
