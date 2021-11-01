using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndButton : MonoBehaviour
{
    public void GameEnd()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        UnityEngine.Application.Quit();
#endif

    }

}