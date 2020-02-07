using UnityEngine;
using UnityEngine.Events;

public class MidMouseEvent : MonoBehaviour
{
    public UnityEvent onMidMouse;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            onMidMouse.Invoke();
        }
    }
}
