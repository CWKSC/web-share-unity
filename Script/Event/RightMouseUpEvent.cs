using UnityEngine;
using UnityEngine.Events;

public class RightMouseUpEvent : MonoBehaviour
{
    public UnityEvent onRightMouseUp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            onRightMouseUp.Invoke();
        }
    }
}
