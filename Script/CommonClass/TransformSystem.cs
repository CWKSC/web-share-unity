using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSystem : MonoBehaviour
{

    public static IEnumerator SmoothMove(Transform transform, Vector3 oldPosition, Quaternion oldQuaternion, Vector3 newPosition, Quaternion newQuaternion, float time = 1.0f)
    {
        for (float timeCount = 0; timeCount <= time; timeCount += Time.deltaTime)
        {
            transform.position = Vector3.Lerp(oldPosition, newPosition, timeCount / time);
            transform.rotation = Quaternion.Lerp(oldQuaternion, newQuaternion, timeCount / time);
            yield return null;
        }
        transform.position = newPosition;
        transform.rotation = newQuaternion;
        yield return null;
    }


}
