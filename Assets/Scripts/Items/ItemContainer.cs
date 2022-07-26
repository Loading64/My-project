using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemContainer : MonoBehaviour
{
    [SerializeField] private Item item;
 
    // Call from elsewhere
    // Take data and put it into inventory
    public Item Data
    {
        get
        {
            return item;
        }
        set
        {
            this.item = value;
        }
    }
}
