using UnityEngine;

public class FollowPosition : MonoBehaviour
{

    public Transform targetTransform;

    Vector3 offset;
    Vector3 oldPosition;

    public void Start()
    {
        oldPosition = targetTransform.position;
    }

    public void Update()
    {
        offset = targetTransform.position - oldPosition;
        transform.position += offset;
        oldPosition = targetTransform.position;
    }
}
