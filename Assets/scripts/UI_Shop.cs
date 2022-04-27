using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Shop : MonoBehaviour
{
    private Transform container;
    private Transform shopItem;
    private void Awake()
    {
        container = transform.Find("container");
        shopItem = container.Find("SPEED");
        shopItem.gameObject.SetActive(false);
    }

    private void CreateItemButton(Sprite itemSprite, string itemName, int itemCost)
    {

    }
}
