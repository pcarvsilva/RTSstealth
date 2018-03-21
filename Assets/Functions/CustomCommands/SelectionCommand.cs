using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionCommand : ICommand
{
    public void OnClick(GameObject agent, RaycastHit hit)
    {
        CommandController.instance.selectAgent(hit.collider.gameObject);
    }
}
