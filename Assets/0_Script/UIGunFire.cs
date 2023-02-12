using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Text.RegularExpressions;
using System;
public class UIGunFire : MonoBehaviour
{


















    void Start()
    {

    }
    public GameObject gunParent;

    public int currentGunID;
    public bool world;
    [Button]
    public void SpawnGun(GameObject gun)
    {
        currentGunID  = Int32.Parse(Regex.Match(gun.name, @"\d+").Value);

        gameObject.SetActive(true);

        var newGun = Instantiate(gun.transform.GetChild(0));
        newGun.transform.SetParent(gunParent.transform, false);
        newGun.transform.localPosition = Vector3.zero;

        var newScale = newGun.transform.localScale;
        newScale = newScale * 2.5f;
        newGun.transform.localScale = newScale;

        newGun.transform.localEulerAngles = new Vector3(newGun.transform.localRotation.x, newGun.transform.localRotation.y - 180, newGun.transform.localScale.z);

    }


























}
