using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using static Token;

public class gameManager : MonoBehaviour
{
    public Token p1token;
    public Token p2token;

    [SerializeField]
    private UnityEvent<Token> tokenPlaced;
    public titleScreen titleScreen;
    public AudioSource src;
    public AudioClip sfx1;
    public tokenCounter tokenCounter;
    public bool p1NoTokens = false;
    public bool p2NoTokens = false;
  

  
    private enum PlayerTurn
    {
        Nothing,
        Player1,
        Player2
    }

    private PlayerTurn playerTurn;

    public void PlayerWon(Token token)
    {
       Debug.Log($"<color=green>Player {token.PlayerNumber} has won!</color>");

        if (token.PlayerNumber == PlayerToken.PlayerOne) 
        {
            SceneManager.LoadScene("P1 Win Scene");
            Debug.Log($"<color=blue> you can put the scene transition here</color>");
        }

        if (token.PlayerNumber == PlayerToken.PlayerTwo)
        {
            SceneManager.LoadScene("P2 Win Scene");
            Debug.Log($"<color=purple> you can put the scene transition here </color>");
        }


    }

    private void Start()
    {
        playerTurn = PlayerTurn.Player1;
        titleScreen.p1Turn();
       
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            switch (playerTurn)
            {
                case PlayerTurn.Player1:
                    PlayerOneTurn();
                    break;
                case PlayerTurn.Player2:
                    PlayerTwoTurn();
                    break;
            }
        }
       
    }

    private void PlayerTwoTurn()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        GameObject clickedObject = hit.collider.gameObject;
        if (clickedObject.CompareTag("gridPiece") && clickedObject.transform.childCount == 0 && tokenCounter.player2tokens > 0.99)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offset = new Vector3(0, 0, 10);
            Token clone = Instantiate(p2token, pos + offset, Quaternion.identity, clickedObject.transform);
            tokenPlaced.Invoke(clone);
            
            Debug.Log("right click");
            playerTurn = PlayerTurn.Player1;
            titleScreen.p1Turn();
            titleScreen.p2TurnFalse();
            tokenCounter.decreaseP2Tokens();
            src.clip = sfx1;
            src.Play();
        }

       
    }
    
    

    private void PlayerOneTurn()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        GameObject clickedObject = hit.collider.gameObject;
        if (clickedObject.CompareTag("gridPiece") && clickedObject.transform.childCount == 0 && tokenCounter.player1tokens > 0.99)
        {

            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offset = new Vector3(0, 0, 10);
            var clone = Instantiate(p1token, pos + offset, Quaternion.identity, clickedObject.transform);
            tokenPlaced.Invoke(clone);
            Debug.Log("left click");
            playerTurn = PlayerTurn.Player2;
            titleScreen.p1TurnFalse();
            titleScreen.p2Turn();
            tokenCounter.decreaseP1Tokens();
            src.clip = sfx1;
            src.Play();
        }

        
    }

    

}

