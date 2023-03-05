using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour, Interactable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    //string Interactable.InteractionPrompt => throw new System.NotImplementedException();
    bool Interactable.Interact(PlayerInteract interactor)
    {
        var inventory = interactor.GetComponent<Inventaire>();
        if (inventory.MissionCheck== true)
        {      
            Debug.Log("La porte est ouverte Jeux Gagné ");
            Time.timeScale = 0;
            return true;
        }
        else {
            Debug.Log("Il semblerais qu'il vous  reste des objectif à faire  ");
            return false;
        }
    }
}
