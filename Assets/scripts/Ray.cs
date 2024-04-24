using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalCheck : MonoBehaviour
{
   Ray rayDown;
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
   }
}
