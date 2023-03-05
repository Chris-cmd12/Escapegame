using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed;

    float Chrono;

    Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
        Chrono = 0;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 0f;
        //MyAudioSource = this.gameObject.AddComponent<AudioSource>();
        //footStep = Resources.Load("Audio/bruitDePas") as AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") < 0)
        {
            speed = 10f;
            transform.position -= transform.forward * Time.deltaTime * speed;
            animator.SetFloat("IsRunningForward", speed);
        }
        else
        {
            speed = 0;
            animator.SetFloat("IsRunningForward", speed);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            speed = 10f;
            transform.position += transform.forward * Time.deltaTime * speed;
            animator.SetFloat("IsRunningBackward", speed);
        }
        else
        {
            speed = 0;
            animator.SetFloat("IsRunningBackward", speed);
        }

        if (Input.GetAxis("Horizontal") <0)
        {
            transform.Rotate(0, -Time.deltaTime *100f, 0);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(0, Time.deltaTime * 100f, 0);
        }

        if (Chrono < 60 && Time.timeScale != 0)
        {

            Debug.Log(Chrono);
        }
        else if (Chrono > 60)
        {
            Time.timeScale = 0;
            Debug.Log("Vous avez perdu");
        }
        
        Chrono = Chrono + (1*Time.deltaTime);
        
    }

}

