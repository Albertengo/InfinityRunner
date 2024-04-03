using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ 
    public float speed = 1.0f;
    private Rigidbody rb;
    public float jumpHeight = 1.0f;
    public bool isGrounded;


    private void Start()
    {
       rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)) {
        
                rb.AddForce(Vector3.up * jumpHeight);
                Debug.Log("Estas saltando");
            }
            Debug.Log("Estas en el piso");
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        movement.Normalize();

        transform.Translate(movement * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            Debug.Log("Grounded es TRUE");
        }
        else
            isGrounded = false;
    }

}
