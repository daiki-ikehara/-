using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouseSelect : MonoBehaviour
{
    Button button;

    void OnEnable()
    {
        button = GameObject.Find("Menu/Panel/ReStart").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.Select();
    }
}
