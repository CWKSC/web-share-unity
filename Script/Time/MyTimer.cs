using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTimer
{
    public float countTime = 0.0f;
    public float thresholdTime = 1.0f;

    public void Reset() => countTime = 0.0f;

    public void CountTime() => countTime += Time.deltaTime;

    public void IfCount_ElseReset(bool condition)
    {
        if (condition) {
            CountTime();
        }
        else {
            Reset();
        }
    }

    public void IfOverThresholdTime_Run(Action action)
    {
        if (countTime > thresholdTime) { action(); Reset(); }
    }

    public void IfCount_ElseReset_OverThresholdTime_Run(bool condition, Action action)
    {
        IfCount_ElseReset(condition);
        IfOverThresholdTime_Run(action);
    }

}
