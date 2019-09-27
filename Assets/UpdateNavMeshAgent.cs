using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UpdateNavMeshAgent : StateMachineBehaviour
{
    public float speed;
    public bool GetOnParent;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NavMeshAgent agent;
        if (GetOnParent)
        {
            agent = animator.transform.parent.GetComponent<NavMeshAgent>();
        }
        else
        {
            agent = animator.GetComponent<NavMeshAgent>();
        }
        agent.speed = speed;
    }


}
