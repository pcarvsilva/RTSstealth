using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Command/UseObjectOnMove")]
public class UseObjectOnMoveCommand : MoveCommand
{
    public string objectTag;

    public override void OnClick(BehaviorExecutor agent, RaycastHit hit)
    {
        SetMoveTarget(agent, hit);
        agent.SetBehaviorParam("toActivate", agent.gameObject.FindChildWithTag(objectTag));
    }
}

