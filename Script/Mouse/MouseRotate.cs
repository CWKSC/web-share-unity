using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

    }

    Vector3 mousePosition;
    Vector3 oldPosition;

    public float mult = 0.2f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            oldPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            transform.RotateAround(target.transform.position, Vector3.up, mult * (oldPosition.x - mousePosition.x));
            transform.RotateAround(target.transform.position, Vector3.Cross(transform.position - target.transform.position, Vector3.up),
                - mult * (oldPosition.y - mousePosition.y));
            oldPosition = mousePosition;
        }

    }
}
