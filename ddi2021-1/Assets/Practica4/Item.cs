using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
[Serializable]
public class Item {

    public enum ItemType {
        Sword,
        Bow,
        Beer,
    }

    public ItemType itemType;
    public int amount;

    public Sprite getSprite(){
        switch (itemType){
            default:
            case ItemType.Sword:   return ItemAssets.Instance.SwordSprite;
            case ItemType.Bow:          return ItemAssets.Instance.BowSprite;
            case ItemType.Beer:           return ItemAssets.Instance.BeerSprite;
        }
    }

    public bool IsStackable(){
        switch(itemType){
            default:
            case ItemType.Beer:
                return true;
            case ItemType.Sword:
            case ItemType.Bow:
                return false;
        }
    }

}
*/

public enum ItemType
{
    Sword, 
    Bow, 
    Beer
}

[CreateAssetMenu(fileName= "New Item", menuName="Inventory/Generic")]
public class Item : ScriptableObject {
    public ItemType itemType = ItemType.Sword;
    public Sprite sprite = null;

    public virtual void Use() {
        Debug.Log($"usando item {name}");
    }
}