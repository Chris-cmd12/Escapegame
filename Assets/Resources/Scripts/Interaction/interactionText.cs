using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//actuellement ne serrt a rien  test via la cam mais pas utile 
public class interactionText : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera _mainCamera;
    private void Start()
    {
        _mainCamera = Camera.main;        
    }
    private void LateUpdate()
    {
        var rotation = _mainCamera.transform.rotation;
        transform.LookAt(transform.position + rotation * Vector3.forward, rotation * Vector3.up);
    }
}
