using Pada1.BBCore.Framework;
using Pada1.BBCore;
using UnityEngine;
using UnityEngine.AI;

namespace BBUnity.Conditions
{
    /// <summary>
    /// It is a basic condition to check if Booleans have the same value.
    /// </summary>
    [Condition("Basic/CheckIsShootingRange")]
    [Help("Checks if target is close enough to shoot")]
    public class CheckIsShootingRange : GOCondition
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
            if (target == null) return false;

            Vector3 direction = target.transform.position - gameObject.transform.position;
            Ray ray = new Ray(gameObject.transform.position,direction);
            RaycastHit hit;

            return Physics.Raycast(ray, out hit) && 
                   IsWithingProperDistance(hit) && 
                   HitRightObject(hit);
        }

        public bool HitRightObject(RaycastHit hit)
        {
            return hit.collider.gameObject == target;
        }

        public bool IsWithingProperDistance(RaycastHit hit)
        {
            return hit.distance <= distance;
        }
    }
}

