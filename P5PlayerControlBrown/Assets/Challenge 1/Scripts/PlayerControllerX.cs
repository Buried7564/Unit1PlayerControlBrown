using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 150.0f;
    public float verticalInput;
    public float horizontalInput;
    public float forwardInput;
  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's Horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        transform.Rotate(Vector3.left, turnSpeed * verticalInput * Time.deltaTime);
    }
}
