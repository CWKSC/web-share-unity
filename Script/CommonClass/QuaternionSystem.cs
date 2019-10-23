using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionSystem : MonoBehaviour
{

    #region Vector3ToQuaternion

    public static Quaternion Vector3ToQuaternion(Vector3 vector)
    {
        return Quaternion.LookRotation(vector);
    }

    public static Quaternion Vector3ToQuaternion_Safe(Vector3 vector)
    {
        if(vector == Vector3.zero)
        {
            return Quaternion.identity;
        }
        return Quaternion.LookRotation(vector);
    }

    public static Quaternion Vector3ToQuaternion_Safe(Vector3 vector, Quaternion expectionQuaternion)
    {
        if (vector == Vector3.zero)
        {
            return expectionQuaternion;
        }
        return Quaternion.LookRotation(vector);
    }

    #endregion


}
