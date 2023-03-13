using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_InfoGun : MonoBehaviour
{
    public static UI_InfoGun instance;
    private void Awake()
    {
        instance = this;
    }

    public GameObject contents;
    public Sheet1 dataGun;
    public int _indexShowing;
    public void ShowInfo(int index)
    {
        _indexShowing = index;

        Debug.Log(dataGun.dataArray[_indexShowing].Name);

    }













}
