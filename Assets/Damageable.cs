using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public bool diesOnAnyDamage;

    public IntUnityEvent DefaultDamage = new IntUnityEvent();
    public IntUnityEvent KnifeDamage   = new IntUnityEvent();
    public IntUnityEvent ShootDamage   = new IntUnityEvent();
    public IntUnityEvent TrapDamage    = new IntUnityEvent();

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
        if(diesOnAnyDamage)
        {
            DefaultDamage.AddListener( delegate { Die(); });
            KnifeDamage.AddListener(delegate { Die(); });
            ShootDamage.AddListener(delegate { Die(); });
            TrapDamage.AddListener(delegate { Die(); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Die()
    {
        animator.SetTrigger("Die");
        Destroy(this);
        Destroy(GetComponent<BehaviorExecutor>());
        Destroy(GetComponent<CommandSubscriber>());
    }

    public void TakeDamage(DamageType type,int damage)
    {
        switch (type)
        {
            case DamageType.Default:
                DefaultDamage.Invoke(damage);
                break;
            case DamageType.Knife:
                KnifeDamage.Invoke(damage);
                break;
            case DamageType.Shoot:
                ShootDamage.Invoke(damage);
                break;
            case DamageType.Trap:
                TrapDamage.Invoke(damage);
                break;
        }
    }
}

public enum DamageType
{
    Default,
    Knife,
    Shoot,
    Trap
}
