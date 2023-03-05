using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Douche : MonoBehaviour, Interactable
{

    public AudioSource MyAudioSource;
    public AudioClip audioDouche;

    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    //string Interactable.InteractionPrompt => throw new System.NotImplementedException();
    void Start()
    {
        MyAudioSource = this.gameObject.AddComponent<AudioSource>();
        audioDouche = Resources.Load("Audio/douche") as AudioClip;
    }

    bool Interactable.Interact(PlayerInteract interactor)
    {
        var inventory = interactor.GetComponent<Inventaire>();
        if (inventory.hasDoucher == false)
        {
            inventory.hasDoucher = true;
            MyAudioSource.clip = audioDouche;
            MyAudioSource.PlayOneShot(audioDouche, 0.2f);
            Debug.Log(" douche finis   Etape Terminé");
            return true;
        }
        Debug.Log("  Etape Terminé Passe à la suite ");
        return false;

    }
}
