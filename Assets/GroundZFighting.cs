using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundZFighting : MonoBehaviour
{
    [SerializeField] Transform Ground;
    public void OnFloorChangedToFirst()
    {
        ReSetHeight();
    }

    public void OnFloorChanged()
    {
        DownOne();
    }

    void ReSetHeight()
    {
        Ground.localPosition = new Vector3(0, 0.0016f, 0);
    }

    void DownOne()
    {
        Ground.localPosition = new Vector3(0, Ground.localPosition.y - 0.0001f, 0);
    }
}
