using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour
{

    [SerializeField] private GameObject RetryPanel;
    // Start is called before the first frame update
    void Start()
    {
        GameClear.retryflg = false;
        RetryPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameClear.retryflg)
        {
            RetryPanel.SetActive(true);
        }


    }
}