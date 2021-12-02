using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    AudioSource audioSource;
    private Rigidbody rbo;

    void Start()
    {
        rbo = GetComponent<Rigidbody>();
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Floor"))
        {
            audioSource.Play();
        }

        //if (rbo.velocity.magnitude > 0.1f)
        //{
        //    Debug.Log("呼び出された");
        //    audioSource.Play();
        //}
        //else
        //{
        //    Debug.Log("サウンド停止");
        //    audioSource.Stop();
        //}
    }
}
