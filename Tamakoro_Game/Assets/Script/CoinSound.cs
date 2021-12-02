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
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "coin")
        {
            audioSource.PlayOneShot(Coinsound);
        }
        if (col.gameObject.tag == "Item")
        {
            audioSource.PlayOneShot(Heartsound);
        }
    }
}
