using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectX : Initiative
{
    public Transform target;
    public float Degrees = 180.0f;
    public override void doInitiative() {
        transform.Rotate(Degrees, 0.0f, 0.0f, Space.World);
    }
}
