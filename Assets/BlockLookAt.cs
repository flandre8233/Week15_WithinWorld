using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLookAt : MonoBehaviour
{
    [SerializeField] float Damping;

    private void OnEnable()
    {
        transform.rotation = LookAt();
    }

    Quaternion LookAt()
    {
        Vector3 MyPos = transform.position;
        MyPos = new Vector3(MyPos.x, 0, MyPos.z);
        Vector3 lookPos = new Vector3() - transform.position;
        return Quaternion.LookRotation(lookPos);
    }
}
