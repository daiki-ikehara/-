using UnityEngine;

public class coin : MonoBehaviour
{
	public static int count = 0;
	void OnTriggerEnter(Collider other)
	{
		// Ballと衝突したら
		if (other.gameObject.CompareTag("Ball"))
		{
			// アイテムが消える
			gameObject.SetActive(false);
			count = count + 1;
			//Debug.Log(count);
		}
	}
}
