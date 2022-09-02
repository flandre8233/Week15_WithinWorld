using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSpeedChanger : MonoBehaviour
{
    [SerializeField] float Min;
    [SerializeField] float Max;

    [SerializeField] CameraPolarRotator cameraPolar;

    public void Change(float time)
    {
        cameraPolar.FollowSpeed = Mathf.Lerp(Min, Max, time);
    }
}
