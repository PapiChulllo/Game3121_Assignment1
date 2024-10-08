using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastSpawnTime;
    private float spawnCooldown;

    private void Awake()
    {
        spawnCooldown = 2.0f; // Player can spawn new dog every 2 seconds
        lastSpawnTime = -3.0f; // Initialized to something negative to enable the player first spawn
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)) // Get input if space pressed
        {
            if ((Time.time - lastSpawnTime) > spawnCooldown) // Check if enough time elapsed after last spawn
            {
                SpawnDog(); // Spawn the dog
            }
        }
    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation); // Spawn the dog using its prefab
        lastSpawnTime = Time.time; // Reset the last spawn time for cooldown
    }
}
