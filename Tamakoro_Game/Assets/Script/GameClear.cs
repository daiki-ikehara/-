using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
	[SerializeField] GameObject clearPanel;
	[SerializeField] GameObject resultPanel;
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

		if (count == 12)
		{
			Time.timeScale = 0;
			clearPanel.SetActive(true);
		}
		StartCoroutine("panelfalse");
	}
	private void Update()
	{

	}


	IEnumerator panelfalse()
	{
		if(count==12)
		yield return new WaitForSecondsRealtime(1);
		clearPanel.SetActive(false);
	}
}
