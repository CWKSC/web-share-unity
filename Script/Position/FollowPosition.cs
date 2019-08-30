using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPosition : MonoBehaviour
{

    public GameObject target;

    Vector3 offset;
    Vector3 oldPosition;

    void Start()
    {
        oldPosition = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        offset = target.transform.position - oldPosition;
        transform.position += offset;
        oldPosition = target.transform.position;
    }
}
