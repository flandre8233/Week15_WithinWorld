using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLookAt : MonoBehaviour
{
    [SerializeField] Vector3 LookAtPosition;
    [SerializeField] float Damping;

    Quaternion WantedRotation;

    // Update is called once per frame
    void Update()
    {
        WantedRotation = Quaternion.LookRotation(GetRelativePos(), Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, WantedRotation, Time.deltaTime * Damping);
    }


    public Vector3 GetRelativePos()
    {
        return  LookAtPosition - transform.position;
    }
}
