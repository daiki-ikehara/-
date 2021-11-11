using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private float bounce = 9.81f;
    private float height;
    private float totalBounceTime = 0f;
    GameObject floor;
    GameObject ball;
    GameObject coin;
    collisiondetection col;
    Gravity gravity;
    private void Start()
    {
        
    }
    private void Update()
    {
        floor = GameObject.Find("Cube");
        col = floor.GetComponent<collisiondetection>();
        ball = GameObject.Find("Sphere");
        gravity = ball.GetComponent<Gravity>();
        if (col.floorY + 0.1f <= gravity.pos.y - col.radius)
            while (gravity.pos.y <= height / 2 || bounce > 0)
            {
                totalBounceTime += Time.deltaTime;
                gravity.pos.y += (bounce * Time.deltaTime) * totalBounceTime;         //y座標への加算
                gravity.myTransform.position = gravity.pos;
            }
        height = gravity.pos.y;
    }
}

////ボールが当たった物体の法線ベクトル
//private Vector3 objNomalVector = Vector3.zero;
//// 跳ね返った後のverocity
//[HideInInspector] public Vector3 afterReflectVero = Vector3.zero;