using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class grid : MonoBehaviour
{
    
    public tokenCounter tokenCounter;
    public GameObject triangle;
    
  
     void OnTriggerEnter2D(Collider2D coll)
    {
       
        coll.transform.position= transform.position;

        if (coll.tag == "player1token")
        {
            Debug.Log("p1token placed");
            triangle.transform.Rotate(0f, 0f, -90.0f, Space.Self);

        }

        if (coll.tag == "player2token")
        {
            Debug.Log("p2token placed");
            triangle.transform.Rotate(0f, 0f, -90.0f, Space.Self);
        }
    }

    

}
