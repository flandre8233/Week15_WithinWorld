using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneViewShake : MonoBehaviour
{
    [SerializeField] Shake PlaneSelfShake;

    // Update is called once per frame
    void Update()
    {
        PlaneSelfShake.StartShake(1, 0.01f);
    }
}
