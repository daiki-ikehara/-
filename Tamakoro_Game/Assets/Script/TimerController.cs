using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private float countTime = 4;
    private int second;
    public Text timeCount;
    [SerializeField] GameObject startCount;

    private void Start()
    {
        Invoke("DelayMethod", 4f);
    }
    void Update()

    {
        countTime -= Time.deltaTime;
        second = (int)countTime;
        //(int)countTimeでint型に変換して表示させる。
        timeCount.text = second.ToString();
        if (countTime <= 1)
        {
            timeCount.text = "GO";
        }
    }
    void DelayMethod()
    {
        startCount.SetActive(false);
    }

}
