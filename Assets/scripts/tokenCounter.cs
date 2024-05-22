using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tokenCounter : MonoBehaviour
{
    public int player1tokens;
    public int player2tokens;
    public Text player1Text;
    public Text player2Text;
    public titleScreen titleScreen;
    public bool p1NoTokens = false;
    public bool p2NoTokens = false;

    [ContextMenu("decrease p1 token")]
    public void decreaseP1Tokens()
    {
        player1tokens = player1tokens - 1;
        player1Text.text = player1tokens.ToString("0");
        Debug.Log("player 1 used a token"); 

        if (player1tokens == 0)
        {
            p1NoTokens = true;
            Debug.Log("player 1 has no tokens");
        }
    }

    [ContextMenu("decrease p2 token")]
    public void decreaseP2Tokens()
    {
        player2tokens = player2tokens - 1;
        player2Text.text = player2tokens.ToString("0");
        Debug.Log("");

        if (player2tokens == 0)
        {
            p2NoTokens = true;
            Debug.Log("player 2 has no tokens");
        }

    }
    
    public void gameDraw()
    {
      if(p1NoTokens == true &&  p2NoTokens == true) 
        {
            titleScreen.drawScene();
        }

      //please work man please :( pls pls pls pls 
    }

    
































}
