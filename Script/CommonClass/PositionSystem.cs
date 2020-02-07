using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSystem
{

    public static Vector3 mousePositionOffset = new Vector3(Screen.width / 2, Screen.height / 2);

    public static Vector3 GetUIElementPositionAtMouse()
    {
        return Input.mousePosition - mousePositionOffset;
    }
    public static void SetUIElementPositionAtMouse(Transform UIelement)
    {
        UIelement.localPosition = Input.mousePosition - mousePositionOffset;
    }


    public static List<Vector3> CreateHexPositionList(Vector3 originPosition, Vector3 forwardVector, Vector3 rightVector, int level, float distanceBetweenHexPosition = 0.18f)
    {
        List<Vector3> hexPositionList = new List<Vector3>{ originPosition };
        for (int i = 1; i <= level; i++)
        {
            Vector3 hexPosition0 = originPosition + (Quaternion.AngleAxis(90, forwardVector) * rightVector).normalized * distanceBetweenHexPosition * i;
            Vector3 hexPosition1 = originPosition + (Quaternion.AngleAxis(90 + 60, forwardVector) * rightVector).normalized * distanceBetweenHexPosition * i;
            Vector3 hexPosition2 = originPosition + (Quaternion.AngleAxis(90 + 60 * 2, forwardVector) * rightVector).normalized * distanceBetweenHexPosition * i;
            Vector3 hexPosition3 = originPosition + (Quaternion.AngleAxis(90 + 60 * 3, forwardVector) * rightVector).normalized * distanceBetweenHexPosition * i;
            Vector3 hexPosition4 = originPosition + (Quaternion.AngleAxis(90 + 60 * 4, forwardVector) * rightVector).normalized * distanceBetweenHexPosition * i;
            Vector3 hexPosition5 = originPosition + (Quaternion.AngleAxis(90 + 60 * 5, forwardVector) * rightVector).normalized * distanceBetweenHexPosition * i;
            hexPositionList.Add(hexPosition0);
            hexPositionList.Add(hexPosition1);
            hexPositionList.Add(hexPosition2);
            hexPositionList.Add(hexPosition3);
            hexPositionList.Add(hexPosition4);
            hexPositionList.Add(hexPosition5);
            for (int j = 1; j < i; j++)
            {
                float rate = (float)j / i;
                hexPositionList.Add(Vector3.Lerp(hexPosition0, hexPosition1, rate));
                hexPositionList.Add(Vector3.Lerp(hexPosition1, hexPosition2, rate));
                hexPositionList.Add(Vector3.Lerp(hexPosition2, hexPosition3, rate));
                hexPositionList.Add(Vector3.Lerp(hexPosition3, hexPosition4, rate));
                hexPositionList.Add(Vector3.Lerp(hexPosition4, hexPosition5, rate));
                hexPositionList.Add(Vector3.Lerp(hexPosition5, hexPosition0, rate));
            }
        }
        return hexPositionList;
    }

}
