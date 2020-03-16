using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float verticalSpeed;
    public float horizontalSpeed;
    public float jumpSpeed;

    private MeshRenderer mr;
    public Light luzExterna;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            mr.enabled = false;
        if (Input.GetKeyDown(KeyCode.U))
            mr.enabled = true;
        
/*        if (Input.GetKeyDown(KeyCode.Y))
            luzExterna.color = Color.red;
        if (Input.GetKeyDown(KeyCode.U))
            luzExterna.color = Color.blue; */
        
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
