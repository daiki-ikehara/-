using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private ParticleSystem footSmoke;
    private Rigidbody rb;
    
    [SerializeField]
    private ParticleSystem Light;
    [SerializeField]
    private ParticleSystem heart;
    [SerializeField]
    private ParticleSystem wallhit;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Wall") //Wallタグの付いたゲームオブジェクトと衝突したか判別
        {
            if (!wallhit.isEmitting)
            {
                wallhit.Play();
            }
            Debug.Log("再生");
           
        }
        else
        {
            Debug.Log("停止");
            if (!wallhit.isEmitting)
            {
                wallhit.Stop();
            }
        
        }
        //if (other.gameObject.tag == "Item")
        //{
        //    heart.Play();
        //    Light.Play();
        //}
        //else
        //{
        //    heart.Stop();
        //    Light.Stop();
        //}
    }
            void Update()
    {
        // 速度が0.1以上なら
        if (rb.velocity.magnitude > 0.1f)
        {
            // 再生
            if (!footSmoke.isEmitting)
            {
                footSmoke.Play();
            }
        }
        else
        {
            // 停止
            if (footSmoke.isEmitting)
            {
                footSmoke.Stop();
            }
        }
    }
}
