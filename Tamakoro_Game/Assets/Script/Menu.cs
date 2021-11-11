using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    
    int xB = 0;

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 7") && xB == 0)
        {
            Time.timeScale = 0;  // 時間停止
            pausePanel.SetActive(true);

            xB++;
            Debug.Log(xB);

            Debug.Log("button7");
        }
        else if (Input.GetKeyDown("joystick button 7") && xB == 1)
        {
            Time.timeScale = 1;  // 再開
            pausePanel.SetActive(false);

            xB--;

            Debug.Log("button7");
        }
    }
}
