using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultDeepText : CommonUIText
{
    [SerializeField]
    ZoomCardController ZoomCardController;

    private void OnEnable()
    {
        UpdateText();
    }

    [SerializeField]
    public override void UpdateText()
    {
        text.text = "Dive Deep : " + ZoomCardController.GetFloor().ToString();
    }
}
