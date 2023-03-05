using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Interactable : MonoBehaviour
public interface Interactable
{
    public string InteractionPrompt { get; }
    public bool Interact(PlayerInteract interactor);
}
