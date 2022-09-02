using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deep : MonoBehaviour
{
    public int Get()
    {
        return Mathf.RoundToInt(transform.position.z);
    }
}
