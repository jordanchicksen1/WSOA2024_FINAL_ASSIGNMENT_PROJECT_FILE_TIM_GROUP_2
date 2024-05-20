using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UniversalCheck : MonoBehaviour
{

    public SpriteRenderer Renderer;
    public GameObject circle;
    /*Ray rayDown;
    RaycastHit[] hit;

    public GameObject Univeral;
    public GameObject P1;
    public GameObject P2;
    public Vector3 direction = new Vector3(0,0, 0); 

     public void Start()
     {
         rayDown = new Ray(Univeral.transform.position, direction);
     }

     public void CheckHit()
     {
         hit = Physics.RaycastAll(rayDown);

         if (P1 != null) 
         {
             Debug.Log("hit");
         }
    }*/

    private void FixedUpdate()
    {
        /*RaycastHit2D hitDown = Physics2D.Raycast(transform.position, -Vector2.up);
        RaycastHit2D hitRight= Physics2D.Raycast (transform.position, Vector2.right);
        RaycastHit2D hitUp= Physics2D.Raycast (transform.position,Vector2.up);    
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, -Vector2.right);
        

        if(hitDown.collider) 
        {
            Debug.Log("hitDown");
            Renderer.color = Color.blue;
        }

        if(hitRight.collider) 
        {
            Debug.Log("hitRight");
            Renderer.color = Color.green;
        }
       
        if(hitUp.collider) 
        {
            Debug.Log("hitUp");
            Renderer.color = Color.yellow;
        }

        if (hitLeft.collider) 
        {
            Debug.Log("hitLeft");
            Renderer.color = Color.cyan;
        }*/

        /*RaycastHit2D[] hits;
        hits = Physics2D.RaycastAll(transform.position, Vector2.right);

        for (int i = 0; i < hits.Length; i++) 
        {
        RaycastHit2D hit = hits[i];
        Renderer rend =hit.transform.GetComponent<Renderer>();

            if (rend) 
            {
                Debug.Log("hit");
                //Renderer.color = Color.blue;
            }

           
        }*/
    }
}
