using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour
{

    [SerializeField] private GameObject RetryPanel;
    // Start is called before the first frame update
    void Start()
    {
        RetryPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameClear.retryflg)
        {
            RetryPanel.SetActive(true);
        }

        if (ReStartButton.f == true)
        {
            RetryPanel.SetActive(false);
        }

        if (TitleButton.t == true)
        {
            RetryPanel.SetActive(false);
        }
    }
}