using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Text.RegularExpressions;
using AndroidNativeCore;
using System;
using DG.Tweening;

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
        foreach (Transform child in gunParent.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (Transform child in particlePos.transform)
        {
            Destroy(child.gameObject);
        }
        contents.SetActive(true);


        currentGunID = Int32.Parse(Regex.Match(gun.name, @"\d+").Value);


        var newGun = Instantiate(gun.transform.GetChild(0));
        newGun.transform.SetParent(gunParent.transform, false);
        newGun.transform.localPosition = Vector3.zero;

        var newScale = newGun.transform.localScale;
        newScale = newScale * 2.5f;
        newGun.transform.localScale = newScale;

        newGun.transform.localEulerAngles = new Vector3(newGun.transform.localRotation.x, newGun.transform.localRotation.y - 180, newGun.transform.localScale.z);
        particlePos.transform.position = newGun.transform.GetChild(0).transform.position;
    }





    public Animator anim, white;
    public GameObject particle, particlePos, contents;
    public FlashlightPlugin _flash;
    public GameObject _buletList;
    [Button]
    public void OnClickFire()
    {
        if (RemoveBullet() == false) return;




        anim.Play("GunFire", -1, 0);
        white.Play("whiteBLink", -1, 0);
        particle.gameObject.SetActive(true);
        var newPart = Instantiate(particle);
        newPart.transform.SetParent(particlePos.transform, false);
        AudioManager.ins.PlaySound();
        Debug.LogError("FIRE");

#if UNITY_ANDROID && !UNITY_EDITOR
        _flash.TurnOn();
        DOVirtual.DelayedCall(.1f, () => { _flash.TurnOff(); });
#endif



    }


    public Sheet1 infoGun;
    public void OnClickInfo()
    {
        UI_InfoGun.instance.contents.SetActive(true);
        contents.SetActive(false);
    }



    public bool RemoveBullet()
    {
        foreach (Transform child in _buletList.transform)
        {
            if (child.gameObject.activeInHierarchy)
            {
                child.gameObject.SetActive(false);
                return true;
            }
            if (child.transform.GetSiblingIndex() == _buletList.transform.childCount - 1)
            {
                return false;
            }
        }

        return false;
    }






    public float swipeThreshold = 50f;
    public float timeThreshold = 0.3f;

    private Vector2 _fingerDown;
    private DateTime _fingerDownTime;
    private Vector2 _fingerUp;
    private DateTime _fingerUpTime;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _fingerDown = Input.mousePosition;
            _fingerUp = Input.mousePosition;
            _fingerDownTime = DateTime.Now;
        }

        if (Input.GetMouseButtonUp(0))
        {
            _fingerDown = Input.mousePosition;
            _fingerUpTime = DateTime.Now;
            CheckSwipe();
        }

        foreach (var touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                _fingerDown = touch.position;
                _fingerUp = touch.position;
                _fingerDownTime = DateTime.Now;
            }

            if (touch.phase == TouchPhase.Ended)
            {
                _fingerDown = touch.position;
                _fingerUpTime = DateTime.Now;
                CheckSwipe();
            }
        }
    }

    private void CheckSwipe()
    {
        var duration = (float)_fingerUpTime.Subtract(_fingerDownTime).TotalSeconds;
        var dirVector = _fingerUp - _fingerDown;

        if (duration > timeThreshold) return;
        if (dirVector.magnitude < swipeThreshold) return;

        //var direction = dirVector.Rotation(180f).Round();
        //Quaternion rotation = Quaternion.LookRotation(dirVector, Vector3.up);
        //float angle = Vector2.Angle(_fingerDown, _fingerUp);
        float angle = Mathf.Atan2(dirVector.y, dirVector.x) * Mathf.Rad2Deg; // get radian angle direction

        Debug.LogError(angle);

        //if (direction >= 45 && direction < 135) onSwipeUp.Invoke();
        //else if (direction >= 135 && direction < 225) onSwipeRight.Invoke();
        //else if (direction >= 225 && direction < 315) onSwipeDown.Invoke();
        //else if (direction >= 315 && direction < 360 || direction >= 0 && direction < 45) onSwipeLeft.Invoke();
    }









}
