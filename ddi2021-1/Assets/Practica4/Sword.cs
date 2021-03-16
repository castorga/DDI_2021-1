using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "New Sword", menuName="Inventory/Sword")]
public class Sword : Item {
    public int swordsAmount = 1;
    public float effectiveness = 10f;

    public override void Use() {
        base.Use();
        Debug.Log($"Se ha conseguido {swordsAmount} cantidad de espadas");
    }
}