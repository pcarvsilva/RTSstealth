using Pada1.BBCore.Framework;
using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine.UI;
using UnityEngine;

namespace BBUnity.Actions
{

    [Action("Skills/ShootAction")]
    [Help("Deals damage by shooting")]
    public class ShootAction : GOAction
    {

        [InParam("game object")]
        [Help("The object to insert")]
        public GameObject toDestroy;

        public override void OnStart()
        {

        }

        public override TaskStatus OnUpdate()
        {
            toDestroy.GetComponent<Damageable>().TakeDamage(DamageType.Shoot,1);
            return TaskStatus.COMPLETED;
        }
    }
}