using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] FoVChanger FoV;
    [SerializeField] SpeedChanger Forward;
    [SerializeField] DistChanger Dist;
    [SerializeField] StrengthChanger Strength;
    [SerializeField] SpeedShakeChanger SpeedShake;
    [SerializeField] FakeTrailVelocityChanger LeftTrailVelocity;
    [SerializeField] FakeTrailVelocityChanger RightTrailVelocity;
    [SerializeField] FakeTrailWidthChanger LeftFakeTrailWidthChanger;
    [SerializeField] FakeTrailWidthChanger RightFakeTrailWidthChanger;
    [SerializeField] CameraFollowSpeedChanger CameraFollowSpeed;
    [SerializeField] EngineSouneChanger EngineSound;
    [SerializeField] AnimationCurve PowerCurve;
    public bool OnSpeedup;
    public float Power;

    public PlaneAni planeAni;

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            OnSpeedup = true;
        }
        if (Input.GetMouseButtonUp(2))
        {
            OnSpeedup = false;
        }
        planeAni.SetOpen(OnSpeedup);

        Power += 3 * Time.deltaTime * (OnSpeedup ? 1 : -1);
        Power = Mathf.Clamp(Power, 0, 1);

        float CurvedPower = PowerCurve.Evaluate(Power);

        FoV.Change(CurvedPower);
        Forward.Change(CurvedPower);
        Dist.Change(CurvedPower);
        Strength.Change(CurvedPower);
        SpeedShake.Change(CurvedPower);
        LeftTrailVelocity.Change(CurvedPower);
        RightTrailVelocity.Change(CurvedPower);
        LeftFakeTrailWidthChanger.Change(CurvedPower);
        RightFakeTrailWidthChanger.Change(CurvedPower);
        CameraFollowSpeed.Change(CurvedPower);
        EngineSound.Change(CurvedPower);
    }
}
