using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;

public class MoveCommand : Command {

    public override void OnClick(GameObject agent, RaycastHit hit)
    {
        BehaviourTreeAgent behaviourTreeAgent = agent.GetComponent<BehaviourTreeAgent>();
        behaviourTreeAgent.vector3Parameters["Move"] = hit.point;
        behaviourTreeAgent.boolParameters["Move"] = true;
    }

}
