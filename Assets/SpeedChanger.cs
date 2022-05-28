using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChanger : MonoBehaviour
{
    [SerializeField] float Min;
    [SerializeField] float Max;
    [SerializeField] SimpleForward simpleForward;


    public void Change(float time)
    {
        float NewFoV = Mathf.Lerp(Min, Max, time);
        simpleForward.Speed = NewFoV;
    }
}
