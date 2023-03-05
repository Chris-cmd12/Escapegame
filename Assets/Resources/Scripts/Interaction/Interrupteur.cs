using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur : MonoBehaviour, Interactable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    //string Interactable.InteractionPrompt => throw new System.NotImplementedException();
    bool Interactable.Interact(PlayerInteract interactor)
    {
        
        var inventory = interactor.GetComponent<Inventaire>();
        if (inventory.hasLumiere == false)
        {
            inventory.hasLumiere = true;
            Debug.Log(" Eteindre lumiére  Etape Terminé");
                        return true;
        }
        Debug.Log("  Etape Terminé Passe à la suite ");
        return false;

    }
}
