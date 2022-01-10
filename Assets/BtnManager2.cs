using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager2 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Count.number = 0;
    }
    public void BackToMenu(string gameScene)
    {
        SceneManager.LoadScene(gameScene);
        //Count.number = 0;
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        Count.number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
