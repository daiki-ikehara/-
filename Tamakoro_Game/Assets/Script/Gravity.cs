using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Transform myTransform;
    public Vector3 pos;
    public float gravity;
    public float totalFallTime = 0f;
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
            totalFallTime += Time.deltaTime;
            pos.y += (gravity * Time.deltaTime) * totalFallTime;         //y座標への加算
            myTransform.position = pos;     //座標を設定
            if (col.floorY + 0.1f <= pos.y - col.radius)
            {
                totalFallTime = 0;
            }

        }
        if (this.gameObject.tag == "Coin")
        {
        }
    }

}
