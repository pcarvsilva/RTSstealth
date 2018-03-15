using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandController : MonoBehaviour {

    public static List<Command> commands;
    public GameObject agent;

    public static void clearAllCommands()
    {
        commands = new List<Command>();
    }

    void Update()
    {
        if (Input.GetAxis("Fire1") != 0.0f)
        {
            RaycastHit hit;
            Command command = null;
            if (commands != null && commands.Count != 0)
            {
               command = commands[0];
                commands.RemoveAt(0);
            }
            else
            {
                command = agent.GetComponent<SubscribeCommandOnSelect>().command; 
            }
            LayerMask layerMask = command.layerMask;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100,layerMask))
            {
                if (hit.collider != null)
                {
                    command.OnClick(agent, hit);
                }
            }
        }   
    }

}
