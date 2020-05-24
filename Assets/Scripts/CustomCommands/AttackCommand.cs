using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Command/Attack")]
public class AttackCommand : MoveCommand
{
    public override void OnClick(BehaviorExecutor agent, RaycastHit hit)
    {
        agent.SetBehaviorParam("toDestroy", hit.collider.gameObject);
        FollowTarget(agent, hit);
    }

    public override bool isPossible(RaycastHit hit)
    {
        return hit.collider.GetComponent<Damageable>() != null;
    }
}
