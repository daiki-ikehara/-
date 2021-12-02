﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    AudioSource BGM;
    int xB = 0;
    public TimerController start;
    public Select ST;  //Stop = 0

    void Start()
    {
        BGM = GetComponent<AudioSource>();
        StartCoroutine("CountDown");
    }

    IEnumerator CountDown()
    {
            yield return new WaitForSecondsRealtime(3.5f);
              BGM.Play();
    }
    void Update()
    {
        if (start.time == 1)
        {
            //STARTを押すと
            if (Input.GetKeyDown("joystick button 7") && xB == 0)
            {
                //BGMを止める
                BGM.Pause();
                Debug.Log("Pause");
                xB++;

            }
            //再度STARTを押すと
            else if (Input.GetKeyDown("joystick button 7") && xB == 1 && ST.Stop == 0)
            {
                //BGMを再開する
                BGM.UnPause();
                Debug.Log("UnPause");
                xB--;
            }
        }
    }
    //BGMを止める関数
    public void BGMStoper()
    {
        BGM.Stop();
    }
}
