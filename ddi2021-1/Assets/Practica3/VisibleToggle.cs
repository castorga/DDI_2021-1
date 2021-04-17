using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleToggle : Initiative
{
    public Renderer rendrer;
    public override void doInitiative() {
        rendrer.enabled = !rendrer.enabled;
    }
}
