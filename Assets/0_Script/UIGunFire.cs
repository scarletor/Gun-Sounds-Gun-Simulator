using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Text.RegularExpressions;
using AndroidNativeCore;
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
        foreach(Transform child in gunParent.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (Transform child in particlePos.transform)
        {
            Destroy(child.gameObject);
        }


        currentGunID = Int32.Parse(Regex.Match(gun.name, @"\d+").Value);

        gameObject.SetActive(true);

        var newGun = Instantiate(gun.transform.GetChild(0));
        newGun.transform.SetParent(gunParent.transform, false);
        newGun.transform.localPosition = Vector3.zero;

        var newScale = newGun.transform.localScale;
        newScale = newScale * 2.5f;
        newGun.transform.localScale = newScale;

        newGun.transform.localEulerAngles = new Vector3(newGun.transform.localRotation.x, newGun.transform.localRotation.y - 180, newGun.transform.localScale.z);
        particlePos.transform.position = newGun.transform.GetChild(0).transform.position;
    }


    Flash flash;



    public Animator anim, white;
    public GameObject particle, particlePos;

    [Button]
    public void OnClickFire()
    {
        anim.Play("GunFire", -1, 0);
        white.Play("whiteBLink", -1, 0);
        particle.gameObject.SetActive(true);
        var newPart = Instantiate(particle);
        newPart.transform.SetParent(particlePos.transform, false);
        AudioManager.ins.PlaySound();




        flash = new Flash();
        flash.setFlashEnable(true);



    }

  


}
