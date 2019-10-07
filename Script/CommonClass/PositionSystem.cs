using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSystem : MonoBehaviour
{

    public static Vector3 mousePositionOffset = new Vector3(Screen.width / 2, Screen.height / 2);

    public static Vector3 getUIElementPositionAtMouse()
    {
        return Input.mousePosition - mousePositionOffset;
    }
    public static void setUIElementPositionAtMouse(Transform UIelement)
    {
        UIelement.localPosition = Input.mousePosition - mousePositionOffset;
    }


}
