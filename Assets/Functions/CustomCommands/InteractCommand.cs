using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;

public class InteractCommand : ICommand
{
    public void OnClick(GameObject agent, RaycastHit hit)
    {
        BehaviourTreeAgent treeAgent = agent.GetComponent<BehaviourTreeAgent>();
        treeAgent.boolParameters["Attack"] = false;
        treeAgent.boolParameters["Move"] = false;
        treeAgent.boolParameters["Interact"] = true;

        treeAgent.gameObjectParameters["Follow"] = hit.collider.gameObject;

        treeAgent.Refresh();
    }
}
