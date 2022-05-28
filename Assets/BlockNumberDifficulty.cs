using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNumberDifficulty : SingletonMonoBehavior<BlockNumberDifficulty>
{
    [SerializeField] AnimationCurve NumberCurve;
    [SerializeField] AnimationCurve SpaceCurve;

    public int GetNumber()
    {
        float BigFloor = Realm.instance.GetBigFloor();
        return Mathf.RoundToInt(NumberCurve.Evaluate(BigFloor));
    }
    public int GetSpace()
    {
        float BigFloor = Realm.instance.GetBigFloor();
        return Mathf.RoundToInt(SpaceCurve.Evaluate(BigFloor));
    }

}
