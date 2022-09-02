using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedShakeChanger : MonoBehaviour
{
    [SerializeField] float Min;
    [SerializeField] float Max;
    [SerializeField] Shake shake;


    public void Change(float time)
    {
        float NewVal = Mathf.Lerp(Min, Max, time);
        shake.StartShake(NewVal, NewVal);
    }
}
