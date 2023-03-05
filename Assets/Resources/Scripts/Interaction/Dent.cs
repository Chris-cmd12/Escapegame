using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dent : MonoBehaviour, Interactable
{
    public AudioSource MyAudioSource;
    public AudioClip brossageDeDent;

    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    float delay;

    //string Interactable.InteractionPrompt => throw new System.NotImplementedException();
    void Start()
    {
        MyAudioSource = this.gameObject.AddComponent<AudioSource>();
        brossageDeDent = Resources.Load("Audio/brossagededent") as AudioClip;
    }

    bool Interactable.Interact(PlayerInteract interactor)
    {
        var inventory = interactor.GetComponent<Inventaire>();
        if (inventory.hasBrosserDent == false)
        {
            inventory.hasBrosserDent = true;
            //GetComponent<AudioSource>().PlayOneShot(brossageDeDent);

            MyAudioSource.clip = brossageDeDent;
            MyAudioSource.PlayOneShot(brossageDeDent);
            Debug.Log(" dent brossé  Etape Terminé");
            return true;
        }
        Debug.Log("  Etape Terminé Passe à la suite ");
        return false;

    }
}
