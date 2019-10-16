using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateSystem : MonoBehaviour
{

    public static float polarAngle(float x, float y)
    {
        // https://zhuanlan.zhihu.com/p/81821405
        // https://zhuanlan.zhihu.com/p/85469435
        // https://zh.wikipedia.org/wiki/%E6%9E%81%E5%9D%90%E6%A0%87%E7%B3%BB

        return Mathf.Atan2(y, x) * Mathf.Rad2Deg;
    }
    public static float polarAngle(Vector2 point)
    {
        // For Human to understand //
        // return polarAngle(point.x, point.y);

        // For Machine //
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg;
    }


    public static float polarAngle_startAtUp(float x, float y)
    {
        // For Human to understand //
        // return polarAngle(x, y) - 90.0f;

        // For Machine //
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg - 90.0f;
    }
    public static float polarAngle_startAtUp(Vector2 point)
    {
        // For Human to understand //
        // return polarAngle(point.x, point.y) - 90.0f;

        // For Machine //
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg - 90.0f;
    }


    public static float polarAngle_startAtDown(float x, float y)
    {
        // For Human to understand //
        // return polarAngle(x, y) - 270.0f;

        // For Machine //
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg - 270.0f;
    }
    public static float polarAngle_startAtDown(Vector2 point)
    {
        // For Human to understand //
        // return polarAngle(point.x, point.y) - 270.0f;

        // For Machine //
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg - 270.0f;
    }


    public static float polarAngle_startAtLeft(float x, float y)
    {
        // For Human to understand //
        // return polarAngle(x, y) - 180.0f;

        // For Machine //
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg - 180.0f;
    }
    public static float polarAngle_startAtLeft(Vector2 point)
    {
        // For Human to understand //
        // return polarAngle(point.x, point.y) - 180.0f;

        // For Machine //
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg - 180.0f;
    }


    public static float polarAngle_startAtRight(float x, float y)
    {
        // For Human to understand //
        // return polarAngle(x, y);

        // For Machine //
        return Mathf.Atan2(y, x) * Mathf.Rad2Deg;
    }
    public static float polarAngle_startAtRight(Vector2 point)
    {
        // For Human to understand //
        // return polarAngle(point.x, point.y);

        // For Machine //
        return Mathf.Atan2(point.y, point.x) * Mathf.Rad2Deg;
    }

}
