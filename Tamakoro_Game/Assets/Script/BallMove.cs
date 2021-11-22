using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private float BallSpeed = 0.005f;
    Gravity gravity;
    collisiondetection col;
    GameObject ball;
    GameObject floor;
    private void Start()
    {
        
    }
    private void Update()
    {
        floor = GameObject.Find("Cube");
        col = floor.GetComponent<collisiondetection>();
        ball = GameObject.Find("Sphere");
        gravity = ball.GetComponent<Gravity>();

        if (col.RotateX > 0)
        {
            col.floorY = col.RotateX / -61f;
            col.floorY = col.floorY * (gravity.pos.z);
        }
        if (col.RotateX < 0)
        {
            col.floorY = col.RotateX / -61f;
            col.floorY = col.floorY * (gravity.pos.z);
        }
        if(col.RotateZ > 0)
        {
            col.floorY = col.RotateZ / 61f;
            col.floorY = col.floorY * (gravity.pos.x);
        }
        if (col.RotateZ < 0)
        {
            col.floorY = col.RotateZ / 61f;
            col.floorY = col.floorY * (gravity.pos.x);
        }

        if (col.floorX + 0.95f >= gravity.pos.x + col.radius && col.floorX - 0.95f <= gravity.pos.x - col.radius)
        {
            if (col.floorZ + 0.95f >= gravity.pos.z + col.radius && col.floorZ - 0.95f <= gravity.pos.z - col.radius)
            {
                if (col.RotateX > 0)
                {
                    gravity.pos.z += BallSpeed;
                }
                if (col.RotateX < 0)
                {
                    gravity.pos.z -= BallSpeed;
                }
                if (col.RotateZ > 0)
                {
                    gravity.pos.x -= BallSpeed;
                }
                if (col.RotateZ < 0)
                {
                    gravity.pos.x += BallSpeed;
                }
            }
            else if(col.floorZ + 0.95f < gravity.pos.z + col.radius)
            {
                gravity.pos.z = col.floorZ + 0.95f - col.radius;
            }
            else if (col.floorZ - 0.95f > gravity.pos.z - col.radius)
            {
                gravity.pos.z = col.floorZ - 0.95f + col.radius;
            }
        }
        else if (col.floorX + 0.95f < gravity.pos.x + col.radius)
        {
            gravity.pos.x = col.floorX + 0.95f - col.radius;
        }
        else if (col.floorX - 0.95f > gravity.pos.x - col.radius)
        {
            gravity.pos.x = col.floorX - 0.95f + col.radius;
        }
    }
}


////ボールが当たった物体の法線ベクトル
//private Vector3 objNomalVector = Vector3.zero;
//// 跳ね返った後のverocity
//[HideInInspector] public Vector3 afterReflectVero = Vector3.zero;