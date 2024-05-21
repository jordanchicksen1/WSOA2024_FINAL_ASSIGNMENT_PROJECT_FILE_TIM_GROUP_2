using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winChecker : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    { 
    if(other.tag == "UT2Check1")
        {
            Debug.Log("hit check1");
        }
    
    if(other.tag == "UT2Check2")
        {
            Debug.Log("hit check2");
        }

    if (other.tag == "UT2Check3")
        {
            Debug.Log("hit check3");
        }
    }
    
}
