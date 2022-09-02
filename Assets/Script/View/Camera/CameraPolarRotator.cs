using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPolarRotator : MonoBehaviour
{
    [SerializeField] SphericalCoordinate Spherical;
    [SerializeField] SphericalCoordinate PlaneSpherical;

    public float FollowSpeed;

    void Update()
    {
        Spherical.PolarDegrees = Mathf.Lerp(Spherical.PolarDegrees, PlaneSpherical.PolarDegrees, Time.deltaTime * 3f * FollowSpeed);
    }
}
