using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCount : MonoBehaviour
{
    public Text scoreText; //Text用変数
   //スコア計算用変数


    void Start()
    {
        
        SetScore();   //初期スコアを代入して表示
    }

    //cube同士での衝突+1
    private void OnTriggerEnter(Collider other)
    {
        //        string yourTag = collision.gameObject.tag;


        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("{0}/12", coin.count);
    }
}
