using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Transform myTransform;
    private Vector3 pos;
    private float gravity;
    private float totalFallTime = 0f;
    public float weight = 1.3f;
    GameObject floor;
    GameObject ball;
    GameObject coin;
    collisiondetection col;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        pos = myTransform.position;
        gravity = -9.81f;
    }

    void Update()
    {
        if (this.gameObject.tag == "Ball")
        {
            floor = GameObject.Find("Cube");
            col = floor.GetComponent<collisiondetection>();
            //重力
            if (gravity < 0)
            {
                totalFallTime += Time.deltaTime;
                pos.y += (gravity * Time.deltaTime) * totalFallTime;         //y座標への加算
                myTransform.position = pos;     //座標を設定
            }
            else if (gravity > 0)
            {
                if (totalFallTime > 0)
                {
                    totalFallTime -= Time.deltaTime * weight;
                    if (totalFallTime < 0)
                    {
                        totalFallTime = 0f;
                    }
                    else if (totalFallTime > 0)
                    {
                        pos.y += (gravity * Time.deltaTime) * totalFallTime;         //y座標への加算
                        myTransform.position = pos;
                    }
                }
                else if (totalFallTime <= 0)
                {
                    gravity *= -1;
                }
            }
            if (col.floorY + 0.05f >= pos.y - col.radius)
            {
                if (gravity <= 0) {
                    gravity *= -1;
                }
            }
        }
        if (this.gameObject.tag == "Coin")
        {
        }
    }
}
