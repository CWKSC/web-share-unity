using UnityEngine;
using UnityEngine.Events;

public class MidMouseUpEvent : MonoBehaviour
{
    public UnityEvent onMidMouseUp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(2))
        {
            onMidMouseUp.Invoke();
        }
    }
}
