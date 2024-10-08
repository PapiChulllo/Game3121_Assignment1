using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;  // The obstacle prefab to spawn
    public float spawnRate = 2f;       // How often to spawn obstacles
    public float obstacleSpeed = 5f;   // How fast obstacles move towards the plane
    public float heightRange = 5f;     // How high/low obstacles can appear

    private float timer;

    void Update()
    {
        // Spawn obstacles at intervals
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        // Generate a random Y position for the obstacle
        float randomY = Random.Range(-heightRange, heightRange);

        // Instantiate the obstacle at a random height, moving towards the player
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);
        GameObject newObstacle = Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);

        // Add movement to the obstacle
        newObstacle.GetComponent<Rigidbody>().velocity = Vector3.back * obstacleSpeed;
    }
}
