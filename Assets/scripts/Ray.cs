using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalCheck : MonoBehaviour
{
   Ray rayz;
   RaycastHit[] hit;

   public GameObject Univeral;
    public GameObject P1;
   public GameObject P2;
    public Vector3 direction = new Vector3(0,0, 0); 

    public void Start()
    {
        rayz = new Ray(Univeral.transform.position, direction);
       
    }

   public void CheckHit() 
   {
        hit = Physics.RaycastAll(rayz);
        if (hit.Length > 0) 
        {
            Debug.Log("hit");
        }
   }
}
