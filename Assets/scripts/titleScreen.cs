using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class titleScreen : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void backToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void optionsMenu()
    {
        SceneManager.LoadScene("Options");
    }

    public void nextTutorial()
    {
        SceneManager.LoadScene("Tutorial2");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
