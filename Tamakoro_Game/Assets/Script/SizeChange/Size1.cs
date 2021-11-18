using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//スクリプトでUI(テキストなど)扱うときはこれ必須！！
using UnityEngine.SceneManagement;

public class Size1 : MonoBehaviour
{

    int i = 0;

    Text m_Text;
    RectTransform m_RectTransform;

    public Select2 select2;

    // Start is called before the first frame update
    void Start()
    {

        m_Text = GetComponent<Text>();
        m_RectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

        SizeC();

    }

    public void SizeC()
    {
        if (select2.It == 0 && select2.Iz == 0)
        {
            m_Text.fontSize = 60;
        }
        else
        {
            m_Text.fontSize = 50;
        }
    }
}
