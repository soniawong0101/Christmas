using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public AudioSource StartBGM;
    AudioSource PlayBGM1;
    AudioSource PlayBGM2;
    public Canvas gameRules;

    public void Start()
    {
        PlayBGM1 = GameObject.Find("PlayBGM1").GetComponent<AudioSource>();
        PlayBGM2 = GameObject.Find("PlayBGM2").GetComponent<AudioSource>();
        PlayBGM1.enabled = false;
        PlayBGM2.enabled = false;
        gameRules.enabled = false;
    }
    public void LevelOne(string gameScene)
    {
        SceneManager.LoadScene(gameScene);
        PlayBGM1.enabled = true;
        StartBGM.enabled = false;
        Count.number = 0;
    }
    public void LevelTwo(string gameScene)
    {
        SceneManager.LoadScene(gameScene);
        StartBGM.enabled = false;
        PlayBGM2.enabled = true;
        Count.number = 0;
    }
    public void ExitGameBtn()
    {
        Application.Quit();
    }
    /*
    public void ShowGameRules()
    {
        gameRules.enabled = true;
        Time.timeScale = 0;
    }
    public void HideGameRules()
    {
        gameRules.enabled = false;
        Time.timeScale = 0;
    }*/
}
