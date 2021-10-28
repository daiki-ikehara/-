using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCount : MonoBehaviour
{
    public Text scoreText; //Text用変数
    private int count = 0; //スコア計算用変数


    void Start()
    {
        count = 0;
        SetScore();   //初期スコアを代入して表示
    }

    //cube同士での衝突+1
    void OnCollisionEnter(Collision collision)
    {
        //        string yourTag = collision.gameObject.tag;

        if (collision.gameObject.tag == "coin")
        {
            count += 1;
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("{0}/12", count);
    }
}
