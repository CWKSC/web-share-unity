using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardAndRotate : MonoBehaviour
{

    public float forwardSpeed = 4;
    public float rotateSpeed = 120;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * forwardSpeed);
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed);
    }
}
