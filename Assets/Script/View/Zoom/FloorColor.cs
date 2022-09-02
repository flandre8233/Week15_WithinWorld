using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorColor : MonoBehaviour
{
    [SerializeField] MeshRenderer[] AllRenderer;


    public void OnFloorChangedToFirst()
    {
        ChangeColor(GetNewColor());
    }

    public Color GetNewColor()
    {
        return Realm.instance.GetRealmColor();
    }

    void ChangeColor(Color NewColor)
    {
        foreach (var item in AllRenderer)
        {
            item.material.color = NewColor;
        }
    }
}
