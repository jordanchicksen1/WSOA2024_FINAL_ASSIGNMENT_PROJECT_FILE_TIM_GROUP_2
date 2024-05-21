using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class titleScreen : MonoBehaviour
{
    public GameObject p1turnScreen;
    public GameObject p2turnScreen;
    public GameObject drawScreen;
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
    public void p1Turn()
    {
        p1turnScreen.SetActive(true);
    }

    public void p2Turn()
    { 
        p2turnScreen.SetActive(true);
    }

    public void p1TurnFalse()
    { 
        p1turnScreen.SetActive(false);
    }

    public void p2TurnFalse()
    { 
        p2turnScreen.SetActive(false);
    }

    public void playerOneWins()
    {
        SceneManager.LoadScene("P1 Win Scene");
    }

    public void playerTwoWins()
    {
        SceneManager.LoadScene("P2 Win Scene");
    }

    public void drawScene()
    {
        SceneManager.LoadScene("Draw Scene");
    }
}
