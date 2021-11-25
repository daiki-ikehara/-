using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    private Vector3 _prevPosition;
    float speed = 0;
    public GameObject Heart;
    // Start is called before the first frame update
    void Start()
    {
        _prevPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed == 0)
        {
            //Debug.Log("ぜろ");
        }
        else
        {
            Debug.Log("加速中");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            // アイテムが消える
            Destroy(Heart);
            if (Mathf.Approximately(Time.deltaTime, 0))
                return;
            speed = 10;
            // 現在位置取得
            var position = transform.position;

            // 現在速度計算
            var velocity = (position - _prevPosition) * speed/ Time.deltaTime;

            // 現在速度をログ出力
            print($"velocity = {velocity}");

            // 前フレーム位置を更新
            _prevPosition = position;
        }
        StartCoroutine("speedstop");

    }

    IEnumerator speedstop()
    {
        for (int i = 0; i < 450; i++)
        {
            yield return null;
        }
        speed = 0;
    }
}
