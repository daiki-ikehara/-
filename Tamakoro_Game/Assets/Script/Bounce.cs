using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Transform Object;
    private Vector3 Center;
    private float x;
    private float y;
    private float z;
    private float radius = 0.1f;
    private float cubeX = 1f;
    private float cubeY = 0.05f;
    private float cubeZ = 1f;

    // Use this for initialization
    private void Start()
    {
        Object = GetComponent<Transform>();
        Center = Object.position;
    }
    private void Update()
    {
        x = Center.x;
        y = Center.y;
        z = Center.z;
        if (this.gameObject.tag == "Floor")
        {
            x = Center.x;
            y = Center.y;
            z = Center.z;
        }
        if (this.gameObject.tag == "Ball")
        {
            
        }
        if (this.gameObject.tag == "Coin")
        {
        }
    }
}

////ボールが当たった物体の法線ベクトル
//private Vector3 objNomalVector = Vector3.zero;
//// 跳ね返った後のverocity
//[HideInInspector] public Vector3 afterReflectVero = Vector3.zero;