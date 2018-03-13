using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubscribeCommandOnMouseOver : MonoBehaviour {

    public Command command;

    void OnMouseOver()
    {
        command.Subscribe();
    }

    void OnMouseExit()
    {
        command.Unsubscribe();
    }
}
