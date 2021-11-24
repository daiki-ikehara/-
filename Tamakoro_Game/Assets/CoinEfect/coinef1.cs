using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinef1 : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem coinef;
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Wall") //Wallタグの付いたゲームオブジェクトと衝突したか判別
        {
            if (!coinef.isEmitting)
            {
                coinef.Play();
            }
            Debug.Log("再生");

        }
        else
        {
            Debug.Log("停止");
            if (!coinef.isEmitting)
            {
                coinef.Stop();
            }

        }
    }
}
