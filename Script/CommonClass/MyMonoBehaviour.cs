using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonoBehaviour : MonoBehaviour
{
    public T AddComponentIfNotExits<T>() where T : Component
    {
        Component component = GetComponent<T>();
        if (component == null)
        {
            Debug.Log("GameObject: [" + gameObject.name + "] havn't [" + typeof(T) + "] component, suggest Add it manually.");
            return gameObject.AddComponent<T>();
        }
        return (T)component;
    }

}
