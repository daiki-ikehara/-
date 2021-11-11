using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEController : MonoBehaviour
{
    public AudioClip CountDown;
    AudioSource SE;
    void Start()
    {
        SE = GetComponent<AudioSource>();
        SE.PlayOneShot(CountDown);
    }

    void Update()
    {
        
    }
}
