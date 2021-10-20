using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            Debug.Log("当たった!");
        }
    }
}

