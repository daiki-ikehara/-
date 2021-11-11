using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    AudioSource BGM;
    int xB = 0;
    int count = 0;
    void Start()
    {
        BGM = GetComponent<AudioSource>();
        StartCoroutine("CountDown");
        count = 0;
    }

    IEnumerator CountDown()
    {
            yield return new WaitForSecondsRealtime(3.5f);
              BGM.Play();
    }
    void Update()
    {
        //STARTを押すと
        if (Input.GetKeyDown("joystick button 7") && xB == 0)
        {
            //BGMを止める
            BGM.Pause();
            Debug.Log("STOP");
            xB++;

        }
        //再度STARTを押すと
        else if (Input.GetKeyDown("joystick button 7") && xB == 1)
        {
            //BGMを再開する
            BGM.UnPause();
            Debug.Log("RESTART");
            xB--;
        }
        //クリアすると
        if (count == 12)
        {
            BGM.Stop();
        }
    }
}
