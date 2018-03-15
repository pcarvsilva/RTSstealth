using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;

public class InteractCommand : Command
{
    public override void OnClick(GameObject agent, RaycastHit hit)
    {
        BehaviourTreeAgent behaviourTreeAgent = agent.GetComponent<BehaviourTreeAgent>();
        behaviourTreeAgent.boolParameters["Interact"] = true;
        behaviourTreeAgent.gameObjectParameters["Follow"] = hit.collider.gameObject;

        behaviourTreeAgent.boolParameters["Move"] = false;
        behaviourTreeAgent.boolParameters["Attack"] = false;

        behaviourTreeAgent.Refresh();
    }
}
