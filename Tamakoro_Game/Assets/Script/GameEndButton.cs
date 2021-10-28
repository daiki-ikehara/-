using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndButton : MonoBehaviour
{
    public void GameEnd()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}