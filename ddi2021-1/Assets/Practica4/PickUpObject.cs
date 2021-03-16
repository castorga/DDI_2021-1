using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : Action
{
    public Item item;
    public override void doAction() {
        Debug.Log(item);
        Inventory.getInventoryInstance().Add(item);
        Destroy(this.gameObject);
    }

}
