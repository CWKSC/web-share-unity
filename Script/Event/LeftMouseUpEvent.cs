using UnityEngine;
using UnityEngine.Events;

public class LeftMouseUpEvent : MonoBehaviour
{
    public UnityEvent onLeftMouseUp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            onLeftMouseUp.Invoke();
        }
    }
}
