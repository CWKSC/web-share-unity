using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXZ : MonoBehaviour
{
    public float xSpeed = 1;
    public float zSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * xSpeed,
                                         transform.position.y,
                                         transform.position.z + Input.GetAxis("Vertical") * Time.deltaTime * zSpeed);
    }
}
