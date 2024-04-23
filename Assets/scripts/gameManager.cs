using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject p1token;
    public GameObject p2token;
    bool player1 = true;
    bool player2 = false;
    public titleScreen titleScreen;
    public AudioSource src;
    public AudioClip sfx1;

    void Start()
    {
        titleScreen.p1Turn();
    }
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
            titleScreen.p1TurnFalse();
            titleScreen.p2Turn();
            src.clip = sfx1;
            src.Play();
            
       }

       if (Input.GetMouseButtonDown(1) && player2 == true)
       {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offset = new Vector3(0, 0, 10);
            Instantiate(p2token, pos + offset, Quaternion.identity);
            Debug.Log("right click");
            player2 = false;
            player1 = true;
            titleScreen.p1Turn();
            titleScreen.p2TurnFalse();
            src.clip = sfx1;
            src.Play();
       }

    }
}
