using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AITools;


public class PatrolList : MonoBehaviour {

    public List<Vector3> waypoints;
    public string listToInsert;

	// Use this for initialization
	void Start () {
        List<object> points = new List<object>();
        foreach (Vector3 t in waypoints) { points.Add(t); };
        GetComponent<BehaviourTreeAgent>().listParameters[listToInsert] = points;
	}

    [Toolbar]
    public void AddToList(RaycastHit hit)
    {
        waypoints.Add(hit.point);
    }

    private void OnDrawGizmosSelected()
    {
        for (int i = 0; i < waypoints.Count; i++)
        {
            Gizmos.DrawIcon(waypoints[i], (i + 1).ToString(),false);
        }
    }

}
