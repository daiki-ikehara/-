using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondetection : MonoBehaviour
{
    private Transform Object;
    private Vector3 Center;
    public float floorX = 0f;
    public float floorY = 0f;
    public float floorZ = 0f;
    public float RotateX = 0f;
    public float RotateZ = 0f;
    public float radius = 0.1f;
    public float coinX = 0f;
    public float coinY = 0f;
    public float coinZ = 0f;
    floor Floor;
    GameObject floor;

    // Use this for initialization
    private void Start()
    {
        Object = GetComponent<Transform>();
        Center = Object.position;
        if (this.gameObject.tag == "Floor")
        {
            floorX = Center.x;
            floorY = Center.y;
            floorZ = Center.z;
        }
        if (this.gameObject.tag == "Ball")
        {

        }
        if (this.gameObject.tag == "Coin")
        {
            coinX = Center.x;
            coinY = Center.y;
            coinZ = Center.z;
        }
    }
    private void Update()
    {
        if (this.gameObject.tag == "Floor")
        {
            floor = GameObject.Find("Cube");
            Floor = floor.GetComponent<floor>();
            RotateX = Floor.xRotate;
            RotateZ = Floor.zRotate;
        }

    }
}
