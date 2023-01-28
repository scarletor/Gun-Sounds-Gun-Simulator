using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class UiEffect : MonoBehaviour
{





    private void Start()
    {
        Scale();
    }



    public float scaleUpValue, scaleDownValue, timeUp, timeDown;
    public Ease easeUp, easeDown;
    public void Scale()
    {
        transform.DOScale(scaleUpValue, timeUp).SetEase(easeUp).OnComplete(() =>
        {
            transform.DOScale(scaleDownValue, timeDown).SetEase(easeDown).OnComplete(() =>
            {
                Scale();
            });
        });
    }










}
