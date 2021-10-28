using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class floor : MonoBehaviour
{
    const float V = 1.0f;

    float v = V;
    //	移動量
    float a = 0.3f;//加速度

    float flag = 0;
    float lowflag = 0;
    float tmp = 0;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        if (x != 0 || y != 0)//4方向のうちどれかに傾いているとき
        {


            tmp = flag;

            if (x > 0)
            {

                flag = 1;

            }
            else if (x < 0)
            {

                flag = 2;
            }
            else if (y > 0)
            {
                flag = 3;

            }
            else if (y < 0)
            {
                flag = 4;

            }

            if (v <= 90f)
            {

                v += a;
            }

        }
        else//離されているときの処理
        {

            v -= a;//減速



            if (v < V)//VこえたらVにもどす
            {
                v = V;
                lowflag = 1;



            }
        }
        if (v != V)//回転中
        {
            if (flag == 1)
            {

                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0f, -30), v * Time.deltaTime);
            }
            if (flag == 2)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0f, 30), v * Time.deltaTime);
            }

            if (flag == 3)
            {

                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(30, 0f, 0), v * Time.deltaTime);
            }
            if (flag == 4)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-30, 0f, 0), v * Time.deltaTime);
            }

            if (tmp != 0 && tmp != flag)
            {
                v = V;
                Debug.Log("Ok");
            }


        }

    }
}
