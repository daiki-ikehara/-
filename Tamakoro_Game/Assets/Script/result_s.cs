using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result_s : MonoBehaviour
{
    [SerializeField] GameObject panel;
    float countTime = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (ItemCount.count == 1)
        { 
            scoreText.text = string.Format("所得したコイン　{0}/12",ItemCount.count);
        }
        
        if (panel.activeSelf)
        {
            Debug.Log("はかってない");
        }
        else
        {
            countTime += Time.deltaTime;
            Debug.Log(countTime);
        }
    }
}
