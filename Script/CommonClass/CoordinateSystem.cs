using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateSystem : MonoBehaviour
{

    public static float polarAngle(float x, float y)
    {
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg;
    }
    public static float polarAngle(Vector2 point)
    {
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg;
    }


    public static float polarAngle_startAtUp(float x, float y)
    {
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg - 90.0f;
    }
    public static float polarAngle_startAtUp(Vector2 point)
    {
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg - 90.0f;
    }


    public static float polarAngle_startAtDown(float x, float y)
    {
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg - 270.0f;
    }
    public static float polarAngle_startAtDown(Vector2 point)
    {
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg - 270.0f;
    }


    public static float polarAngle_startAtLeft(float x, float y)
    {
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg - 180.0f;
    }
    public static float polarAngle_startAtLeft(Vector2 point)
    {
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg - 180.0f;
    }


    public static float polarAngle_startAtRight(float x, float y)
    {
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg;
    }
    public static float polarAngle_startAtRight(Vector2 point)
    {
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg;
    }

}
