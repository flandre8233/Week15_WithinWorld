using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Realm : SingletonMonoBehavior<Realm>
{
    [SerializeField] GameObject PlaceAni;
    int CurrentFloor = 0;

    int GetRealmIndex()
    {
        int BigFloor = (int)Mathf.Repeat(GetBigFloor(), 10);
        if (CurrentFloor != BigFloor)
        {
            CurrentFloor = BigFloor;
            Invoke("ShowPlaceAni", 3f);
        }
        return BigFloor;
    }

    public int GetBigFloor()
    {
        int Floor = ZoomCardController.instance.GetFloor();
        return Mathf.FloorToInt((float)Floor / 32f);
    }

    void ShowPlaceAni()
    {
        ResourcesSpawner.Spawn("UpUp", 7f);
        PlaceAni.SetActive(false);
        PlaceAni.SetActive(true);
    }

    public string GetRealmName()
    {
        switch (GetRealmIndex())
        {
            case 1:
                return "Scarlett's Realm";
            case 2:
                return "The Storm Lake";
            case 3:
                return "The Golden Isles";
            case 4:
                return "The Echo Cave";
            case 5:
                return "Howling Fjord";
            case 6:
                return "Endless Sea";
            case 7:
                return "Merciless Space";
            case 8:
                return "Great Old Ones Abyss";
            case 9:
                return "The Great Void";
            default:
                return "Origin Point";
        }
    }

    public Color GetRealmColor()
    {
        switch (GetRealmIndex())
        {
            case 1:
                return Color.red;
            case 2:
                return new Color(1, 0.64f, 0);
            case 3:
                return Color.yellow;
            case 4:
                return Color.green;
            case 5:
                return Color.cyan;
            case 6:
                return Color.blue;
            case 7:
                return new Color(0.5f, 0, 0.5f);
            case 8:
                return Color.gray;
            case 9:
                return Color.black;
            default:
                return new Color(0.7f, 0.7f, 0.7f);
        }
    }

}
