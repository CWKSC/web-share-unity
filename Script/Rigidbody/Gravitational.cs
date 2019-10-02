/* Gravitational.cs */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitational : MonoBehaviour
{
    private const double gravitationalConstant = 6.673e-11;

    public float oneKgPer = 1e24f;
    public float oneMeterPer = 1e17f;

    private Rigidbody rb;

    double gravitationalForce(Rigidbody a, Rigidbody b)
    {
        float massA = a.mass * oneKgPer;
        float massB = b.mass * oneKgPer;
        float distance = Vector3.Distance(a.gameObject.transform.position, b.gameObject.transform.position) * oneMeterPer;
        return (gravitationalConstant * massA * massB) / Mathf.Pow(distance, 2);
    }

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

    // Start is called before the first frame update
    void Start()
    {

        rb = AddComponentIfNotExits<Rigidbody>();
        rb.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        Gravitational[] gameObjects = FindObjectsOfType<Gravitational>();
        foreach (Gravitational obj in gameObjects)
        {
            if (obj == this) continue;

            float force = -1 * (float)gravitationalForce(obj.rb, rb);
            rb.AddExplosionForce(force * Time.deltaTime, obj.transform.position, 0);
        }
    }

}