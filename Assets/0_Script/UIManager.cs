using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    private void Awake()
    {
        if (instance != null) Debug.LogError("Multi ins");
        instance = this;
    }






    public void OnClickPlay()
    {

    }



    public UIGunFire gunFireUI;
    public UIGunSelect selectGunUI;
    public GameObject homeUI;

}

