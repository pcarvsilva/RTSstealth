using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourBricksCommand : Command
{

    public BrickAsset behaviour;

    public override void OnClick(GameObject agent, RaycastHit hit)
    {
        //Only way possible to change a behaviour is creating one new component
        Destroy(agent.GetComponent<BehaviorExecutor>());

        BehaviorExecutor executor;
        executor = agent.AddComponent<BehaviorExecutor>();
        executor.behavior = behaviour;
        executor.blackboard.updateParams(behaviour.behavior.inParamValues);
        executor.blackboard.BuildBlackboard();


        OnClick(executor, hit);
    }

    public virtual void OnClick(BehaviorExecutor agent, RaycastHit hit)
    {

    }
}
