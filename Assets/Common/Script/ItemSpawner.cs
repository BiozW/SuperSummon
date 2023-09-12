using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public int heartSpawnRate = 0;
    public int shieldSpawnRate = 0;
    public int poisonSpawnRate = 0;
    public GameObject[] heartToSpawn; // Array of item prefabs to spawn.
    public GameObject[] shieldToSpawn; // Array of item prefabs to spawn.
    public GameObject[] poisonToSpawn; // Array of item prefabs to spawn.
    public Transform spawnPoint; // The position where items will spawn.
    public float spawnInterval = 2.0f; // Time interval between spawns.
    
    private float timeSinceLastSpawn = 0.0f;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        // Check if it's time to spawn a new item.
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnRandomItem();
            timeSinceLastSpawn = 0.0f;
        }
    }

    private void SpawnRandomItem()
    {
        // Pick a random item prefab from the array.
        int randomIndex = Random.Range(0, itemsToSpawn.Length);
        GameObject itemPrefab = itemsToSpawn[randomIndex];

        // Instantiate the chosen item prefab at the spawnPoint's position.
        Instantiate(itemPrefab, spawnPoint.position, Quaternion.identity);
    }
}

