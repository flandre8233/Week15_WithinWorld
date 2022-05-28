using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Coordinate : MonoBehaviour
{
    public Transform TargetTrans;

    public float Radius;
    public float PolarDegrees;

    private void Update()
    {
        transform.position = UpdatePosition();
    }

    public abstract Vector3 UpdatePosition();

}
