using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject p1token;
    public GameObject p2token;
    bool player1 = true;
    bool player2 = false;
     

    void Update()
    {
       if (Input.GetMouseButtonDown(0) && player1 == true)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offset = new Vector3(0, 0, 10);
            Instantiate(p1token, pos + offset, Quaternion.identity);
            Debug.Log("left click");
            player1 = false;
            player2 = true;
        }

       if (Input.GetMouseButtonDown(1) && player2 == true)
       {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           Vector3 offset = new Vector3(0, 0, 10);
          Instantiate(p2token, pos + offset, Quaternion.identity);
            Debug.Log("right click");
            player2 = false;
            player1 = true;
        }

    }
}
