using Pada1.BBCore.Framework;
using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine.UI;
using UnityEngine;

namespace BBUnity.Actions
{

    [Action("Skills/RetriveObject")]
    [Help("Retrive object")]
    public class RetriveObject : GOAction
    {

        [InParam("game object")]
        [Help("The objectToRetrieve")]
        public GameObject toRetrive;

        public override void OnStart()
        {

        }
        /// <summary>Method of Update of SetBool.</summary>
        /// <remarks>Complete the task.</remarks>
        public override TaskStatus OnUpdate()
        {
            toRetrive.transform.SetParent(gameObject.transform);
            toRetrive.SetActive(false);
            return TaskStatus.COMPLETED;
        }
    }
}