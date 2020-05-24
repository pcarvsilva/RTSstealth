using Pada1.BBCore.Framework;
using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine.UI;
using UnityEngine;

namespace BBUnity.Actions
{

    [Action("Skills/InteractAction")]
    [Help("Inserts and object in character place")]
    public class InteractAction : GOAction
    {

        [InParam("game object")]
        [Help("The object to insert")]
        public GameObject toInteract;

        public override void OnStart()
        {

        }
        /// <summary>Method of Update of SetBool.</summary>
        /// <remarks>Complete the task.</remarks>
        public override TaskStatus OnUpdate()
        {
            toInteract.GetComponent<Interactable>().interact();
            return TaskStatus.COMPLETED;
        }
    }
}