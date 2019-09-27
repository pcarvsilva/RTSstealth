using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourParameterSetter : MonoBehaviour
{
    public string parameter;
    public BehaviorExecutor behaviorExecutor;

    public void SetBool(bool value)
    {
        Debug.Log(parameter + " set to " + value);
        behaviorExecutor.blackboard.SetBehaviorParam(parameter, value);
    }
}
