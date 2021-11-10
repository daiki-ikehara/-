using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
	[SerializeField] GameObject clearPanel;
<<<<<<< HEAD
	[SerializeField] GameObject resultPanel;

	public int result;
=======
>>>>>>> 6aa27ebd8ad13d27bb18c7fad4b8c87dae174129
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

		if (count == 1)
		{
			Time.timeScale = 0;
			clearPanel.SetActive(true);
			result = 1;
			
		}
		StartCoroutine("panelfalse");
	}
	private void Update()
	{

	}


	IEnumerator panelfalse()
	{
		if(count==1)
		yield return new WaitForSecondsRealtime(1);
		clearPanel.SetActive(false);
	}
}
