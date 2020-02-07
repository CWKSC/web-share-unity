using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay_ScreenToWorldPoint : MonoBehaviour
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
        textGameObject.text = "ScreenToWorldPoint(Input.mousePosition + Vector3.forward): " + Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward);
    }

}
