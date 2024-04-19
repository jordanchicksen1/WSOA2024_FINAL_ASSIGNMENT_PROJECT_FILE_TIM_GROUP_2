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

    public void backToMenu()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void optionsMenu()
    {
        SceneManager.LoadScene("Options");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
