using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlaceText : CommonUIText
{
    private void OnEnable()
    {
        UpdateText();
    }
    public override void UpdateText()
    {
        text.text = Realm.instance.GetRealmName();
    }
}
