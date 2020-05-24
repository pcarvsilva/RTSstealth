using Pada1.BBCore.Framework;
using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine.UI;
using UnityEngine;

namespace BBUnity.Actions
{

    [Action("Skills/InsertObject")]
    [Help("Inserts and object in character place")]
    public class InsertObject : GOAction
    {

        [InParam("game object")]
        [Help("The object to insert")]
        public GameObject toInsert;

        public override void OnStart()
        {

        }
        /// <summary>Method of Update of SetBool.</summary>
        /// <remarks>Complete the task.</remarks>
        public override TaskStatus OnUpdate()
        {
            Quaternion quaternion = toInsert.transform.localRotation;
            toInsert.transform.SetParent(null);
            toInsert.SetActive(true);
            toInsert.transform.rotation = quaternion;
            return TaskStatus.COMPLETED;
        }
    }
}