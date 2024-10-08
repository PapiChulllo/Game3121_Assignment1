using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 1.0f;

    private int randomBallPrefabIndex;

    void Start()
    {
        StartCoroutine(SpawnRandomBall(startDelay)); // Start a coroutine with a start delay
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBall(float spawnIntval)
    {

        yield return new WaitForSeconds(spawnIntval); // Wait until this seconds before spawning a random ball

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Get random number for index at ball prefab array
        randomBallPrefabIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBallPrefabIndex], spawnPos, ballPrefabs[randomBallPrefabIndex].transform.rotation);

        spawnInterval = Random.Range(3.0f, 5.0f); // Get a random number from 3 to 5 for spawnInterval after spawning each ball

        StartCoroutine(SpawnRandomBall(spawnInterval)); // Start a new coroutine with new interval
    }

}
