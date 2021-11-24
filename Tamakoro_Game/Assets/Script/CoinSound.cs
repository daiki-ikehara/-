using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public AudioClip Coinsound;
    public AudioClip Heartsound;
    AudioSource audioSource;
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            audioSource.PlayOneShot(Coinsound);
        }
        if (other.gameObject.tag == "Item")
        {
            audioSource.PlayOneShot(Heartsound);
        }

    }
}
