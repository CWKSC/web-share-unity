using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBoxCollider : MyMonoBehaviour
{
    public BoxCollider unityCollider;

    public Vector3 size = Vector3.one;

    public Vector3[] vertices;
    public Vector3 right;
    public Vector3 up;
    public Vector3 forward;

    // Reference to :
    // https://gamedev.stackexchange.com/questions/44500/how-many-and-which-axes-to-use-for-3d-obb-collision-with-sat

    void Start()
    {
        size = Vector3.one;

        unityCollider = AddComponentIfNotExits<BoxCollider>();
        unityCollider.isTrigger = true;
        UpdateObb();
    }

    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, MyMath.squareRoot3_float);
        UpdateObb();
        //MyBoxCollider[] hitColliders = FindObjectsOfType<MyBoxCollider>();
        for (int i = 0; i < hitColliders.Length; i++)
        {
            if(hitColliders[i] != unityCollider)
            {
                MyBoxCollider collider = hitColliders[i].GetComponent<MyBoxCollider>();
                if (Intersects(this, collider))
                {
                    Debug.Log("碰撞");
                }
            }
        }
    }

    public void UpdateObb()
    {
        Vector3 center = transform.position;
        Quaternion rotation = transform.rotation;

        Vector3 max = size / 2;
        Vector3 min = -max;

        vertices = new[]
        {
                center + rotation * min,
                center + rotation * new Vector3(max.x, min.y, min.z),
                center + rotation * new Vector3(min.x, max.y, min.z),
                center + rotation * new Vector3(max.x, max.y, min.z),
                center + rotation * new Vector3(min.x, min.y, max.z),
                center + rotation * new Vector3(max.x, min.y, max.z),
                center + rotation * new Vector3(min.x, max.y, max.z),
                center + rotation * max,
           };

        right = rotation * Vector3.right;
        up = rotation * Vector3.up;
        forward = rotation * Vector3.forward;
    }

    static bool Intersects(MyBoxCollider a, MyBoxCollider b)
    {
        if (Separated(a.vertices, b.vertices, a.right))
            return false;
        if (Separated(a.vertices, b.vertices, a.up))
            return false;
        if (Separated(a.vertices, b.vertices, a.forward))
            return false;

        if (Separated(a.vertices, b.vertices, b.right))
            return false;
        if (Separated(a.vertices, b.vertices, b.up))
            return false;
        if (Separated(a.vertices, b.vertices, b.forward))
            return false;

        if (Separated(a.vertices, b.vertices, Vector3.Cross(a.right, b.right)))
            return false;
        if (Separated(a.vertices, b.vertices, Vector3.Cross(a.right, b.up)))
            return false;
        if (Separated(a.vertices, b.vertices, Vector3.Cross(a.right, b.forward)))
            return false;

        if (Separated(a.vertices, b.vertices, Vector3.Cross(a.up, b.right)))
            return false;
        if (Separated(a.vertices, b.vertices, Vector3.Cross(a.up, b.up)))
            return false;
        if (Separated(a.vertices, b.vertices, Vector3.Cross(a.up, b.forward)))
            return false;

        if (Separated(a.vertices, b.vertices, Vector3.Cross(a.forward, b.right)))
            return false;
        if (Separated(a.vertices, b.vertices, Vector3.Cross(a.forward, b.up)))
            return false;
        if (Separated(a.vertices, b.vertices, Vector3.Cross(a.forward, b.forward)))
            return false;

        return true;
    }

    static bool Separated(Vector3[] vertsA, Vector3[] vertsB, Vector3 axis)
    {
        // Handles the cross product = {0,0,0} case
        if (axis == Vector3.zero)
            return false;

        var aMin = float.MaxValue;
        var aMax = float.MinValue;
        var bMin = float.MaxValue;
        var bMax = float.MinValue;

        // Define two intervals, a and b. Calculate their min and max values
        for (var i = 0; i < 8; i++)
        {
            var aDist = Vector3.Dot(vertsA[i], axis);
            aMin = aDist < aMin ? aDist : aMin;
            aMax = aDist > aMax ? aDist : aMax;
            var bDist = Vector3.Dot(vertsB[i], axis);
            bMin = bDist < bMin ? bDist : bMin;
            bMax = bDist > bMax ? bDist : bMax;
        }

        // One-dimensional intersection test between a and b
        var longSpan = Mathf.Max(aMax, bMax) - Mathf.Min(aMin, bMin);
        var sumSpan = aMax - aMin + bMax - bMin;
        return longSpan >= sumSpan; // > to treat touching as intersection
    }

}
