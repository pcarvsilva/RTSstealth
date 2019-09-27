using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MouseFollower : MonoBehaviour
{
    public Vector3 offset;
    private bool isRendering;

    public UnityEvent onStartRendering;
    public UnityEvent onStopRendering;

    public LayerMask mask;

    // Start is called before the first frame update
    void OnEnable()
    {
        isRendering = false;
        onStopRendering.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        NavMeshHit navHit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity)
            && LayerMaskExtension.CompareToLayer(hit.collider.gameObject.layer, LayerMask.GetMask("Ground"))
            && NavMesh.SamplePosition(hit.point ,out navHit, 0.5f,NavMesh.AllAreas)
            && EventSystem.current.IsPointerOverGameObject() == false)
        {
            transform.position = hit.point + offset;
            if (isRendering == false)
            {
                onStartRendering.Invoke();
                isRendering = true;
            }
        }
        else
        {
            if (isRendering)
            {
                onStopRendering.Invoke();
                isRendering = false;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }
    }
}
