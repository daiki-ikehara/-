using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    int xB = 0;

    void Start()
    {
        pausePanel.SetActive(false);
        //Pause();
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown("joystick button 9"))
    //    {

    //        Time.timeScale = 0;  // 時間停止
    //        pausePanel.SetActive(true);

    //        Debug.Log("button9");
    //    }
    //    if (Input.GetKeyDown("joystick button 8"))
    //    {
    //        Time.timeScale = 1;  // 再開
    //        pausePanel.SetActive(false);

    //        Debug.Log("button8");
    //    }
    //}

    private void Update()
    {
        if (Input.GetKeyDown("joystick button 9") && xB == 0)
        {

            Time.timeScale = 0;  // 時間停止
            pausePanel.SetActive(true);

            xB++;

            Debug.Log("button9");
        }
        else if (Input.GetKeyDown("joystick button 9") && xB == 1)
        {
            Time.timeScale = 1;  // 再開
            pausePanel.SetActive(false);

            xB--;

            Debug.Log("button9");
        }
    }

    private void Pause()
    {
        //if (Input.GetKeyDown("joystick button 7"))
        //{

        //    Time.timeScale = 0;  // 時間停止
        //    pausePanel.SetActive(true);

        //    Debug.Log("button7");
        //}

        //Time.timeScale = 1;  // 再開
        //pausePanel.SetActive(false);
    }

}