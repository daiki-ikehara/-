using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectSceneButton : MonoBehaviour
{

    private AudioSource Titleaudio;

    [SerializeField]
    public AudioClip Titlesound;

    void Start()
    {
        Titleaudio = gameObject.AddComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            StartCoroutine("TitleSE");
        }
    }

    IEnumerator TitleSE()
    {
        Titleaudio.PlayOneShot(Titlesound);
        yield return new WaitForSecondsRealtime(0.8f);
        SceneManager.LoadScene("StageSelect");
    }
}

