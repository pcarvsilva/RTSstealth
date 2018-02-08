using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(EventTrigger))]
public class ToolbarTemporaryElement : ToolbarElement {

    ToolbarEvent priorEvent;
    LayerMask priorLayer;

    public override void AssignToToolbar(GameObject toolbar)
    {
        ToolbarCursor cursor = toolbar.GetComponent<ToolbarCursor>();
        priorEvent = cursor.OperationOnClick;
        cursor.OperationOnClick = ClickFunction;
        priorLayer = cursor.layer;
        cursor.layer = layer;
    }

    public void removeTemporaryEvent(GameObject toolbar)
    {
        ToolbarCursor cursor = toolbar.GetComponent<ToolbarCursor>();
        cursor.OperationOnClick = priorEvent;
        cursor.layer = priorLayer;
    }

    void OnMouseEnter()
    {
        GetComponent<EventTrigger>().OnPointerEnter(null);
    }

    private void OnMouseExit()
    {
        GetComponent<EventTrigger>().OnPointerExit(null);
    }

}
