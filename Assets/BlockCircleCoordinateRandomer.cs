using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCircleCoordinateRandomer : MonoBehaviour
{
    [SerializeField] CircleCoordinate coordinate;

    private void OnEnable()
    {
        RandomAngle();
    }
    public void RandomAngle()
    {
        coordinate.Radius = 25f;
        coordinate.PolarDegrees = AngleDifficulty.instance.GetRandomAngle();
    }

}
