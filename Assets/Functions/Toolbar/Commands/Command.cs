using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public abstract class Command : MonoBehaviour {

    public UnityEvent OnSubscribe;
    public UnityEvent OnUnsubscribe;
    public LayerMask layerMask;

    public  abstract void OnClick(GameObject agent,RaycastHit hit);


    public void Subscribe()
    {
        if (CommandController.commands == null)
            CommandController.commands = new List<Command>();
        CommandController.commands.Insert(0, this);
        OnSubscribe.Invoke();
    }

    public void Unsubscribe()
    {
        CommandController.commands.Remove(this);
        OnUnsubscribe.Invoke();
    }

}
