using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Bow", menuName="Inventory/Bow")]
public class Bow : Item {
    public int BowAmount = 1;
    public float effectiveness = 10f;

    public override void Use() {
        base.Use();
        Debug.Log($"Se ha conseguido {BowAmount} cantidad de arcos");
    }
}