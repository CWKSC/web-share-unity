using UnityEngine;

public class EqualPosition : MonoBehaviour
{
    public Transform targetTransform;

    // Update is called once per frame
    void Update()
    {
        transform.position = targetTransform.position;
    }
}
