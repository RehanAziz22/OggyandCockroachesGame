using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryOneLevels : MonoBehaviour
{
    // Start is called before the first frame update
    public static StoryOneLevels Instance { set; get; }

    public int currentLevel;
    public GameObject videoScene;
    
    public GameObject SettingPanel;
    public GameObject levelsPanel;
    bool setingbtn = false;

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

        currentLevel = 5;
        Time.timeScale = 1;
        videoScene.SetActive(true);
        StartCoroutine(StartNextSceneAfterDelay(22.7f));
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
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelTwo()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 6;
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelThree()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 7;
        SceneManager.LoadScene(currentLevel);
    }

    public void LevelFour()
    {
        // backgroundAudio.Play();
        Time.timeScale = 1;
        currentLevel = 8;
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
     public void Setting()
    {
        if (!setingbtn){
            SettingPanel.SetActive(true);
            levelsPanel.SetActive(false);
            setingbtn=true;}
        else{
            SettingPanel.SetActive(false);
            levelsPanel.SetActive(true);
            setingbtn=false;} 
        
    }
}
