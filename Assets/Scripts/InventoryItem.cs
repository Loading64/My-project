using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public ItemData itemData;

    internal void Set(ItemData itemData)
    {
        this.itemData = itemData;

       // GetComponent<Image>().sprite = itemData.itemIcon;
    }


}
