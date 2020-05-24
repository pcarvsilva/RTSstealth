using BBUnity.Actions;
using Pada1.BBCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Command/Shoot")]
public class ShootCommand : MoveCommand
{

    public override void OnClick(BehaviorExecutor agent, RaycastHit hit)
    {

        if (hit.collider.GetComponent<BehaviorExecutor>() == null)
        {
            SetMoveTarget(agent, hit);
        }
        else
        {
            FollowTarget(agent, hit);
        }
        agent.SetBehaviorParam("toDestroy", hit.collider.gameObject);
    }

    public override bool isPossible(RaycastHit hit)
    {
        return hit.collider.GetComponent<Damageable>() != null;
    }
}