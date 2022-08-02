using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedItemInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Interacting with item unlocked state");
        return true;
    }
}
