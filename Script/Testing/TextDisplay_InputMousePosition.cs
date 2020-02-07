using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay_InputMousePosition : MonoBehaviour
{
    Text textGameObject;

    // Start is called before the first frame update
    void Start()
    {
        textGameObject = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textGameObject.text = "Input.mousePosition: " + Input.mousePosition;
    }


}
