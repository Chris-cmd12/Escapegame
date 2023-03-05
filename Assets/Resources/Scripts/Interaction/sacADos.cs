using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sacADos : MonoBehaviour,Interactable
{

    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    //string Interactable.InteractionPrompt => throw new System.NotImplementedException();

    bool Interactable.Interact(PlayerInteract interactor)
    {
        var inventory = interactor.GetComponent<Inventaire>();
        if (inventory.hasSac == false)
        {
            inventory.hasSac = true;
            Debug.Log(" Sac Recuperé  Etape Terminé");
            Destroy(gameObject);
            return true;
        }
        Debug.Log("  Etape Terminé Passe à la suite ");
        return false;

    }
}
