using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Noise : MonoBehaviour
{
    public float noiseTime;
    private void OnEnable()
    {
        Invoke("disable",noiseTime);
    }

    private void disable()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Enemy") return;

        BehaviorExecutor behaviorExecutor = other.GetComponent<BehaviorExecutor>();

        if (behaviorExecutor == null) return;

        behaviorExecutor.SetBehaviorParam("HeardNoise", true);
        behaviorExecutor.SetBehaviorParam("NoisePlace", transform.position);

    }
}
