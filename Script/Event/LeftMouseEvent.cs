using UnityEngine;
using UnityEngine.Events;

public class LeftMouseEvent : MonoBehaviour
{
    public UnityEvent onLeftMouse;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            onLeftMouse.Invoke();
        }
    }
}
