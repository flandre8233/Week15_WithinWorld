using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeTrailVelocityChanger : MonoBehaviour
{
    [SerializeField] float Min;
    [SerializeField] float Max;

    [SerializeField] float Current;

    [SerializeField] PlaneLookAt PlaneLookAt;
    [SerializeField] FakeTrail FakeTrail;

    private void Update()
    {
        FakeTrail.velocity = PlaneLookAt.GetRelativePos() * Current;
    }

    public void Change(float time)
    {
        Current = Mathf.Lerp(Min, Max, time);
    }
}
