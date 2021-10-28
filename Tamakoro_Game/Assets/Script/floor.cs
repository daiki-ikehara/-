using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class floor : MonoBehaviour
{
    const float V = 1.0f;

    float v = V;//速さ
    //	移動量
    float a = 0.5f;//加速度
    float MaxSpeed = 90f;

    float lowspeed = 60f;

    float flag = 0;

    private void Update()
    {



        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        if (x != 0 || y != 0)
        {
            if (v <= MaxSpeed)//９０fまで加速
            {
                v += a;
            }
            if (x > 0)
            {
                flag = 1;//右のふらぐおん
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
        }
        else
        {
            if (flag == 1 || flag == 2 || flag == 3 || flag == 4)
            {

                v -= a;//減速

            }

            if (v < V)//１より小さくなったら１にもどるす
            {
                v = V;
                // transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0f, 0), 90 * Time.deltaTime);
            }
        }

        if (v != V)//加速しているとき（傾いているとき）
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


        }
        Debug.Log(v);





    }
}