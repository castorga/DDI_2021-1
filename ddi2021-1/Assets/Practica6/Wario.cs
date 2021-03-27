using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Wario", menuName="Inventory/Wario")]
public class Wario : Item {
    public int WarioAmount = 1;
    public float effectiveness = 10f;

    public override void Use() {
        base.Use();
        Debug.Log($"Se ha conseguido {WarioAmount} cantidad de Wario");
    }
}