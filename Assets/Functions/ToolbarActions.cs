using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum ToolbarAction
{
    Move,
    Attack
}

public class ToolbarActions : MonoBehaviour {

    public NavMeshAgent agent;
    public ToolbarAction action;

    // Use this for initialization
    void Start() {
        switch (action) {
            case (ToolbarAction.Move):
                {
                    GetComponent<ToolbarElement>().ClickFunction.AddListener(Move);
                    break;
                }
            case (ToolbarAction.Attack):
                {
                    GetComponent<ToolbarElement>().ClickFunction.AddListener(Attack);
                    break;
                }
        }
	}


    private void Move(RaycastHit hit)
    {
        StartCoroutine(move(hit.point));
    }

    private void Attack(RaycastHit hit)
    {
        StartCoroutine(attack(hit.collider.gameObject));
    }

    private IEnumerator move(Vector3 point)
    {
        agent.destination = point;
        yield return null;
        yield return new WaitAgentReachDestination(agent);
    }

    private IEnumerator follow(Transform transform)
    {
        do
        {
            agent.destination = transform.position;
            yield return null;
        } while (agent.remainingDistance > agent.stoppingDistance);
    }

    private IEnumerator attack(GameObject attacked)
    {
        yield return StartCoroutine(follow(attacked.transform));
        Destroy(attacked);
    }
}