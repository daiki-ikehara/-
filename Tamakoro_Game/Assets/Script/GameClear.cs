using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
	[SerializeField] GameObject clearPanel;
	// Update is called once per frame
	int count = 0;
	private void Start()
	{
		count = 0;
	}
	void OnCollisionEnter(Collision collision)
	{
		//        string yourTag = collision.gameObject.tag;

		if (collision.gameObject.tag == "coin")
		{
			count += 1;
		}
	}
	void Update()
	{
		if (count == 12)
		{
			Time.timeScale = 0f;
			clearPanel.SetActive(true);
		}
	}
}
