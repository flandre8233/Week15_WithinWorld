using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoVChanger : MonoBehaviour
{
    [SerializeField] float Min;
    [SerializeField] float Max;
    [SerializeField] Camera CurrentCamera;


    public void Change(float time)
    {
        float NewFoV = Mathf.Lerp(Min, Max, time);
        CurrentCamera.fieldOfView = NewFoV;
    }
}
