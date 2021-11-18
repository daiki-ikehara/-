using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_speed : MonoBehaviour
{
    void FixedUpdate()
    {
        Rigidbody rb = this.transform.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f, 0.0f, 0.0f);


        rb.AddForce(force); // 力を加える
    }
}
