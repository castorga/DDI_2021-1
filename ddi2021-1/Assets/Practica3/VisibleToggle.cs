using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleToggle : Action
{
    public Renderer rendrer;
    public override void doAction() {
        rendrer.enabled = !rendrer.enabled;
    }
}
