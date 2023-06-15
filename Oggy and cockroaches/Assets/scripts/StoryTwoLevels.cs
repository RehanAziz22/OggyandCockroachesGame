using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryTwoLevels : MonoBehaviour
{
    // Start is called before the first frame update
    public static StoryTwoLevels Instance { set; get; }

    public int currentLevel;

    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update() { }

    // Your float value


    public void BackToMainMenu()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void LevelOne()
    {
        // backgroundAudio.Play();
        currentLevel = 8;
        Time.timeScale = 1;
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelTwo()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 9;
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelThree()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 10;
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelFour()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 8;
        // currentDisplayLevel = "Level4";
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelFive()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 9;
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelSix()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 10;
        // currentDisplayLevel = "Level6";
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelSeven()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 11;
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelEight()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 12;
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelTen()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 13;
        SceneManager.LoadScene(currentLevel);
    }
}
