using UnityEngine;

public class coin : MonoBehaviour
{
	public static int count = 0;
    private void OnTriggerEnter(Collider other)
    {
        //ballと衝突したら
        if (other.gameObject.CompareTag("Ball"))
        {
            gameObject.SetActive(false);
            count = count + 1;
        }
    }
}
