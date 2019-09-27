using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Noise : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.tag != "Enemy") return;
            BehaviorExecutor behaviorExecutor = other.GetComponent<BehaviorExecutor>();
            behaviorExecutor.SetBehaviorParam("HeardNoise", true);
            behaviorExecutor.SetBehaviorParam("NoisePlace", transform.position);

    }
}
