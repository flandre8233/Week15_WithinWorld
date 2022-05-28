using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeTrailWidthChanger : MonoBehaviour
{
    [SerializeField] float Min;
    [SerializeField] float Max;

    [SerializeField] float Current;

    [SerializeField] LineRenderer lineRenderer;

    public void Change(float time)
    {
        lineRenderer.startWidth = Mathf.Lerp(Min, Max, time);
    }
}
