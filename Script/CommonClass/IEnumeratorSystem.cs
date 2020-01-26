using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnumeratorSystem : MonoBehaviour
{

    public static IEnumerator SmoothAction(Action<float, float> mainOperation, Action endOperation, float time = 1.0f)
    {
        for (float timeCount = 0; timeCount <= time; timeCount += Time.deltaTime)
        {
            mainOperation(timeCount, time);
            yield return null;
        }
        endOperation();
    }


    public static IEnumerator SmoothAction(Action<float> mainOperation, Action endOperation, float time = 1.0f)
    {
        for (float timeCount = 0; timeCount <= time; timeCount += Time.deltaTime)
        {
            float timeRatio = timeCount / time;
            mainOperation(timeRatio);
            yield return null;
        }
        endOperation();
    }


}
