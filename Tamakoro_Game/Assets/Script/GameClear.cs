using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
	[SerializeField] GameObject clearPanel;
	// Update is called once per frame
	void Update()
	{
		if (coin.count == 2)
		{
			Time.timeScale = 0f;
			clearPanel.SetActive(true);
		}
	}
}
