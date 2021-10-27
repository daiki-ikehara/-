using UnityEngine;

public class Destroy : MonoBehaviour
{
	public static int count = 0;
	void OnCollisionEnter(Collision collision)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (collision.gameObject.tag == "Player")
		{
			// アイテムが消える
			Destroy(gameObject);
			count = count + 1;
			Debug.Log(count);
		}
	}
}