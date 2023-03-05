using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frapper : MonoBehaviour, Interactable
{
    public int nbAppui = 0;
    //public AudioSource MyAudioSource;
    public AudioClip coup;

    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    //string Interactable.InteractionPrompt => throw new System.NotImplementedException();
    void Start()
    {
        coup = Resources.Load("Audio/coupDePoint.wav") as AudioClip;
        GetComponent<AudioSource>().PlayOneShot(coup);
    }
    bool Interactable.Interact(PlayerInteract interactor)
    {
        nbAppui++;
        GetComponent<AudioSource>().Play();
        var inventory = interactor.GetComponent<Inventaire>();

        if (inventory.hasReveil == false && nbAppui == 10)
        {
            inventory.hasReveil = true;
            GetComponent<AudioSource>().Stop();
            Debug.Log(" Reveil eteint   Bon jeux et Bonne chance ");
            return true;
        }
        if (inventory.hasReveil == true)
        {
            Debug.Log("  Etape Terminé Passe à la suite ");
            return true;
        }
        return false;
    }
}