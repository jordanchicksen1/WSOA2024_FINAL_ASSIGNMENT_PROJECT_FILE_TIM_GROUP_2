using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tokenCounter : MonoBehaviour
{
    public int player1tokens;
    public int player2tokens;
    public Text player1Text;
    public Text player2Text;

    [ContextMenu ("decrease p1 token")]
    public void decreaseP1Tokens()
    { 
    player1tokens = player1tokens - 1;
    player1Text.text = player1tokens.ToString("0");
        return;
    }

    [ContextMenu("decrease p2 token")]
    public void decreaseP2Tokens()
    {
        player2tokens = player2tokens - 1;
        player2Text.text = player2tokens.ToString("0");
        return;
    }


























}
