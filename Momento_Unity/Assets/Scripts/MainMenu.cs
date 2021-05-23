using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame

    public void QuitGame(){
        Application.Quit();
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene(10);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
