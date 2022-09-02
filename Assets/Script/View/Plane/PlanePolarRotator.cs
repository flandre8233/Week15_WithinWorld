using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePolarRotator : MonoBehaviour
{
    [SerializeField] float MaxSildeGap;
    [SerializeField] SphericalCoordinate spherical;
    public void Change(float WantedZ)
    {
        WantedZ = WantedZ / 1000;
        WantedZ = Mathf.Clamp(WantedZ, -MaxSildeGap, MaxSildeGap);
        WantedZ += spherical.PolarDegrees;
        spherical.PolarDegrees = Mathf.Lerp(spherical.PolarDegrees, WantedZ, Time.deltaTime * 3);
    }
}
