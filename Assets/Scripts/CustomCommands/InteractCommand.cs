using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Command/Interact")]
public class InteractCommand : MoveCommand
{

    public override void OnClick(BehaviorExecutor agent, RaycastHit hit)
    {
        base.OnClick(agent, hit);
        FollowTarget(agent, hit);
        agent.blackboard.SetBehaviorParam("toInteract", hit.collider.gameObject);
    }

    public override bool isPossible(RaycastHit hit)
    {
        return true;
    }
}
