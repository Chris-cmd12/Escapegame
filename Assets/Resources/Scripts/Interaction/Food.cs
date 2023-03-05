using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour, Interactable
{

    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    //string Interactable.InteractionPrompt => throw new System.NotImplementedException();


    bool Interactable.Interact(PlayerInteract interactor)
    {
        var inventory = interactor.GetComponent<Inventaire>();
        if (inventory.hasManger == false)
        {
            inventory.hasManger = true;
            Debug.Log(" Petit dejeun� finis Etape Termin�");
            Destroy(gameObject);
            return true;
        }
        Debug.Log("  Etape Termin� Passe � la suite ");
        return false;

    }
}
