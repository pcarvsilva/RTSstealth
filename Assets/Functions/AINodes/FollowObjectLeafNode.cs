using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;
using UnityEngine.AI;
using NodeEditorFramework;

[Node(false, "AITools/Follow Object Node")]
public class FollowObjectLeafNode : LeafNode {

    public string objectToFollow;
    public new const string ID = "followObjectNode";
    public override string GetID { get { return ID; } }

    public override string Title { get { return "Follow GameObject Node"; } }
    public override Vector2 DefaultSize { get { return new Vector2(150, 60); } }

    protected override IEnumerator process(BehaviourTreeAgent agent)
    {
        BehaviourTreeNodeState state = stateForAgent(agent);
        GameObject toFollow = null;
        try {
            toFollow = agent.gameObjectParameters[objectToFollow];
        }
        catch {
            state.actualCondition = processCondition.Failure;
            yield break;
        }
        if(toFollow == null)
        {
            state.actualCondition = processCondition.Failure;
            yield break;
        }
        NavMeshAgent navAgent = agent.GetComponent<NavMeshAgent>();

        Vector3 previousTargetPosition = new Vector3(float.PositiveInfinity, float.PositiveInfinity);
        while (Vector3.SqrMagnitude(agent.transform.position - toFollow.transform.position) > navAgent.stoppingDistance)
        {
            // did target move more than at least a minimum amount since last destination set?
            if (Vector3.SqrMagnitude(previousTargetPosition - toFollow.transform.position) > 0.1f)
            {
                if (navAgent.SetDestination(toFollow.transform.position) == false)
                {
                    state.actualCondition = processCondition.Failure;
                    yield break;
                }
                previousTargetPosition = toFollow.transform.position;
            }
            yield return null;
        }
        state.actualCondition = processCondition.Sucess;
    }

}
