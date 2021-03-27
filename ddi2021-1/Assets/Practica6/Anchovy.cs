using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Anchovy", menuName="Inventory/Anchovy")]
public class Anchovy : Item {
    public int AnchovyAmount = 1;
    public float effectiveness = 10f;

    public override void Use() {
        base.Use();
        Debug.Log($"Se ha conseguido {AnchovyAmount} cantidad de Anchovy");
    }
}