using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { set; get; }

    public GameObject GameOverMenu;
    public GameObject PauseMenu;

    // private int levelValue;
    public GameObject PauseBtn;
    public GameObject ExitBtn;
    public GameObject movementBtns;
    public AudioSource GameoverAudio;
    public AudioSource levelCompleteAudio;
    public AudioSource BackgroundAudio;
    public AudioSource PauseBtnAudio;
    private StoryOneLevels storyOneLevels;
    public GameObject videoScene;
    public GameObject cockroach;   

    public int currentLevel;
    float count = 0;

    private void Start()
    {
        Instance = this;
        storyOneLevels = StoryOneLevels.Instance;
        currentLevel = storyOneLevels.currentLevel;
        // BackgroundAudio.Play();
        PauseBtnAudio.Play();
        Debug.Log(currentLevel);

        // BackgroundAudio.Pause();
    }

    public void storyOneEnd()
    { //48.2
        Time.timeScale = 1;
        BackgroundAudio.Pause();
        videoScene.SetActive(true);
        cockroach.SetActive(false);
        StartCoroutine(StartNextSceneAfterDelay(29.2f));
    }

    public void skipVideo()
    {
        StartCoroutine(StartNextSceneAfterDelay(0.0f));
    }

    private IEnumerator StartNextSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        videoScene.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ExitDoor")
        {
            ExitBtn.SetActive(true);
        }
    }

    public void PlayGame()
    {
        // BackgroundAudio.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Gameover()
    {
        Time.timeScale = 0;
        GameOverMenu.SetActive(true);
        PauseBtn.SetActive(false);
        // Time.timeScale = 0;
        movementBtns.SetActive(false);

        BackgroundAudio.Pause();
        GameoverAudio.Play();
    }

    public void GameEnd()
    {
        BackgroundAudio.Pause();
        ExitBtn.SetActive(true);
        if (count < 1)
        {
            levelCompleteAudio.Play();
            count++;
        }
        Time.timeScale = 1;
        // GameoverAudio.Play();
    }

    public void restartGame()
    {
        ExitBtn.SetActive(false);
        Time.timeScale = 1;
        // movementBtns.SetActive(true);

        SceneManager.LoadScene(currentLevel);
        BackgroundAudio.Play();
        // GameoverAudio.Pause();
        // PauseBtn.SetActive(true);
    }

    public void nextLevel()
    {
        Time.timeScale = 1;
        // currentLevel = currentLevel++;
        // SceneManager.LoadScene(currentLevel);
        // Debug.Log(currentLevel);

        if (currentLevel <= 7)
        {
            SceneManager.LoadScene(2);
        }else if(currentLevel>7)
        {
            SceneManager.LoadScene(3);
        }
        // BackgroundAudio.Play();
        // GameoverAudio.Pause();
        // PauseBtn.SetActive(true);
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        PauseBtn.SetActive(false);
        movementBtns.SetActive(false);
        PauseBtnAudio.Play();
        BackgroundAudio.Pause();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        // movementBtns.SetActive(true);
        PauseMenu.SetActive(false);
        PauseBtn.SetActive(true);
        BackgroundAudio.Play();
    }

    public void QuitStory1()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitStory2()
    {
        SceneManager.LoadScene(3);
    }

    // Story 3 functions

    public void QuitStory3() //quitbutton
    {
        SceneManager.LoadScene(1);
    }

    public void restartStory3() //play button
    {
        ExitBtn.SetActive(false);
        Time.timeScale = 1;
        // movementBtns.SetActive(true);

        SceneManager.LoadScene(4);
        BackgroundAudio.Play();
        // GameoverAudio.Pause();
        // PauseBtn.SetActive(true);
    }
}
