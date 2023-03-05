using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class porteMaison : MonoBehaviour, Interactable
{
    private float vitesse = 2.0f;
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;


    //string Interactable.InteractionPrompt => throw new System.NotImplementedException();
    bool Interactable.Interact(PlayerInteract interactor)
    {
        transform.Rotate(.0f, 45f * vitesse, .0f );
        //if(!isOpen)
        //{
        //    transform.Rotate(.0f, 45f * vitesse, .0f);
        //    isOpen = true;
        //}
        //if (isOpen)
        //{
        //    transform.Rotate(.0f, -45f * vitesse, .0f);
        //    isOpen=false;
        //}
        return false;
    }
    //==========================================================

}

