using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
	[SerializeField]private ParticleSystem paper;
	[SerializeField] GameObject clearPanel;
	[SerializeField] GameObject resultPanel;

	public int result;
	// Update is called once per frame
	public int count = 0;
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
			result = 1;
			paper.Play();
		}
        else
        {
			paper.Stop();
        }
		StartCoroutine("panelfalse");
		resultPanel.SetActive(false);
	}
	private void Update()
	{
	
	}


	IEnumerator panelfalse()
	{
		if (count == 12)
			yield return new WaitForSecondsRealtime(1);
		clearPanel.SetActive(false);
		resultPanel.SetActive(true);
	}
}
