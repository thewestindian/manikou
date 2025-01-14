using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 25.0f;
    // Unused variable from Unity Learn exemple. Doesn't apply to 2D
    // private float turnSpeed = 45.0f;
    private float horizontalInput;
    // DON'T WANT UPWARD
    //private float verticalInput;
    public float xRange = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keep the player inbounds
        if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
        if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

        // This where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        //DON'T WANT UPWARD
        //verticalInput = Input.GetAxis("Vertical");

        //We move the vehicle UPWARD
        //transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);
        //We turn the vehicle
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
    }
}