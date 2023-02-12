using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Sirenix.OdinInspector;
public class UI_Home : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        target = endPos;
        GunScroll();
        Scale();

    }

    // Update is called once per frame

    public float time;

    public GameObject startPos, endPos, gunList, target, playBtn;
    public void GunScroll()
    {
        gunList.transform.DOMoveX(target.transform.position.x, time).SetEase(Ease.InOutBounce).OnComplete(() =>
        {
            target = target == endPos ? startPos : endPos;
            GunScroll();
        });
    }




    public float scaleUpValue, scaleDownValue, timeUp, timeDown;
    public Ease easeUp, easeDown;
    public void Scale()
    {
        playBtn.transform.DOScale(scaleUpValue, timeUp).SetEase(easeUp).OnComplete(() =>
        {
            playBtn.transform.DOScale(scaleDownValue, timeDown).SetEase(easeDown).OnComplete(() =>
            {
                Scale();
            });
        });
    }


    
    public void OnClickPlayBtn()
    {
        UIManager.instance.OnClickPlayBtn();
    }





}
