using Pada1.BBCore.Framework;
using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine.UI;
using UnityEngine;

namespace BBUnity.Actions
{

    [Action("Skills/KnifeAction")]
    [Help("Deals damage with a knife")]
    public class KnifeAction : GOAction
    {

        [InParam("game object")]
        [Help("The object to insert")]
        public GameObject toDestroy;

        public override void OnStart()
        {

        }


        public override TaskStatus OnUpdate()
        {
            toDestroy.GetComponent<Damageable>().TakeDamage(DamageType.Knife, 1);
            return TaskStatus.COMPLETED;
        }
    }
}