using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance {get; private set;}

    private void Awake() {
        Instance = this;
    }

    public Transform pfItemWorld;

    public Sprite SwordSprite;
    public Sprite BowSprite;
    public Sprite BeerSprite;
    public Sprite warioSprite;
    public Sprite marioSprite;
    public Sprite anchovySprite;
}