using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Transform myTransform;
    private Vector3 pos;
    private float Gravity2;
    private float totalFallTime = 0f;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        pos = myTransform.position;
        Gravity2 = -9.81f;
    }

    void Update()
    {
        totalFallTime += Time.deltaTime;
        pos.y += (Gravity2 * Time.deltaTime) * totalFallTime;         //y座標への加算

        myTransform.position = pos;     //座標を設定
    }
}