using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LevelSwapInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        if (interactor is null)
        {
            throw new ArgumentNullException(nameof(interactor));
        }

        SceneManager.LoadScene(_prompt);
        return true;
    }
}
