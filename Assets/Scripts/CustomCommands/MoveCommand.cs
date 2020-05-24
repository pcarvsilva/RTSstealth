using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Command/Move")]
public class MoveCommand : BehaviourBricksCommand
{

    public void SetMoveTarget(BehaviorExecutor agent,RaycastHit hit)
    {
        GameObject target = agent.GetComponent<NavMeshAnimationIntegration>().targetPosition;
        target.transform.SetParent(null);
        target.transform.position = hit.point;
        agent.blackboard.SetBehaviorParam("moveTarget", target);
    }

    public void FollowTarget(BehaviorExecutor agent,RaycastHit hit)
    {
        GameObject target = agent.GetComponent<NavMeshAnimationIntegration>().targetPosition;
        target.transform.SetParent(hit.collider.transform);
        target.transform.localPosition = new Vector3(0, 0, 0);
        agent.blackboard.SetBehaviorParam("moveTarget", target);
    }

    public override bool isPossible(RaycastHit hit)
    {
        NavMeshHit navHit = new NavMeshHit();
        return NavMesh.SamplePosition(hit.point,out navHit,0.2f, NavMesh.AllAreas) ;
    }

    public override void OnClick(BehaviorExecutor agent, RaycastHit hit)
    {
        SetMoveTarget(agent, hit);
        agent.GetComponentInChildren<ToggleGroup>().SetAllTogglesOff();
    }
}
