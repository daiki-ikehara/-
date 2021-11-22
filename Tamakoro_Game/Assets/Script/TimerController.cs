using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{

    public Text countDownText;
    [SerializeField] GameObject panel;
    public int time = 0;

    private void Start()
    {
        Time.timeScale = 0f;
        StartCoroutine("CountDown");
    }


    IEnumerator CountDown()
    {
        
        for (int i = 2; i >= 0; i--)
        {
            yield return new WaitForSecondsRealtime(1);//1秒待つ
            countDownText.text = i.ToString();
            if (i == 0)
            {
                countDownText.text = "スタート".ToString();
            }
            
        }
        yield return new WaitForSecondsRealtime(0.5f);//0.5秒待つ
        panel.SetActive(false);
        Time.timeScale = 1;
        time = 1;
    }
}
