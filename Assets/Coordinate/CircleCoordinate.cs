using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCoordinate : Coordinate
{

    Vector3 GetTargetPosition()
    {
        if (TargetTrans)
        {
            return TargetTrans.position;
        }
        return new Vector3();
    }

    private void Update()
    {
        transform.localPosition = ToCircle(GetTargetPosition(), Radius, PolarDegrees);
    }

    public override Vector3 UpdatePosition()
    {
        return ToCircle(GetTargetPosition(), Radius, PolarDegrees);
    }

    public Vector3 ToCircle(Vector3 CentrePoint, float radius, float polarDegrees)
    {
        float polarRadians = polarDegrees * Mathf.Deg2Rad;
        float x = Mathf.Cos(polarRadians);
        float y = Mathf.Sin(polarRadians);
        Vector2 pos = new Vector3(x, y);
        pos *= radius;
        return new Vector3(pos.x + CentrePoint.x, transform.position.y, pos.y + CentrePoint.z);
    }
}
