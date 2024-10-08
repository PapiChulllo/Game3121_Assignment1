using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f;          // Forward speed
    public float verticalSpeed = 5f;   // Up/Down speed

    // Update is called once per frame
    void Update()
    {
        // Move the plane forward at a constant speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Check for player input (W/S keys) for vertical movement
        if (Input.GetKey(KeyCode.W))
        {
            // Move up
            transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // Move down
            transform.Translate(Vector3.down * verticalSpeed * Time.deltaTime);
        }
    }
}
