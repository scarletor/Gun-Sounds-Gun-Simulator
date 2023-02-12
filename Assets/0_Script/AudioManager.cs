using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager ins;
    private void Awake()
    {
        ins = this;
    }


    public AudioSource _audio;
    public List<AudioClip> gunSound;



    public void PlaySound()
    {
        var rd = Random.Range(0, gunSound.Count);
        var _clip = gunSound[rd];
        _audio.clip = _clip;
        _audio.Play();
    }



}
