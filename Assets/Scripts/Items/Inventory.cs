using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Singleton, call from any script
    public static Inventory instance;
 
    // fill in inspector
    public List<Item> items;
 
    // Setup this very simple singleton
    private void Awake()
    {
        if (instance == null)  
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
