using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Command/Select")]
public class SelectionCommand : Command
{
    public override void OnClick(GameObject agent, RaycastHit hit)
    {
        CommandController.instance.selectAgent(hit.collider.gameObject);
    }
}
