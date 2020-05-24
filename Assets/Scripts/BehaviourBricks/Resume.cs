using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine;

namespace BBUnity.Actions
{
    /// <summary>
    /// It is an action to move towards the given goal using a NavMeshAgent.
    /// </summary>
    [Action("Conditions/Resume")]
    [Help("Resume the interruption")]
    public class Resume : GOAction
    {



        public override TaskStatus OnUpdate()
        {
                gameObject.GetComponent<BehaviorExecutor>().blackboard.SetBehaviorParam("interrupt", false);
                return TaskStatus.COMPLETED;
        }

    }
}
