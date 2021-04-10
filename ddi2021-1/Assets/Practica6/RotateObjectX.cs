using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectX : Action
{
    public Transform target;
    public float Degrees = 180.0f;
    public override void doAction() {
        transform.Rotate(Degrees, 0.0f, 0.0f, Space.World);
    }
}
