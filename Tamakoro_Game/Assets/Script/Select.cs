using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//スクリプトでUI(テキストなど)扱うときはこれ必須！！
using UnityEngine.SceneManagement;


public class Select : MonoBehaviour
{
    public int It = 0;
    public int i = 0;

    //スタート関数
    void Start()
    {

    }

    //アップデート関数
    void Update()
    {
        float y = Input.GetAxisRaw("Vertical");

        if (y == +1 || y == -1)
        {
            if (i == 0)
            {
                Puro();
                i++;
            }
        }
        else
        {
            i = 0;
        }

        if (Input.GetKeyDown("joystick button 0") && It == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1;  // 再開
        }
        else if (Input.GetKeyDown("joystick button 0") && It == 1)
        {
            SceneManager.LoadScene("TitleScene");
        }
        else if (Input.GetKeyDown("joystick button 0") && It == 2)
        {
         #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
          UnityEngine.Application.Quit();
#endif

        }
        //else if (Input.GetKeyDown("joystick button 7") && It == 1)
        //{
        //    transform.position += new Vector3(0, 45, 0);
        //}
        //else if(Input.GetKeyDown("joystick button 7") && It == 2)
        //{
        //    transform.position += new Vector3(0, 90, 0);
        //}
    }

    public void Puro()
    {
        float y = Input.GetAxisRaw("Vertical");

        if (y == -1 && It != 2)
        {
            transform.position += new Vector3(0, -45, 0);//毎フレームx座標を0.1ずつプラス        
            It++;
        }
        else if (y == -1)
        {
            transform.position += new Vector3(0, 90, 0);
            It = 0;
        }

        if (y == +1 && It != 0)
        {
            transform.position += new Vector3(0, 45, 0);//毎フレームx座標を0.1ずつプラス     
            It--;
        }
        else if (y == +1)
        {
            transform.position += new Vector3(0, -90, 0);
            It = 2;
        }
    }
}