using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartListener : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            StatusControll.ToNewStatus(new GameStatus());
        }
    }
}
