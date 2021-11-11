
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Retryselect : MonoBehaviour
{
    Button button;
    void OnEnable()
    {
        button = GameObject.Find("Retry/RetryPanel/RetryButton").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.Select();

    }

}
