using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistChanger : MonoBehaviour
{
    [SerializeField] float Min;
    [SerializeField] float Max;
    [SerializeField] ImageEffect_RadialBlur Blur;


    public void Change(float time)
    {
        float NewVal = Mathf.Lerp(Min, Max, time);
        Blur.SampleDist = NewVal;
    }
}
