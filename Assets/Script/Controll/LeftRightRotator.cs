using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightRotator : MonoBehaviour
{
    [SerializeField] ViewZRotator ZRotator;
    [SerializeField] PlanePolarRotator  PolarRotator;


    [SerializeField] float AxisVal;


    void Update()
    {
        AxisVal = Input.GetAxis("LeftRight");
        ZRotator.Change(AxisVal);
        PolarRotator.Change(AxisVal);
    }
}
