using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class UIGunFire : MonoBehaviour
{


















    void Start()
    {
        
    }
    public GameObject gunParent,pref;


    public bool world;
    [Button]
    public void SpawnGun()
    {
        var newGun = Instantiate(pref);
        newGun.transform.SetParent(gunParent.transform,false);
        newGun.transform.localPosition = Vector3.zero;

        var newScale = newGun.transform.localScale;
        newScale = newScale*2.5f;
        newGun.transform.localScale = newScale;



        newGun.transform.localEulerAngles = new Vector3(newGun.transform.localRotation.x, newGun.transform.localRotation.y-180, newGun.transform.localScale.z);

    }































}
