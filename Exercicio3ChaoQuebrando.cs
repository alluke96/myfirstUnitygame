using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio3ChaoQuebrando : MonoBehaviour
{
    private AudioSource aud;
    private Rigidbody rb;
    private int cont = 0;

    void Start()
    {
        aud = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Colidi com "+other.gameObject.name);
        if (other.gameObject.name == "chaoDestrutivel")
        {
            Debug.Log(+cont);
            aud.Play();
            cont++;
        }
        if (other.gameObject.name == "chaoDestrutivel" && cont == 3)
        {
            aud.Play();
            Destroy(other.gameObject);
        }
    }
}