using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    float speed = 90;
    float lowspeed = 60;
​
    float MaxRotate = 30;
    float MinRotate = -30;
​
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float step = speed * Time.deltaTime;
        float Angle = transform.eulerAngles.z;

        if (Angle > 180)
        {
            // -180～180となるように補正
            Angle = Angle - 360;
        }

        if (x == 1)
        {
            Debug.Log("右");
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, -30), step);
            Debug.Log(Angle);
​
        }
        else if (x == -1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 30), step);
        }
        else if (y == 1)
        {
​
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(30, 0, 0), step);
        }
        else if (y == -1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-30, 0, 0), step);
        }
        else
        {
​
​
        }
    }
}
