using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerMainMenu : MonoBehaviour
{
    public static UIManagerMainMenu Instance { set; get; }
    public GameObject Loader;
    public GameObject PlayBtn;
    public AudioSource backgroundAudio;
    public AudioSource PlayBtnAudio;

    private void Start()
    {
        Instance = this;
        // backgroundAudio.Pause();
    }

    public float delay = 6;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay) { 

        ShowPlayBtn();
        }
    }

    public void PlayGame()
    {
        // backgroundAudio.Play();
        PlayBtnAudio.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void ShowPlayBtn()
    {
        Time.timeScale = 1;
        // GameOverMenu.SetActive(true);
        PlayBtn.SetActive(true);
        timer += Time.deltaTime;
        if (timer > delay)
        {
            Loader.SetActive(false);
        }

        // backgroundAudio.Play();
        // backgroundAudio.Pause();
        // GameoverAudio.Play();
    }


    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
}
