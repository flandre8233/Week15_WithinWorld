using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphericalCoordinate : Coordinate
{
    public float ElevationDrgrees;

    private void Update()
    {
        transform.localPosition = ToSpherical(TargetTrans.position, Radius, PolarDegrees, ElevationDrgrees);
    }

    public override Vector3 UpdatePosition()
    {
        return ToSpherical(TargetTrans.position, Radius, PolarDegrees, ElevationDrgrees);
    }

    Vector3 ToSpherical(Vector3 CentrePoint, float radius, float polarDegrees, float elevationDegrees)
    {
        float polarRadians = (polarDegrees) * Mathf.Deg2Rad;
        float elevationRadians = elevationDegrees * Mathf.Deg2Rad;
        Vector3 OutPut = new Vector3();
        float a = radius * Mathf.Cos(elevationRadians);
        OutPut.x = a * Mathf.Cos(polarRadians);
        OutPut.y = radius * Mathf.Sin(elevationRadians);
        OutPut.z = a * Mathf.Sin(polarRadians);
        OutPut += CentrePoint;
        return OutPut;
    }



}
