using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;

public class AttackCommand : ICommand
{
    public void OnClick(GameObject agent, RaycastHit hit)
    {
        BehaviourTreeAgent treeAgent = agent.GetComponent<BehaviourTreeAgent>();
        treeAgent.boolParameters["Attack"] = true;
        treeAgent.boolParameters["Move"] = false;
        treeAgent.boolParameters["Interact"] = false;

        treeAgent.gameObjectParameters["Follow"] = hit.collider.gameObject;

        treeAgent.Refresh();
    }
}
