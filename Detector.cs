using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Detector : MonoBehaviour
{
    public abstract void Detect(AIData aiData);
}
