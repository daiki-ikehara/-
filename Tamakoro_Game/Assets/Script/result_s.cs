using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result_s : MonoBehaviour
{
    [SerializeField] GameObject panel;
    float countTime = 0;
    public Text scoreText;
    public Text Time_text;

   
    // Start is called before the first frame update
    void Start()
    {
        
        countTime = 0;
    }
    // Update is called once per frame
    void Update()
    {
        int minutes = Mathf.FloorToInt(countTime / 60F);
        int seconds = Mathf.FloorToInt(countTime - minutes * 60);
       


        if (ItemCount.count == 12)
        { 
            scoreText.text = string.Format("所得したコイン　{0}/12",ItemCount.count);
            Time_text.text = string.Format("かかった時間　{0:00}:{1:00}", minutes, seconds);
        }
        
        if (panel.activeSelf)
        {
            Debug.Log("はかってない");
        }
        
            countTime += Time.deltaTime;
            Debug.Log(countTime);
        
    }
}
