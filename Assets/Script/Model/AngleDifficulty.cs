using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class AngleDifficulty : SingletonMonoBehavior<AngleDifficulty>
{
    [SerializeField] SphericalCoordinate PlayerSphericalCoordinate;
    [SerializeField] float DangerZoneRange;

    [SerializeField] AnimationCurve SafeCurve;
    [SerializeField] AnimationCurve DangerCurve;
    [SerializeField] AnimationCurve DeathCurve;

    public float GetRandomAngle()
    {
        float BigFloor = Realm.instance.GetBigFloor();
        int SafeRandomLength = Mathf.RoundToInt(SafeCurve.Evaluate(BigFloor));
        int DangerRandomLength = Mathf.RoundToInt(DangerCurve.Evaluate(BigFloor));
        int DeathRandomLength = Mathf.RoundToInt(DeathCurve.Evaluate(BigFloor));

        List<string> RandomPool = new List<string>();
        RandomPool.AddRange(Enumerable.Repeat("Safe", SafeRandomLength).ToList());
        RandomPool.AddRange(Enumerable.Repeat("Danger", DangerRandomLength).ToList());
        RandomPool.AddRange(Enumerable.Repeat("Death", DeathRandomLength).ToList());

        string RandomResult = RandomPool[Random.Range(0, RandomPool.Count)];
        switch (RandomResult)
        {
            case "Safe":
                return GetSafeAngle();
            case "Danger":
                return GetDangerAngle();
            default:
                return GetDeathAngle();
        }
    }

    float GetSafeAngle()
    {
        float PlayerDegrees = PlayerSphericalCoordinate.PolarDegrees;
        float MinDegrees = PlayerDegrees + DangerZoneRange;
        float MaxDegrees = MinDegrees + 360f - (DangerZoneRange * 2);
        float RandomDegrees = Random.Range(MinDegrees, MaxDegrees);
        return RandomDegrees;
    }

    float GetDangerAngle()
    {
        float PlayerDegrees = PlayerSphericalCoordinate.PolarDegrees;
        float MinDegrees = PlayerDegrees - DangerZoneRange;
        float MaxDegrees = MinDegrees + (DangerZoneRange * 2);
        float RandomDegrees = Random.Range(MinDegrees, MaxDegrees);
        return RandomDegrees;
    }

    float GetDeathAngle()
    {
        float PlayerDegrees = PlayerSphericalCoordinate.PolarDegrees;
        float MinDegrees = PlayerDegrees - 10f;
        float MaxDegrees = MinDegrees + (10f * 2);
        float RandomDegrees = Random.Range(MinDegrees, MaxDegrees);
        return RandomDegrees;
    }
}
