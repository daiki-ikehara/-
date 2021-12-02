using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    int xB = 0;
    int bcount;
    public GameClear clear;
    public TimerController start;
    public Select ST;  //Stop = 0

    private AudioSource audio;

    [SerializeField]
    public AudioClip sound;
    public AudioClip sound2;

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
        audio = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (coin.count != 12 && start.time == 1)
        {
            if (Input.GetKeyDown("joystick button 7") && xB == 0)
            {
                Time.timeScale = 0;  // 時間停止
                pausePanel.SetActive(true);
                audio.PlayOneShot(sound);
                xB++;

                Debug.Log("button7");
            }
            else if (Input.GetKeyDown("joystick button 7") && xB == 1 && ST.Stop == 0)
            {
                Time.timeScale = 1;  // 再開
                pausePanel.SetActive(false);
                audio.PlayOneShot(sound);
                audio.PlayOneShot(sound2);
                xB--;

                Debug.Log("button7");
            }
        }
    }
}
