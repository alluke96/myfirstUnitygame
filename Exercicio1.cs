using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    public Material textura, textura2;
    private Rigidbody rb;
    private MeshRenderer mr;
    private ParticleSystem ps;
    private TrailRenderer tr;
    private AudioSource aud;
    public AudioClip clip1, clip2, clip3;

    public float verticalSpeed;
    public float horizontalSpeed;
    public float jumpSpeed;
    
    public 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();
        ps = GetComponent<ParticleSystem>();
        tr = GetComponent<TrailRenderer>();
        aud = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        // SCALE
        if (Input.GetKeyDown(KeyCode.R))
            transform.localScale = new Vector3(5,5,5);
        if (Input.GetKeyDown(KeyCode.T))
            transform.localScale = new Vector3(2,2,2);

        // GRAVITY
        if (Input.GetKeyDown(KeyCode.O))
            rb.useGravity = false;
        if (Input.GetKeyDown(KeyCode.P))
            rb.useGravity = true;

        // CHANGE TEXTURE
        if (Input.GetKeyDown(KeyCode.A))
            mr.material = textura;
        if (Input.GetKeyDown(KeyCode.S))
            mr.material = textura2;
        
        // PARTICLE SYSTEM
        if (Input.GetKeyDown(KeyCode.D))
            ps.Stop();
        if (Input.GetKeyDown(KeyCode.F))
            ps.Play();
        
        // TRAIL
        if (Input.GetKeyDown(KeyCode.G))
            tr.enabled = false;
        if (Input.GetKeyDown(KeyCode.H))
            tr.enabled = true;

        // AUDIO CLIPS
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            aud.clip = clip1;
            aud.Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)){
            aud.clip = clip2;
            aud.Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)){
            aud.clip = clip3;
            aud.Play();
        }
        if (Input.GetKeyDown(KeyCode.B))
            aud.Play();


        // MOVIMENTACAO
        if(Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(new Vector3(0,0,verticalSpeed));
        if(Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(new Vector3(-horizontalSpeed,0,0));
        if(Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(new Vector3(horizontalSpeed,0,0));
        if(Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(new Vector3(0,0,-verticalSpeed));
        if(Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(new Vector3(0,jumpSpeed,0));
    }
}
