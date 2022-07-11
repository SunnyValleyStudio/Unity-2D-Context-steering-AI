using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SteeringBehaviour : MonoBehaviour
{
    public abstract (float[] danger, float[] interest) 
        GetSteering(float[] danger, float[] interest, AIData aiData);
}
