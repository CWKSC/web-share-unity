using UnityEngine;
using UnityEngine.Events;

public class RightMouseEvent : MonoBehaviour
{
    public UnityEvent onRightMouse;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            onRightMouse.Invoke();
        }
    }
}
