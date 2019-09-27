using Pada1.BBCore.Framework;
using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine.UI;
using UnityEngine;

namespace BBUnity.Actions
{

    [Action("Skills/PlantTrap")]
    [Help("Plants a Trap")]
    public class PlantTrap : GOAction
    {

        [InParam("game object")]
        [Help("The trap object")]
        public GameObject trap;

        public override void OnStart()
        {

        }
        /// <summary>Method of Update of SetBool.</summary>
        /// <remarks>Complete the task.</remarks>
        public override TaskStatus OnUpdate()
        {
            Quaternion quaternion = trap.transform.localRotation;
            trap.transform.SetParent(null);
            trap.SetActive(true);
            trap.transform.rotation = quaternion;
            return TaskStatus.COMPLETED;
        }
    }
}