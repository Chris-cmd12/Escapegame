using System.Collections;
using System.Collections.Generic;
using System;
//using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private float tempsDeBase = 0;
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactPointRadius = 2.0f;
    [SerializeField] private LayerMask _interactableMask;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;

    private void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactPointRadius, _colliders, _interactableMask);

        if (_numFound > 0)
        {
            var interactable = _colliders[0].GetComponent<Interactable>();
            if (interactable != null && Input.GetButton("Fire1"))
            {
                interactable.Interact(this);//this car c moi celuis qui interagie 
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                tempsDeBase = Time.deltaTime;
                if(tempsDeBase == 3)
                {
                    interactable.Interact(this);//this car c moi celuis qui interagie 
                    tempsDeBase = 0;
                    Debug.Log(tempsDeBase);
                }
                
            }
        }



        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    float interactRange = 2f;
        //    Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        //    foreach (Collider collider in colliderArray)
        //    {
        //        if (collider.TryGetComponent(out objectInteract objectInteract))
        //        {
        //            objectInteract.interact();
        //        }
        //    }
        //}
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactPointRadius);
    }
}

