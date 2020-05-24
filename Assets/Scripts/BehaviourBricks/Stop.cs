using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine;

namespace BBUnity.Actions
{
    /// <summary>
    /// It is an action to move towards the given goal using a NavMeshAgent.
    /// </summary>
    [Action("Navigation/Stop")]
    [Help("Put move target on agent's current place")]
    public class Stop : GOAction
    {
        public override TaskStatus OnUpdate()
        {
            GameObject target = gameObject.GetComponent<NavMeshAnimationIntegration>().targetPosition;
            target.transform.SetParent(null);
            target.transform.position = gameObject.transform.position;
            return TaskStatus.COMPLETED;
        }

    }
}
