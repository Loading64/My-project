using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface InteractableInterface
{
    public string InteractionPrompt { get; }

    public int InteractionPrompt2 { get; }

    public bool Interact (Interactor interactor);


}
