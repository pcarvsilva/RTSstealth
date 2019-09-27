using Pada1.BBCore.Framework;
using Pada1.BBCore.Tasks;
using Pada1.BBCore;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace BBUnity.Actions
{

    [Action("Skills/BlowWhistle")]
    [Help("Blows the whistle")]
    public class BlowWhistle : GOAction
    {

        public override void OnStart()
        {

        }
        /// <summary>Method of Update of SetBool.</summary>
        /// <remarks>Complete the task.</remarks>
        public override TaskStatus OnUpdate()
        {
            List<GameObject> enemies = GameObject.FindGameObjectsWithTag("Enemy").ToList();
            foreach (GameObject enemy in enemies)
            {
                BehaviorExecutor behaviorExecutor = enemy.GetComponent<BehaviorExecutor>();
                behaviorExecutor.SetBehaviorParam("HeardNoise", true);
                behaviorExecutor.SetBehaviorParam("NoisePlace", gameObject.transform.position);
            }
            return TaskStatus.COMPLETED;
        }
    }
}

