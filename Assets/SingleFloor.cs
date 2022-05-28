using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleFloor : MonoBehaviour
{
    [SerializeField] BlockSpawner blockSpawner;

    [SerializeField] FloorColor color;
    [SerializeField] GroundZFighting ZFighting;
    [SerializeField] FloorScaler scaler;
    public void OnFloorChangedToFirst()
    {
        blockSpawner.OnFloorChangedToFirst();
        color.OnFloorChangedToFirst();
        ZFighting.OnFloorChangedToFirst();
    }

    public void OnFloorChanged()
    {
        ZFighting.OnFloorChanged();
    }

    public void OnFloorScaleChanged(float NewScale)
    {
        scaler.OnFloorScaleChanged(NewScale);
    }

    void randomAngle()
    {
        float TargetAngle = 180;
        // TargetAngle = Random.Range(TargetAngle - 360f, TargetAngle + 360f);
        transform.localEulerAngles = new Vector3(0, TargetAngle, 0);
    }
}
