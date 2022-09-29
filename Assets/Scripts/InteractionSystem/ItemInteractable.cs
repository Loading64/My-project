using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    [SerializeField] private int _idprompt;
    public int InteractionPrompt2 => _idprompt;


    

    public bool Interact(Interactor interactor)
    {
        var inventory = Inventory.instance;
        Debug.Log(_prompt);
        new Item { name = _prompt, value = _idprompt};
        return true;
    }
}
