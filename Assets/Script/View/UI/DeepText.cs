using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeepText : CommonUIText
{
    [SerializeField]
    ZoomCardController ZoomCardController;

    [SerializeField]
    public override void UpdateText()
    {
        text.text = "Deep : " + ZoomCardController.GetFloor().ToString();
    }
}
