using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;
using UnityEngine.AI;
using NodeEditorFramework;

[Node(false, "AITools/Interact Object Node")]
public class InteractLeafNode : LeafNode
{

    public string objectToInteract;
    public new const string ID = "interactNode";
    public override string GetID { get { return ID; } }

    public override string Title { get { return "Interact GameObject Node"; } }
    public override Vector2 DefaultSize { get { return new Vector2(150, 60); } }

    protected override IEnumerator process(BehaviourTreeAgent agent)
    {
        yield return null;
        GameObject interact = agent.gameObjectParameters[objectToInteract];
        BehaviourTreeNodeState state = stateForAgent(agent);
        interact.GetComponent<Interactable>().interact();
        state.actualCondition = processCondition.Sucess;
    }

}
