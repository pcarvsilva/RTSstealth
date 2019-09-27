using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Command/Attack")]
public class AttackCommand : Command
{
    public override void OnClick(GameObject agent, RaycastHit hit)
    {
        agent.GetComponent<BehaviorExecutor>().blackboard.SetBehaviorParam("Trap",true);
    }
}
