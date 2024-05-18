using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTurn : MonoBehaviour
{
    public GameObject board;
    

    public float Left = 90f;
    public float Right = -90f;

    public void TurnLeft()
    {

        board.transform.Rotate(0, 0, Left);

        transform.RotateAround(board.transform.position,Vector3.right,Left * Time.deltaTime);
        Debug.Log("Left");
    }

    public void TurnRight()
    {
        board.transform.Rotate(0, 0, Right);

        transform.RotateAround(board.transform.position, Vector3.right, Right * Time.deltaTime);
        Debug.Log("Right");
    }
 }

   

