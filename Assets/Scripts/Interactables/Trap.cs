using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Trap : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Damageable>().TakeDamage(DamageType.Trap, 1);
    }

}
