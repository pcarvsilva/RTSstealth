using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToolbarElement : MonoBehaviour {

    public LayerMask layer;


    public ToolbarEvent ClickFunction = new ToolbarEvent();

    public virtual void AssignToToolbar(GameObject toolbar)
    {
        ToolbarCursor cursor = toolbar.GetComponent<ToolbarCursor>();
        if(cursor.OperationOnClick != null)
            cursor.OperationOnClick.RemoveAllListeners();
        cursor.OperationOnClick = ClickFunction;
        cursor.layer = layer;
    }

}