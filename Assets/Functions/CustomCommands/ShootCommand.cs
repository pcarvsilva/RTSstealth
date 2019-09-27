using BBUnity.Actions;
using Pada1.BBCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Command/Shoot")]
public class ShootCommand : MoveCommand
{
    [InParam("skill")]
    public int Skill;

    public override void OnClick(GameObject agent, RaycastHit hit)
    {
        if (hit.collider.GetComponent<BehaviorExecutor>() == null)
        {
            CommandController.instance.Unsubscribe(this);
            ClearToolbar.Clear(agent);
            return;
        }
        SetMoveTarget(agent, hit);
        agent.GetComponent<BehaviorExecutor>().SetBehaviorParam("Skill", 3);
        agent.GetComponent<BehaviorExecutor>().SetBehaviorParam("shootPoint", hit.collider.transform);
    }
}