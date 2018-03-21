using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;

public class MoveCommand : ICommand
{
    public void OnClick(GameObject agent, RaycastHit hit)
    {
        BehaviourTreeAgent treeAgent = agent.GetComponent<BehaviourTreeAgent>();
        treeAgent.boolParameters["Attack"] = false;
        treeAgent.boolParameters["Move"] = true;
        treeAgent.boolParameters["Interact"] = false;

        treeAgent.vector3Parameters["Move"] = hit.point;

        treeAgent.Refresh();
    }

}
