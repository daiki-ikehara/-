using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Transform myTransform;
    private Vector3 pos;
    private float gravity;
    private float totalFallTime = 0f;
    private float totalBounceTime = 0f;
    private float bounce = 0.02f;
    private float height;
    private float Count = 0;
    GameObject floor;
    GameObject ball;
    GameObject coin;
    collisiondetection col;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        pos = myTransform.position;
        gravity = -9.81f;
        height = pos.y;
    }

    void Update()
    {
        if (this.gameObject.tag == "Ball")
        {

            floor = GameObject.Find("Cube");
            col = floor.GetComponent<collisiondetection>();
            //重力
            if (col.floorY + 0.1f <= pos.y - col.radius)
            {
                totalFallTime += Time.deltaTime;
                pos.y += (gravity * Time.deltaTime) * totalFallTime;         //y座標への加算
                myTransform.position = pos;     //座標を設定
            }
            else
            {
                totalFallTime = 0;
                while (pos.y <= height / 2 || bounce > 0)
                {
                    pos.y += bounce;
                    bounce -= 0.002f;
                }
                height = pos.y;
            }

        }
        if (this.gameObject.tag == "Coin")
        {
        }
    }

}
