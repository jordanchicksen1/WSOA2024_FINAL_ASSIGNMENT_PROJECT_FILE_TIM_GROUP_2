using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1WinScreen : MonoBehaviour
{
    [SerializeField]
    ParticleSystem p1Win;

    public void Awake()
    {
        p1Win.Play();
    }
}
