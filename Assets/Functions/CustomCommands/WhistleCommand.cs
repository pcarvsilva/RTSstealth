using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Command/Whistle")]
public class WhistleCommand : MoveCommand
{
    public override void OnClick(GameObject agent, RaycastHit hit)
    {
        SetMoveTarget(agent, hit);
        agent.GetComponent<BehaviorExecutor>().SetBehaviorParam("Skill", 2);
    }
}

