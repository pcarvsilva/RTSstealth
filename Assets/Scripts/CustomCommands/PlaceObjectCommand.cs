using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Command/PlaceObject")]
public class PlaceObjectCommand : MoveCommand
{
    public string object_tag;

    public override void OnClick(BehaviorExecutor agent, RaycastHit hit)
    {
        base.OnClick(agent, hit);
        FollowTarget(agent, hit);

        agent.blackboard.SetBehaviorParam("toInsert", agent.gameObject.FindChildWithTag(object_tag));
    }
}


public static class GameObjectExtensions
{
    public static GameObject FindChildWithTag(this GameObject gameObject, string tag)
    {
        foreach (Transform child in gameObject.transform)
        {
            if (child.gameObject.tag == tag)
                return child.gameObject;
        }

        foreach (Transform child in gameObject.transform)
        {
            GameObject found = FindChildWithTag(child.gameObject, tag);
            if (found != null)
                return found;
        }

        return null;
    }
}