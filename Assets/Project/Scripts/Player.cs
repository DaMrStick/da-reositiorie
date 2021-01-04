using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 10.0f;
    public Rigidbody rb;
    public float thrust = 3;
    public bool IsJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        Move();
        //jump
        if (rb.velocity == new Vector3 (0f,0f,0f))
        {
            IsJumping = false;
        }
        if (Input.GetKeyDown("space") == true && IsJumping == false)
        {
            rb.AddForce(Vector3.up * thrust * 100);
            IsJumping = true;
        }
        //rotatetion here
        transform.Rotate(0f,Input.GetAxis("Mouse X")*2,0f);
    }
    void FixedUpdate()
    {
    }
    void Move()
    {
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position += transform.forward *-1 * Speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += transform.right *-1 * Speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += transform.right * Speed * Time.deltaTime;
        }
    }
}
