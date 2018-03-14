using UnityEditor;
using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(PatrolList))]
public class PatrolListEditor : Editor
{
    void OnSceneGUI()
    {
        HandleUtility.AddDefaultControl(GUIUtility.GetControlID(FocusType.Passive));
        if (Event.current.type == EventType.MouseDown)
        {
            Ray ray = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                PatrolList list = (PatrolList)target;
                list.waypoints.Add(hit.point);
            }
        }

        PatrolList patrol = (PatrolList)target;
        for (int i = 0; i < patrol.waypoints.Count; i++)
        {
            Handles.Label(patrol.waypoints[i], (i+1).ToString()); ;
        }
    }
}
