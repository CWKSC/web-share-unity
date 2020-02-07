using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMouseDownUpDiff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 mousePosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Mouse Down.");
            mousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            //Debug.Log("Mouse Up.");
            Debug.Log(Input.mousePosition - mousePosition);
        }
    }


}
