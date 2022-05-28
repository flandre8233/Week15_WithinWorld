using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class ZoomCardController : SingletonMonoBehavior<ZoomCardController>
{

    /** Collection of zooming cards to be displayed. */
    public GameObject[] Cards;
    GameObject[] OrlCards;
    public int OrlFloor;

    /** Distance player travels between cards. */
    public float DistanceBetweenCards = 10;

    public DeepText DeepViewText;
    public ReadyDiveDelay ReadyDiveDelay;

    public int GetFloor()
    {
        return Mathf.Clamp(OrlFloor - ReadyDiveDelay.DelayDiveFloor, 0, int.MaxValue);
    }

    private void Start()
    {
        List<GameObject> OrlCardsList = new List<GameObject>();
        OrlCardsList.AddRange(Cards.ToList());
        OrlCards = OrlCardsList.ToArray();
    }

    void LateUpdate()
    {

        // Locate player in world space.
        Vector3 p = transform.position;
        if (Mathf.FloorToInt(p.z / DistanceBetweenCards) != OrlFloor)
        {
            OnFloorUpdate();
        }

        // Determine current travel fraction along the z-axis.
        // Varies from [0..1] as the player moves between successive cards.
        float t = (p.z % DistanceBetweenCards) / DistanceBetweenCards;
        if (t < 0)
        {
            t += 1;
        }

        // Bias the fraction to smooth out view jerkiness.
        // Not exactly sure why this helps, but it does.. :)
        t = Mathf.Pow(t, 1.3f);

        // Set up each card for current travel fraction.
        int n = Cards.Length;
        for (int i = 0; i < n; i++)
            UpdateCard(Cards[i], i, n, t);

        // Adjust alpha of the smallest card.
        // The smallest card fades in as you get closer to it.
        // Cards[0].GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 1, t);
    }

    public void OnFloorUpdate()
    {
        DeepViewText.UpdateText();

        Vector3 p = transform.position;
        OrlFloor = Mathf.FloorToInt(p.z / DistanceBetweenCards);
        Cards = ShiftRightCyclic(OrlCards.ToList(), OrlFloor).ToArray();

        Cards[(Cards.Length / 2) - 1].GetComponent<SingleFloor>().OnFloorChangedToFirst();
        foreach (var item in Cards)
        {
            item.GetComponent<SingleFloor>().OnFloorChanged();
        }
    }

    private void UpdateCard(GameObject card, int i, int n, float t)
    {
        float divisor = Mathf.Pow(3, n - 1);
        float minZoom = Mathf.Pow(3, i) / divisor;
        float maxZoom = Mathf.Pow(3, i + 1) / divisor;
        float s = Mathf.Lerp(minZoom, maxZoom, t);
        card.GetComponent<SingleFloor>().OnFloorScaleChanged(s);
        // card.transform.localPosition = new Vector3(0, 0, i);
    }

    // 頭尾相接的右移
    IEnumerable<T> ShiftRightCyclic<T>(IEnumerable<T> s, int shifts)
    {
        int cnt = s.Count();
        shifts %= cnt;
        var last = s.Where((x, idx) => cnt - idx <= shifts);
        return last.Concat(s).Take(cnt);
    }
    // 頭尾相接的左移
    IEnumerable<T> ShiftLeftCyclic<T>(IEnumerable<T> s, int shifts)
    {
        int cnt = s.Count();
        shifts %= cnt;
        var first = s.Take(shifts);
        return s.Skip(shifts).Concat(first);
    }
}