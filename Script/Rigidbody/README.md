# Rigidbody

- Gravitational.cs
  - 拥有这个 Gravitational 组件之间都会产生一个引力。
- SetVelocity.cs
  - 设定 Rigidbody 速率
  - 可视化地显示出向量的方向，可以设定速率的量值。
  - 在一开始时进行速率的设定。

## Gravitational.cs

```csharp
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
```

## Script 结构：

### 成员：

```csharp
private const double gravitationalConstant = 6.673e-11; 

public float oneKgPer = 1e24f; 

public float oneMeterPer = 1e17f;  

private Rigidbody rb; 
```

### 函数：

```csharp
double gravitationalForce(Rigidbody a, Rigidbody b)

public T AddComponentIfNotExits<T>() where T : Component

void Start()

void Update()
```

### 作用：

拥有这个 Gravitational 组件之间都会产生一个引力。

## SetVelocity.cs

```csharp
/* SetVelocity.cs */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVelocity : MonoBehaviour
{

    public Vector3 direction;
    public float value = 1;

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
        AddComponentIfNotExits<Rigidbody>().velocity = (direction.normalized * value);
    }

    void OnDrawGizmosSelected()
    {
        // Draws a blue line from this transform to the target
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + direction);
    }
}
```

## Script 结构：

### 成员：

```csharp
public Vector3 direction;

public float value = 1;
```

### 函数：

```csharp
public T AddComponentIfNotExits<T>() where T : Component

void Start()

void OnDrawGizmosSelected()
```

### 作用：

设定 Rigidbody 速率。

可视化地显示出向量的方向，可以设定速率的量值。

在一开始时进行速率的设定。