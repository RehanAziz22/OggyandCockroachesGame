using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerStoriesScreen : MonoBehaviour
{
    public AudioSource BtnClickAudio;
    public GameObject SettingPanel;
    bool setingbtn = false;

    // Start is called before the first frame update
    // void Start()
    // {

    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }
    public void StoryOneLevels()
    {
        BtnClickAudio.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void StoryTwoLevels()
    {
        BtnClickAudio.Play();

        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    public void StoryThreeLevels()
    {
        BtnClickAudio.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }

    public void Setting()
    {
        if (!setingbtn){
            SettingPanel.SetActive(true);
            setingbtn=true;}
        else{
            SettingPanel.SetActive(false);
            setingbtn=false;} 
        
    }
}
