using UnityEngine;
using UnityEngine.Events;

public class MidMouseDownEvent : MonoBehaviour
{
    public UnityEvent onMidMouseDown;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            onMidMouseDown.Invoke();
        }
    }
}
