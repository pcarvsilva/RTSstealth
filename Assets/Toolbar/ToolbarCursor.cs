using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.AI;

public class ToolbarCursor : MonoBehaviour {


    public ToolbarEvent OperationOnClick;
    public LayerMask layer;

    public Coroutine currentRoutine;

    private void Start()
    {
        GetComponentInChildren<ToolbarElement>().AssignToToolbar(gameObject);
    }


    void Update () {
		if(Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            resolveCallbacks();
        }
	}

    void resolveCallbacks()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit,layer))
        {
            if(currentRoutine != null)
                StopCoroutine(currentRoutine);
            OperationOnClick.Invoke(hit);
        }
    }
}
