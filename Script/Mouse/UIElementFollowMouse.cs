using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIElementFollowMouse : MonoBehaviour
{
    public Transform UIGameObject;

    Vector3 mousePositionOffset = new Vector3(Screen.width / 2, Screen.height / 2, 0);

    // Update is called once per frame
    void Update()
    {
        UIGameObject.localPosition = Input.mousePosition - mousePositionOffset;
    }

}
