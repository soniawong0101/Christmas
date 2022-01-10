using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
    Animator anim;
    private void Start()
    {
        Count.number = 0;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Count.number = 0;
    }
    public void LevelTwo(string gameScene) {
        SceneManager.LoadScene(gameScene);
        //Count.number = 0;
        Time.timeScale = 1;
    }


}

