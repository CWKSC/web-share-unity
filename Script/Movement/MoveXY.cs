using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXY : MonoBehaviour
{

    public float xSpeed = 1;
    public float ySpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * xSpeed,
                                         transform.position.y + Input.GetAxis("Vertical")   * Time.deltaTime * ySpeed,
                                         transform.position.z);
    }
}
