using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalComponentsSeries
{
    public GameObject gameObject;

    public Rigidbody rigidbody;
    public Collider collider;

    public void Initialization(GameObject gameObject)
    {
        this.gameObject = gameObject;
        rigidbody = MyMonoBehaviour.AddComponentIfNotExits_noWarning<Rigidbody>(gameObject);
        collider  = MyMonoBehaviour.AddComponentIfNotExits_noWarning<Collider>(gameObject);
    }

}
