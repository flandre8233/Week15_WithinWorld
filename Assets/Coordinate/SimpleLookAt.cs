using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLookAt : MonoBehaviour
{
    [SerializeField] Transform TargetLookAt;
    [SerializeField] float Damping;

    void Update()
    {
        transform.rotation = LookAt();
    }
    Quaternion LookAt()
    {
        Vector3 lookPos = TargetLookAt.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        return Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
    }
}
