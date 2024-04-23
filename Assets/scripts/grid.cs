using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class grid : MonoBehaviour, IPointerClickHandler
{
    //public bool gridPiece = false;

    //void OnMouseDown()
    //{
    //    gridPiece = true;
    //    Debug.Log("gridpiece is true");
    //}

    //[SerializeField] GameObject gridPiece;
    //[SerializeField] float number;

    //void Start()
    //{
    //   for (int i = 0; i < number; i++) 
    //    { 
    //    for (int y = 0; y < number; y++) 
    //        { 
    //        GameObject grid = Instantiate(gridPiece) as GameObject;
    //            gridPiece.transform.position = new Vector3(i, y,0f);




    //        }
    //    }

    //}
    public tokenCounter tokenCounter;
    public GameObject triangle;

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
       
        coll.transform.position= transform.position;

        if (coll.tag == "player1token")
        {
            Debug.Log("p1token placed");
            tokenCounter.decreaseP1Tokens();
            triangle.transform.Rotate(0f, 0f, -90.0f, Space.Self);

        }

        if (coll.tag == "player2token")
        {
            Debug.Log("p2token placed");
            tokenCounter.decreaseP2Tokens();
            triangle.transform.Rotate(0f, 0f, -90.0f, Space.Self);
        }
    }

    

}
