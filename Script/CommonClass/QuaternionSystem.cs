using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionSystem : MonoBehaviour
{

    public static Quaternion Vector3ToQuaternion(Vector3 vector)
    {
        // For Human to understand //
        /*
        return Quaternion.Euler(
            -CoordinateSystem.polarAngle(vector.z, vector.y), 
            -CoordinateSystem.polarAngle_startAtUp(vector.x, vector.z), 
            CoordinateSystem.polarAngle(vector.x, vector.y));
        */

        // For Machine //
        return Quaternion.Euler(
            - Mathf.Atan2(vector.y, vector.z) * Mathf.Rad2Deg,
            - Mathf.Atan2(vector.z, vector.x) * Mathf.Rad2Deg + 90.0f,
            Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg);
    }
}
