using UnityEngine;
using UnityEngine.Events;

public class RightMouseDownEvent : MonoBehaviour
{
    public UnityEvent onRightMouseDown;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            onRightMouseDown.Invoke();
        }
    }
}
