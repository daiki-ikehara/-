using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public static bool t = false;
    public void Title()
    {
        SceneManager.LoadScene("TitleScene");

        t = true;
    }
}
