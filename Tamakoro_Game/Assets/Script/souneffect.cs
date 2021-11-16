using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class souneffect : MonoBehaviour
{
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }
}
