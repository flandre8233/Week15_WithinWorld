using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScaler : MonoBehaviour
{
    [SerializeField] Transform ObjectsLayer;
    [SerializeField] Transform GroundLayer;

    public void OnFloorScaleChanged(float NewScale)
    {
        ObjectsLayer.localScale = new Vector3(NewScale, NewScale, NewScale);
        GroundLayer.localScale = new Vector3(NewScale, 1, NewScale);
    }
}
