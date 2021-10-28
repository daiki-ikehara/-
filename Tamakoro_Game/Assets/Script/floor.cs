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

    float lowspeed = 60f;

    float flag = 0;

=======
    float v = V;
    //	移動量
    float a = 0.3f;//加速度
    

  

    float flag = 0;
    float lowflag = 0;
    float tmp = 0;

>>>>>>> 8bfa99ac72a1e61ff9e7bf8c69568b94b364afa7
    private void Update()
    {



        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        if (x != 0||y!=0)//4方向のうちどれかに傾いているとき
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
<<<<<<< HEAD
            }
=======
                
            }

            if (v <= 90f)
            {
                
                v += a;
            }

       
            
            

>>>>>>> 8bfa99ac72a1e61ff9e7bf8c69568b94b364afa7
        }
        else//離されているときの処理
        {
<<<<<<< HEAD
            if (flag == 1 || flag == 2 || flag == 3 || flag == 4)
            {
=======
           
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
                
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0f, -30), v*Time.deltaTime);
            }
            if (flag == 2)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0f, 30), v* Time.deltaTime);
            }

            if(flag == 3)
            {

                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(30, 0f, 0), v * Time.deltaTime);
            }
            if (flag == 4)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-30, 0f, 0), v* Time.deltaTime);
            }
>>>>>>> 8bfa99ac72a1e61ff9e7bf8c69568b94b364afa7

            if (tmp!=0&&tmp != flag)
            {
                v = V;
                Debug.Log("Ok");
            }

<<<<<<< HEAD
        if (v != V)//加速しているとき（傾いているとき）
        {
            if (flag == 1)
            {
=======

        }
>>>>>>> 8bfa99ac72a1e61ff9e7bf8c69568b94b364afa7


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
        Debug.Log(v);





    }
}
=======




    }
}
>>>>>>> 8bfa99ac72a1e61ff9e7bf8c69568b94b364afa7
