using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinPropellorX : MonoBehaviour
{
    private float rotationSpeed = 500000000.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around its local forward axis (Z-axis).
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
