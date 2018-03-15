using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;

public class AttackCommand : Command {

    public override void OnClick(GameObject agent, RaycastHit hit)
    {
        BehaviourTreeAgent behaviourTreeAgent = agent.GetComponent<BehaviourTreeAgent>();
        behaviourTreeAgent.boolParameters["Attack"] = true;
        behaviourTreeAgent.gameObjectParameters["Follow"] = hit.collider.gameObject;

        behaviourTreeAgent.boolParameters["Move"] = false;
        behaviourTreeAgent.boolParameters["Interact"] = false;

        behaviourTreeAgent.Refresh();
    }
}
