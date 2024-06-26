using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject p1token;
    public GameObject p2token;
    //public GameObject clickedObject;
    /*public GameObject parentTop;
    public GameObject parentLeft;
    public GameObject parentRight;
    public GameObject parentBottom;*/
    //bool player1 = true;
   // bool player2 = false;
    public titleScreen titleScreen;
    public AudioSource src;
    public AudioClip sfx1;
    public tokenCounter tokenCounter;
    public bool p1NoTokens = false;
    public bool p2NoTokens = false;
    //int[,] boardUpState; //0 is empty, 1 is the universal token, 2 is player1 and 3 is player2
    //public int boardUpHeight = 3;
    //public int boardUpWidth = 3;
    //// 0 0 0
    // 0 0 0
    // 0 0 0
    //<<<<<<< Updated upstream


    //boardUpState = new int[boardUpHeight, boardUpWidth];


    //======
    //void Start()
    //{
    //    titleScreen.p1Turn();

    //    //boardUpState = new int[boardUpHeight, boardUpWidth];
    //}
    //void Update()
    //{

    //   if (Input.GetMouseButtonDown(0) && player1 == true)
    //   {
    //       Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //       Vector3 offset = new Vector3(0, 0, 10);
    //       Instantiate(p1token, pos + offset, Quaternion.identity);
    //       Debug.Log("left click");
    //        player1 = false;
    //        player2 = true;
    //        titleScreen.p1TurnFalse();
    //        titleScreen.p2Turn();
    //        src.clip = sfx1;
    //        src.Play();



    //   }

    //   if (Input.GetMouseButtonDown(1) && player2 == true)
    //   {
    //        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        Vector3 offset = new Vector3(0, 0, 10);
    //        Instantiate(p2token, pos + offset, Quaternion.identity);
    //        Debug.Log("right click");
    //        player2 = false;
    //        player1 = true;
    //        titleScreen.p1Turn();
    //        titleScreen.p2TurnFalse();
    //        src.clip = sfx1;
    //        src.Play();
    //   }

    //}
    //>>>>>>> Stashed changes

    //void UpdateBoardUpState()
    //{
    //    for (int row = 0;row < boardUpHeight; row++)
    //    {
    //        if (boardUpHeight[column,row] == 0)
    //        {
    //            if (player1)
    //            {
    //                boardUpState[Column, row] = 2;
    //            }
    //        }
    //    }
    //}

  
    private enum PlayerTurn
    {
        Nothing,
        Player1,
        Player2
    }

    private PlayerTurn playerTurn;

     void Start()
    {
        playerTurn = PlayerTurn.Player1;
        titleScreen.p1Turn();
        //boardUpState = new int[boardUpHeight, boardUpWidth];
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
        /*else
        {
            return;
        }*/
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
            Instantiate(p2token, pos + offset, Quaternion.identity, clickedObject.transform);
            Debug.Log("right click");
            playerTurn = PlayerTurn.Player1;
            titleScreen.p1Turn();
            titleScreen.p2TurnFalse();
            tokenCounter.decreaseP2Tokens();
            src.clip = sfx1;
            src.Play();
        }

        //if(tokenCounter.player2tokens == 0)
        //{
        //    p2NoTokens = true;
        //    Debug.Log("player 2 no tokens left");
        //}
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
            Instantiate(p1token, pos + offset, Quaternion.identity, clickedObject.transform);
            Debug.Log("left click");
            playerTurn = PlayerTurn.Player2;
            titleScreen.p1TurnFalse();
            titleScreen.p2Turn();
            tokenCounter.decreaseP1Tokens();
            src.clip = sfx1;
            src.Play();
        }

        //if(tokenCounter.player1tokens == 0)
        //{
        //    p1NoTokens = true;
        //    Debug.Log("player 1 no tokens left");
        //}
    }

    //public void showDrawScreen()
    //{
    //    if (p1NoTokens == true & p2NoTokens == true) 
    //    {
    //        Debug.Log("show draw screen");
    //        titleScreen.drawScene();
    //    }
    //}

}

