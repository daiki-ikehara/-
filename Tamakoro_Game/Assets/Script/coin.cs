using UnityEngine;

public class coin : MonoBehaviour
{
	public static int count = 0;
	void OnCollisionEnter(Collision collision)
	{
		// Ballと衝突したら
		if (collision.gameObject.tag == "Ball")
		{
			// アイテムが消える
			Destroy(gameObject);
			count = count + 1;
			//Debug.Log(count);
		}
	}
}
