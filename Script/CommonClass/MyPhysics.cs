using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPhysics 
{

    public static float Momentum(float mass, float velocity)
    {
        return mass * velocity;
    }

    public static float KineticEnergy(float mass, float velocity)
    {
        return mass * velocity * velocity / 2.0f;
    }
}
