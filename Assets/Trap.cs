using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Trap : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Animator animator = other.gameObject.GetComponentInChildren<Animator>();
        animator.SetTrigger("Die");
    }

}
