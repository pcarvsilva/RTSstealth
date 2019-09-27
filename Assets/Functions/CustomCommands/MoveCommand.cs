using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Command/Move")]
public class MoveCommand : Command
{

    public void SetMoveTarget(GameObject agent,RaycastHit hit)
    {
        GameObject target = agent.GetComponent<NavMeshAnimationIntegration>().targetPosition;
        target.transform.SetParent(null);
        target.transform.position = hit.point;
    }

    public override void OnClick(GameObject agent, RaycastHit hit)
    {
        SetMoveTarget(agent, hit);
        agent.GetComponent<BehaviorExecutor>().SetBehaviorParam("Skill",0);
        agent.GetComponentInChildren<ToggleGroup>().SetAllTogglesOff();
    }
}
