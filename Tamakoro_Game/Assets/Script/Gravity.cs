using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    int Time = 0;
    private void Start()
    {
        
    }
    private void Update()
    {
        this.transform.position += new Vector3(0, -0.005f, 0);
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("当たった");
        while(Time <= 500){
            if (Time / 5 == 0)
            {
                this.transform.position += new Vector3(0, 0.005f, 0);
            }
            Time++;
        }
        Time = 0;
    }
}