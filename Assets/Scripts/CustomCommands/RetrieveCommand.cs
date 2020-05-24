using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Command/RetrieveObject")]
public class RetrieveCommand : MoveCommand
{

    public override void OnClick(BehaviorExecutor agent, RaycastHit hit)
    {
        SetMoveTarget(agent, hit);
        agent.blackboard.SetBehaviorParam("toRetrive", hit.collider.gameObject);
    }

    public override bool isPossible(RaycastHit hit)
    {
        return true;
    }
}
