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

    public GameObject BGMStop;//変数宣言

    // Update is called once per frame
   public int count = 0;
    private void Start()
    {
        coin.count = 0;
        BGMStop = GameObject.Find("SoundManager");
        resultflg = false;
    }
    void OnCollisionEnter(Collision collision)
    {
        //        string yourTag = collision.gameObject.tag;
        
        if (coin.count == 12)
        {

            Time.timeScale = 0;
            clearPanel.SetActive(true);
            paper.Play();
            //コンポーネントを取得
            BGMStop.GetComponent<BGMController>().BGMStoper();
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
        if (coin.count == 12)
        {
            yield return new WaitForSecondsRealtime(1);
        }
        clearPanel.SetActive(false);

        if (coin.count == 12 && !clearPanel.activeSelf)
        {
            resultPanel.SetActive(true);
            resultflg = true;

        }
    }
}
