using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour , Interactable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    //string Interactable.InteractionPrompt => throw new System.NotImplementedException();
    
    bool Interactable.Interact(PlayerInteract interactor)
    {
        var inventory = interactor.GetComponent<Inventaire>();
        inventory.hasKey = true;
        Debug.Log("clef rammasé");
        Destroy(gameObject);// detruire graphiquement la clef pour faire genre elle est rammasé 
        return true;
    }
}
