using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewZRotator : MonoBehaviour
{
    [SerializeField] float Min;
    [SerializeField] float Max;

    public void Change(float WantedZ)
    {
        WantedZ = WantedZ / 1000;
        WantedZ = Mathf.Clamp(WantedZ, -67.5f, 67.5f);
        Quaternion WantedRotation = Quaternion.Euler(0, 0, WantedZ);
        transform.localRotation = Quaternion.Lerp(transform.localRotation , WantedRotation , Time.deltaTime * 7.5f);
    }
}
