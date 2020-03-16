using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercicio2 : MonoBehaviour
{
    private AudioSource aud;
    private Rigidbody rb;
    private ParticleSystem ps;
    public Text hey; 

    void Start()
    {
        aud = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        ps = GetComponent<ParticleSystem>();
        hey.enabled = false;
    }

    void Update()
    {
        hey.transform.position = new Vector3(rb.position.x, rb.position.y + 3, rb.position.z);
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Colidi com "+other.gameObject.name);
        
        // DESTRUIR CILINDROS
        if(other.gameObject.tag == "Enemy")
            Destroy(other.gameObject);
        
        if (other.gameObject.name == "Bolinha")
        {
            Debug.Log("Colidi com a bolinha!");
            // SOUND
            aud.Play();
            // SCALE
            transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            // ROTATE
            transform.Rotate(0, 90, 0);
            // FORCE
            rb.AddForce(0, 20, 0); 
            // UI TEXT APPEAR
            hey.enabled = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        // PARTICLE SYSTEM
        ps.Play();
    }
}
