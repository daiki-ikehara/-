using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class souneffect : MonoBehaviour
{

    public AudioClip countsound;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();

        //音(sound1)を鳴らす
        audioSource.PlayOneShot(countsound);
    }

    void Update()
    {


    }
}
