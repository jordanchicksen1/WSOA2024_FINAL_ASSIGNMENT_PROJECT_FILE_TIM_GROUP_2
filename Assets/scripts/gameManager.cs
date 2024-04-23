using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject p1token;
    public GameObject p2token;
    bool player1 = true;
    bool player2 = false;

    private enum PlayerTurn
    {
        Nothing,
        Player1,
        Player2
    }
    
    private PlayerTurn playerTurn;

    private void Start()
    {
        playerTurn = PlayerTurn.Player1;
    }

    void Update()
    {
       if (Input.GetMouseButtonDown(0))
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
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 offset = new Vector3(0, 0, 10);
        Instantiate(p2token, pos + offset, Quaternion.identity);
        Debug.Log("right click");
        playerTurn = PlayerTurn.Player1;
    }

    private void PlayerOneTurn()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 offset = new Vector3(0, 0, 10);
        Instantiate(p1token, pos + offset, Quaternion.identity);
        Debug.Log("left click");
        playerTurn = PlayerTurn.Player2;
    }
}
