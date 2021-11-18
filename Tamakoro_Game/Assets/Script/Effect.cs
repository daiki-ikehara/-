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
    private ParticleSystem shockwave;
    [SerializeField]
    private ParticleSystem getcoin;

    [SerializeField]
    private ParticleSystem heart;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall") //Wallタグの付いたゲームオブジェクトと衝突したか判別
        {
            shockwave.Play();
            Debug.Log("再生");
           
        }
        else
        {
            shockwave.Stop();
        }
        if (collision.gameObject.tag == "coin")
        {
            getcoin.Play();
        }
        else
        {
            getcoin.Stop();
        }
        if (collision.gameObject.tag == "Item")
        {
            heart.Play();
        }
        else
        {
            heart.Stop();
        }
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
