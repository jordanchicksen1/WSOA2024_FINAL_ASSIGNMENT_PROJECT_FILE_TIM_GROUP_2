using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class BoardTurn : MonoBehaviour
{
    public GameObject boardTop;
    public GameObject boardBottom;
    public GameObject boardLeft;
    public GameObject boardRight;
    public AudioSource src;
    public AudioClip sfx1;
    public bool hasPressedButton = false;
   


    public float Left = 90f;
    public float Right = -90f;

    public void TurnLeft()
    {
        if (hasPressedButton == false)
        {
            boardTop.transform.Rotate(0, 0, Left);

            transform.RotateAround(boardTop.transform.position, Vector3.right, Left * Time.deltaTime);
            Debug.Log("Left");
            src.clip = sfx1;
            src.Play();
            hasPressedButton = true;
            //universalTokenManager.OnTokenPlaced();


           
        }
    }

    public void TurnRight()
    {
        if (hasPressedButton == false)
        {
            boardTop.transform.Rotate(0, 0, Right);

            transform.RotateAround(boardTop.transform.position, Vector3.right, Right * Time.deltaTime);
            Debug.Log("Right");
            src.clip = sfx1;
            src.Play();
            hasPressedButton = true;


            
        }
    }

    public void TurnLeftBoardBottom()
    {
        if (hasPressedButton == false)
        {
            boardBottom.transform.Rotate(0, 0, Left);

            transform.RotateAround(boardBottom.transform.position, Vector3.right, Left * Time.deltaTime);
            Debug.Log("Left");
            src.clip = sfx1;
            src.Play();
            hasPressedButton = true;


            
        }
    }

    public void TurnRightBoardBottom()
    {
        if (hasPressedButton == false)
        {
            boardBottom.transform.Rotate(0, 0, Right);

            transform.RotateAround(boardBottom.transform.position, Vector3.right, Right * Time.deltaTime);
            Debug.Log("Right");
            src.clip = sfx1;
            src.Play();
            hasPressedButton = true;


            
        }
    }

    public void TurnLeftBoardLeft()
    {
        if (hasPressedButton == false)
        {
            boardLeft.transform.Rotate(0, 0, Left);

            transform.RotateAround(boardLeft.transform.position, Vector3.right, Left * Time.deltaTime);
            Debug.Log("Left");
            src.clip = sfx1;
            src.Play();
            hasPressedButton = true;



        }
    }

    public void TurnRightBoardLeft()
    {
        if (hasPressedButton == false)
        {
            boardLeft.transform.Rotate(0, 0, Right);

            transform.RotateAround(boardLeft.transform.position, Vector3.right, Right * Time.deltaTime);
            Debug.Log("Right");
            src.clip = sfx1;
            src.Play();
            hasPressedButton = true;


            
        }
    }

    public void TurnLeftBoardRight()
    {
        if (hasPressedButton == false)
        {
            boardRight.transform.Rotate(0, 0, Left);

            transform.RotateAround(boardRight.transform.position, Vector3.right, Left * Time.deltaTime);
            Debug.Log("Left");
            src.clip = sfx1;
            src.Play();
            hasPressedButton = true;


           
        }
    }

    public void TurnRightBoardRight()
    {
        if (hasPressedButton == false)
        {
            boardRight.transform.Rotate(0, 0, Right);

            transform.RotateAround(boardRight.transform.position, Vector3.right, Right * Time.deltaTime);
            Debug.Log("Right");
            src.clip = sfx1;
            src.Play();
            hasPressedButton = true;


           
        }
    }
}

   

