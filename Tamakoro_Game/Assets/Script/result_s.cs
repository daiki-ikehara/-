using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class result_s : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject resultpanel;
    float countTime = 0;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
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
