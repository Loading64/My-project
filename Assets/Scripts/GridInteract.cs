using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(ItemGrid))]

public class GridInteract : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    InventoryControl inventoryControl;

    ItemGrid itemGrid;


    public void OnPointerEnter(PointerEventData eventData)
    {
        inventoryControl.selectedItemGrid = itemGrid;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        inventoryControl.selectedItemGrid = null;
    }

     private void Awake() {
        inventoryControl = FindObjectOfType(typeof(InventoryControl)) as InventoryControl;
        itemGrid = GetComponent<ItemGrid>();
    }
}
