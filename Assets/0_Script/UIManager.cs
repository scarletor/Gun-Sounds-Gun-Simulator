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

        Application.targetFrameRate = 60;
    }






    public void OnClickPlayBtn()
    {
        homeUI.gameObject.SetActive(false);
        gunSeletUI.gameObject.SetActive(true);
    }


/// <summary>
/// </summary>

    public UIGunFire gunFireUI;
    public UIGunSelect gunSeletUI;
    public GameObject homeUI;





    public void OnClickBackToGunList()
    {
        gunSeletUI.gameObject.SetActive(true);
        gunFireUI.gameObject.SetActive(false);
    }
}

