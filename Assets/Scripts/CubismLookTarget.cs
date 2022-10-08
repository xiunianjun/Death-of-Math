using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Framework.LookAt;

public class CubismLookTarget : MonoBehaviour,ICubismLookTarget
{

    private Vector3 vector = new Vector3(0, 1, 0);
    public Vector3 GetPosition()
    {
        if (!Input.GetMouseButton(0))
        {
            return vector;
        }
        var targetPosition = Input.mousePosition;
        targetPosition = (Camera.main.ScreenToViewportPoint(targetPosition) * 2)-Vector3.one;
        return targetPosition;
    }

    public bool IsActive()
    {
        return true;
    }

    // Start is called before the first frame update
    
}
