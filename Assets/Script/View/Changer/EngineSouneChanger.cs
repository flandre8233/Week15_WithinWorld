using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSouneChanger : MonoBehaviour
{
    [SerializeField] float Min;
    [SerializeField] float Max;

    [SerializeField] AudioSource Audio;

    public void Change(float time)
    {
        Audio.pitch = Mathf.Lerp(Min, Max, time);
    }

    public void Stop()
    {
        Audio.volume = 0;
    }
}
