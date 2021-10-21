using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class floor : MonoBehaviour
{
    const float V = 1.0f;

<<<<<<< HEAD
    float v = V;//速さ
    //	移動量
    float a = 0.5f;//加速度
    float MaxSpeed = 90f;
=======
    float v = V;
    //	移動量
    float a = 0.3f;//加速度
>>>>>>> c0f2a206937e1990136d7087aa7cf7ce93277926

    float lowspeed = 60f;

<<<<<<< HEAD
    float flag = 0;

=======
    float Minspeed = 60f;

    float flag = 0;
    float lowflag = 0;

>>>>>>> c0f2a206937e1990136d7087aa7cf7ce93277926
    private void Update()
    {



        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

<<<<<<< HEAD

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
=======

        if (x != 0 || y != 0)
        {
            if (v <= 90f)
            {
                v += a;
            }
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
        }
        else
        {
            if (flag == 1 || flag == 2 || flag == 3 || flag == 4)//離した方向
            {

                v -= a;//減速

            }

            if (v < V)//VこえたらVにもどす
            {
                v = V;
                lowflag = 1;

            }

            if (lowflag == 1)
            {


>>>>>>> c0f2a206937e1990136d7087aa7cf7ce93277926
            }
        }

        if (v != V)
        {
<<<<<<< HEAD
            if (flag == 1 || flag == 2 || flag == 3 || flag == 4)
            {
=======
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
>>>>>>> c0f2a206937e1990136d7087aa7cf7ce93277926

                v -= a;//減速

            }

            if (v < V)//１より小さくなったら１にもどるす
            {
                v = V;
                // transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0f, 0), 90 * Time.deltaTime);
            }
        }

<<<<<<< HEAD
        if (v != V)//加速しているとき（傾いているとき）
        {
            if (flag == 1)
            {
=======
        //Debug.Log(v);

>>>>>>> c0f2a206937e1990136d7087aa7cf7ce93277926

                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0f, -30), v * Time.deltaTime);
            }
            if (flag == 2)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0f, 30), v * Time.deltaTime);
            }

<<<<<<< HEAD
            if (flag == 3)
            {

                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(30, 0f, 0), v * Time.deltaTime);
            }
            if (flag == 4)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-30, 0f, 0), v * Time.deltaTime);
            }


        }
        //Debug.Log(v);
    }
}
=======


    }
}
>>>>>>> c0f2a206937e1990136d7087aa7cf7ce93277926
