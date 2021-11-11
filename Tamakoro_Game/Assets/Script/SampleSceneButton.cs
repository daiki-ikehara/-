using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SampleSceneButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene("SampleScene");
            Time.timeScale = 1;  //再開
        }
    }
}
