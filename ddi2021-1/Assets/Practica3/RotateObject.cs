using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : Initiative
{
    public Transform target;
    public float Degrees = 22.5f;
    public override void doInitiative() {
        transform.Rotate(0.0f, Degrees, 0.0f, Space.Self);
    }
}
