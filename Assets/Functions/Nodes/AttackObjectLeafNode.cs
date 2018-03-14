using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;
using UnityEngine.AI;
using NodeEditorFramework;

[Node(false, "AITools/Attack Object Node")]
public class AttackObjectLeafNode : LeafNode
{

    public string objectToAttack;
    public new const string ID = "attackObjectNode";
    public override string GetID { get { return ID; } }

    public override string Title { get { return "Attack GameObject Node"; } }
    public override Vector2 DefaultSize { get { return new Vector2(150, 60); } }

    protected override IEnumerator process(BehaviourTreeAgent agent)
    {
        GameObject toFollow = agent.gameObjectParameters[objectToAttack];
        BehaviourTreeNodeState state = stateForAgent(agent);
        GameObject.Destroy(toFollow);
        state.actualCondition = processCondition.Sucess;
        yield return null;

    }

}
