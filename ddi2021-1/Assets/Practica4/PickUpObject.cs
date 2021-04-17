using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : Initiative
{
    public Item item;
    public override void doInitiative() {
        Debug.Log(item);
        Inventory.getInventoryInstance().Add(item);
        Destroy(this.gameObject);
    }

}
