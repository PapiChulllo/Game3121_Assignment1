using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30.0f;
    private float bottomLimit = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit && this.CompareTag("Dog"))
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit && this.CompareTag("Ball"))
        {
            Destroy(gameObject);
            Debug.Log("Game Over!!!");
        }

    }
}
