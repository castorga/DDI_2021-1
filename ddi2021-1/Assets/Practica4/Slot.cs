using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public Image image;
    public Sprite defaultSprite;
    public int counter = 0;
    public Text counterText;

    void Start() {
        if(image != null && item != null) {
            image.sprite = item.sprite;
        }
    }

    public void SetItem(Item item, int count) {

        this.item = item;
        counter = count;
        if(image != null) {
            image.sprite = item.sprite;
        }
        if(counterText != null) {
            counterText.text = counter.ToString();
        }
    }

    public void Clear() {
        this.item = null;
        image.sprite = defaultSprite;
    }

    public void UseItem() {
        if (this.item != null) {
            item.Use();
            if (counter > 0)
                counter--;
            if(counterText != null)  
                counterText.text = counter.ToString();
        }
    }
}
