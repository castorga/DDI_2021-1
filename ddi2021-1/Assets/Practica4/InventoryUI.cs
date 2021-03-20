using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory _inventory;
    public GameObject panel;

    void Start() {
        _inventory = Inventory.getInventoryInstance();
        _inventory.onChange = UpdateUI;
    }

    void Update() {
        if(CrossPlatformInputManager.GetButtonDown("Inventory")) {
            panel.SetActive(!panel.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI() {
        Slot[] slots = GetComponentsInChildren<Slot>(true);
        Item[] swordItems = _inventory.GetAllItemsByType(ItemType.Sword);
        Item[] bowItems = _inventory.GetAllItemsByType(ItemType.Bow);
        Item[] beerItems = _inventory.GetAllItemsByType(ItemType.Beer);

        if(swordItems.Length > 0)
            slots[0].SetItem(swordItems[0], swordItems.Length);
        if(bowItems.Length > 0)
            slots[1].SetItem(bowItems[0], bowItems.Length);
        if(beerItems.Length > 0)
            slots[2].SetItem(beerItems[0], beerItems.Length);

    }
}
