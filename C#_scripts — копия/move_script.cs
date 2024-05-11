using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_script : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotationSpeed = 200f;
    public float jumpForce = 5f;
    public float maxSpeed = 3f;
    public bool isGrounded; 
    private Rigidbody rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision) 
    {
        isGrounded = true;
    }

    
    void Update()
    {
        
        if (transform.eulerAngles.z < 0 || transform.eulerAngles.z > 0 || transform.eulerAngles.x < 0 || transform.eulerAngles.x > 0)
        {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * Input.GetAxis("Mouse X"));
        transform.Translate(Vector3.forward * Time.deltaTime * maxSpeed * Input.GetAxis("Fire3"));

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
        }
    }
}