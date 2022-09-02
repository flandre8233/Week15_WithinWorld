using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyDiveDelay : MonoBehaviour
{
    [SerializeField] ZoomCardController zoomCardController;
    public int DelayDiveFloor;

    private void OnEnable()
    {
        DelayDiveFloor = 999999;
    }

    private void OnDisable()
    {
        DelayDiveFloor = zoomCardController.OrlFloor;
    }
}
