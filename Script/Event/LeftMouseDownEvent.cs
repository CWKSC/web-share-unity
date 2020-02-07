using UnityEngine;
using UnityEngine.Events;

public class LeftMouseDownEvent : MonoBehaviour
{
    public UnityEvent onLeftMouseDown;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onLeftMouseDown.Invoke();
        }
    }
}
