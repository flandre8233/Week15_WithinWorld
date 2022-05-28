using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAni : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void SetOpen(bool IsOpen)
    {
        animator.SetBool("IsOpen" , IsOpen);
    }
 
}
