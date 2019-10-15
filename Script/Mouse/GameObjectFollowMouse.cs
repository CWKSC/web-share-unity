using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectFollowMouse : MonoBehaviour
{
    public GameObject target;
    public float zPosition = 3;

    Vector3 zPositionOffset;

    private void Start()
    {
        zPositionOffset = Vector3.forward * zPosition;
    }

    // Update is called once per frame
    void Update()
    {
        target.transform.localPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + zPositionOffset);
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition + zPositionOffset));
    }
}
