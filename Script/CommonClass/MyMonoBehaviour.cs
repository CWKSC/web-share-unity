using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonoBehaviour : MonoBehaviour
{
    #region Add Component If Not Exits
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

    public T AddComponentIfNotExits_noWarning<T>() where T : Component
    {
        Component component = GetComponent<T>();
        return component == null ? gameObject.AddComponent<T>() : (T)component;
    }

    public static T AddComponentIfNotExits<T>(GameObject gameObject) where T : Component
    {
        Component component = gameObject.GetComponent<T>();
        if (component == null)
        {
            Debug.Log("GameObject: [" + gameObject.name + "] havn't [" + typeof(T) + "] component, suggest Add it manually.");
            return gameObject.AddComponent<T>();
        }
        return (T)component;
    }

    public static T AddComponentIfNotExits_noWarning<T>(GameObject gameObject) where T : Component
    {
        Component component = gameObject.GetComponent<T>();
        return component == null ? gameObject.AddComponent<T>() : (T)component;
    }
    #endregion

}
