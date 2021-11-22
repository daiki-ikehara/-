using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEffect : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem coinef;

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Ball") //Ballタグの付いたゲームオブジェクトと衝突したか判別
        {
            if (!coinef.isEmitting)
            {
                coinef.Play();
            }
        }
        else
        {
            if (!coinef.isEmitting)
            {
                coinef.Stop();
            }
        }
    }
}
