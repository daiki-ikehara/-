using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
    [SerializeField] GameObject clearPanel;
    [SerializeField] private ParticleSystem paper;
    [SerializeField] GameObject resultPanel;

    public static bool resultflg = false;
    public static bool retryflg = false;


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

        if (count == 1)
        {

            Time.timeScale = 0;
            clearPanel.SetActive(true);
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

        if (resultflg == true)
        {
            if (Input.GetKeyDown("joystick button 1") || Input.GetKeyDown("joystick button 2"))
            {
                Debug.Log("ok");
                resultPanel.SetActive(false);
                retryflg = true;

            }
        }


    }


    IEnumerator panelfalse()
    {
        if (count == 1)
        {
            yield return new WaitForSecondsRealtime(1);
        }
        clearPanel.SetActive(false);

        if (count == 1 && !clearPanel.activeSelf)
        {
            resultPanel.SetActive(true);
            resultflg = true;

        }
    }
}
