using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardLocker : MonoBehaviour
{
    public GameObject topLeft;
    public GameObject topRight;
    public GameObject bottomLeft;
    public GameObject bottomRight;
    public GameObject leftRight;
    public GameObject rightRight;
    public GameObject leftLeft;
    public GameObject rightLeft;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "topTrigger") 
        {
            topLeft.SetActive(false);
            topRight.SetActive(false);

            bottomLeft.SetActive(true);
            bottomRight.SetActive(true);

            leftRight.SetActive(true);
            rightRight.SetActive(true);

            leftLeft.SetActive(true);
            rightLeft.SetActive(true);
            Debug.Log($"<color=red> hit top trigger </color>");
        }

        if (other.tag == "rightTrigger")
        {
            topLeft.SetActive(true);
            topRight.SetActive(true);

            bottomLeft.SetActive(true);
            bottomRight.SetActive(true);

            leftRight.SetActive(false);
            rightRight.SetActive(false);

            leftLeft.SetActive(true);
            rightLeft.SetActive(true);
            Debug.Log($"<color=yellow> hit right trigger </color>");
        }

        if (other.tag == "leftTrigger")
        {
            topLeft.SetActive(true);
            topRight.SetActive(true);

            bottomLeft.SetActive(true);
            bottomRight.SetActive(true);

            leftRight.SetActive(true);
            rightRight.SetActive(true);

            leftLeft.SetActive(true);
            rightLeft.SetActive(true);
            Debug.Log($"<color=orange> hit left trigger </color>");
        }

        if (other.tag == "bottomTrigger")
        {
            topLeft.SetActive(true);
            topRight.SetActive(true);

            bottomLeft.SetActive(false);
            bottomRight.SetActive(false);

            leftRight.SetActive(true);
            rightRight.SetActive(true);

            leftLeft.SetActive(true);
            rightLeft.SetActive(true);
            Debug.Log($"<color=cyan> hit bottom trigger </color>");
        }
    }
}
