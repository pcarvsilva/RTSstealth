using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public Bounds bounds;
    public float movemmentSpeed;

    private GameObject attached;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AttachToGameObject(GameObject follow)
    {
        attached = follow;
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(transform.position, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        CheckAttaching();
        CheckMovemment();
    }

    private void CheckMovemment()
    {
        bool moved = false;
        Vector3 movemment = Vector3.zero;
        Vector3 right = Camera.main.transform.right;
        Vector3 forward = Camera.main.transform.forward;
       
        if (Input.GetAxis("Horizontal") != 0.0f)
        {
            movemment += Input.GetAxis("Horizontal") * right;
            moved = true;
        }
        if (Input.GetAxis("Vertical") != 0.0f)
        {
            movemment += Input.GetAxis("Vertical") * forward;
            moved = true;
        }
        if (moved)
        {
            movemment.y = 0;
            Vector3 newPosition = transform.position + movemment * movemmentSpeed;
            transform.position = bounds.ClosestPoint(newPosition);
            attached = null;
        }
    }

    private void CheckAttaching()
    {
        if (attached != null)
        {
            Vector3 newPosition = attached.transform.position;
            transform.position = bounds.ClosestPoint(newPosition);
        }
    }
}
