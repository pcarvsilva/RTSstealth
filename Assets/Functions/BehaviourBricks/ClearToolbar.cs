using Pada1.BBCore.Framework;
using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine.UI;
using UnityEngine;

namespace BBUnity.Actions
{

    [Action("Skills/ClearToolbar")]
    [Help("Clear The toolbar")]
    public class ClearToolbar : GOAction
    {

        public override void OnStart()
        {

        }

        public static void Clear(GameObject clearObject)
        {
            clearObject.GetComponentInChildren<ToggleGroup>().SetAllTogglesOff();
            clearObject.GetComponent<BehaviorExecutor>().blackboard.SetBehaviorParam("Skill", 0);
        }
        /// <summary>Method of Update of SetBool.</summary>
        /// <remarks>Complete the task.</remarks>
        public override TaskStatus OnUpdate()
        {
            Clear(gameObject);
            return TaskStatus.COMPLETED;
        }
    }
}