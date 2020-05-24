using Pada1.BBCore.Framework;
using Pada1.BBCore;
using UnityEngine;
using UnityEngine.AI;

namespace BBUnity.Conditions
{
    /// <summary>
    /// It is a basic condition to check if Booleans have the same value.
    /// </summary>
    [Condition("Basic/CheckIsClose")]
    [Help("Checks if target is close enough")]
    public class CheckIsClose : GOCondition
    {

        ///<value>Distance to check.</value>
        [InParam("Distance")]
        [Help("Distance to stop")]
        public float distance;

        [InParam("Target")]
        [Help("Target Destination")]
        public GameObject target;

        /// <summary>
        /// Checks whether two booleans have the same value.
        /// </summary>
        /// <returns>the value of compare first boolean with the second boolean.</returns>
		public override bool Check()
        {
            NavMeshAgent navAgent = gameObject.GetComponent<NavMeshAgent>();
            if (target == null) return false;

            return !navAgent.pathPending && 
                   navAgent.remainingDistance <= distance &&
                   Vector3.Distance(gameObject.transform.position,target.transform.position) <= distance;
        }
    }
}