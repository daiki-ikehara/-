using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectSceneButton : MonoBehaviour

{
    private void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene("StageSelect");
            //Time.timeScale = 1;
        }
    }
}

