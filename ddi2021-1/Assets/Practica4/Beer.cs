using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Beer", menuName="Inventory/Beer")]
public class Beer : Item {
    public int BeerAmount = 1;
    public float effectiveness = 10f;

    public override void Use() {
        base.Use();
        Debug.Log($"Se ha conseguido {BeerAmount} cantidad de cerveza");
    }
}