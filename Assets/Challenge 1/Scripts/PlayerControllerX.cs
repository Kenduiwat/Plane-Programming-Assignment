using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float forwardSpeed = 20.0f; // Adjust the forward movement speed.
    private float rotationSpeed = 45.0f; // Adjust the rotation speed.
    //public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward and backward based on horizontal input.
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);

        // Rotate the plane along the X-axis (pitch) based on vertical input.
        float pitch = transform.eulerAngles.x + (-rotationSpeed * Time.deltaTime * verticalInput);
        transform.eulerAngles = new Vector3(pitch, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
