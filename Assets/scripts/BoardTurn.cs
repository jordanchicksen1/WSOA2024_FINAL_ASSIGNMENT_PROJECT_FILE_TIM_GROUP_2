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


    public float Left = 90f;
    public float Right = -90f;

    public void TurnLeft()
    {

        boardTop.transform.Rotate(0, 0, Left);

        transform.RotateAround(boardTop.transform.position,Vector3.right,Left * Time.deltaTime);
        Debug.Log("Left");
        src.clip = sfx1;
        src.Play();
    }

    public void TurnRight()
    {
        boardTop.transform.Rotate(0, 0, Right);

        transform.RotateAround(boardTop.transform.position, Vector3.right, Right * Time.deltaTime);
        Debug.Log("Right");
        src.clip = sfx1;
        src.Play();
    }

    public void TurnLeftBoardBottom()
    {

        boardBottom.transform.Rotate(0, 0, Left);

        transform.RotateAround(boardBottom.transform.position, Vector3.right, Left * Time.deltaTime);
        Debug.Log("Left");
        src.clip = sfx1;
        src.Play();
    }

    public void TurnRightBoardBottom()
    {
        boardBottom.transform.Rotate(0, 0, Right);

        transform.RotateAround(boardBottom.transform.position, Vector3.right, Right * Time.deltaTime);
        Debug.Log("Right");
        src.clip = sfx1;
        src.Play();
    }

    public void TurnLeftBoardLeft()
    {

        boardLeft.transform.Rotate(0, 0, Left);

        transform.RotateAround(boardLeft.transform.position, Vector3.right, Left * Time.deltaTime);
        Debug.Log("Left");
        src.clip = sfx1;
        src.Play();
    }

    public void TurnRightBoardLeft()
    {
        boardLeft.transform.Rotate(0, 0, Right);

        transform.RotateAround(boardLeft.transform.position, Vector3.right, Right * Time.deltaTime);
        Debug.Log("Right");
        src.clip = sfx1;
        src.Play();
    }

    public void TurnLeftBoardRight()
    {

        boardRight.transform.Rotate(0, 0, Left);

        transform.RotateAround(boardRight.transform.position, Vector3.right, Left * Time.deltaTime);
        Debug.Log("Left");
        src.clip = sfx1;
        src.Play();
    }

    public void TurnRightBoardRight()
    {
        boardRight.transform.Rotate(0, 0, Right);

        transform.RotateAround(boardRight.transform.position, Vector3.right, Right * Time.deltaTime);
        Debug.Log("Right");
        src.clip = sfx1;
        src.Play();
    }
}

   

