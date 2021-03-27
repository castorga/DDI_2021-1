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
        Item[] warioItems = _inventory.GetAllItemsByType(ItemType.Wario);
        Item[] marioItems = _inventory.GetAllItemsByType(ItemType.Mario);
        Item[] anchovyItems = _inventory.GetAllItemsByType(ItemType.Anchovy);

        if(swordItems.Length > 0) {
            slots[0].SetItem(swordItems[0], swordItems.Length);
            Debug.Log("Bitch");
        }
        if(bowItems.Length > 0) {
            slots[1].SetItem(bowItems[0], bowItems.Length);
            Debug.Log("Bitch2");
        }
        if(beerItems.Length > 0) {
            slots[2].SetItem(beerItems[0], beerItems.Length);
            Debug.Log("Bitch3");
        }
        if(warioItems.Length > 0) {
            slots[3].SetItem(warioItems[0], warioItems.Length);
            Debug.Log("FUCKING WARIO");
        }
        if(marioItems.Length > 0) {
            Debug.Log("Fucking mario");
            slots[4].SetItem(marioItems[0], marioItems.Length);
        }
        if(anchovyItems.Length > 0) {
            Debug.Log("A fucking anchovy");
            slots[5].SetItem(anchovyItems[0], anchovyItems.Length);
        }
    }
}
