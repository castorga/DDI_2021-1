using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Mario", menuName="Inventory/Mario")]
public class Mario : Item {
    public int MarioAmount = 1;
    public float effectiveness = 10f;

    public override void Use() {
        base.Use();
        Debug.Log($"Se ha conseguido {MarioAmount} cantidad de Mario");
    }
}