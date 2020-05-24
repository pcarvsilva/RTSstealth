using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAnimationIntegration : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;

    public GameObject targetPosition;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float speed = agent.velocity.magnitude;

        //NormalizeSpeed
        speed = speed /agent.speed;

        animator.SetFloat("Speed",speed);
    }
}
