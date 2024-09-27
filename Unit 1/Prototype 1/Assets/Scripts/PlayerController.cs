using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 15.0f;
    private float turnSpeed = 45.0f;
    private float horiztonalInput;
    private float fowardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horiztonalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        // Moves the vehicle foward based on verticle input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horiztonalInput);
    }
}
