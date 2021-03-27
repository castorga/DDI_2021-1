using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMe : MonoBehaviour
{
    public Item item;
    void OnMouseDown() {
        Debug.Log(item);
        Inventory.getInventoryInstance().Add(item);
        Destroy(this.gameObject);
    }
}
