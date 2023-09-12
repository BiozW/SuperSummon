using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] float heartSpawnRate = 1.0f;
    [SerializeField] float shieldSpawnRate = 1.0f;
    [SerializeField] float poisonSpawnRate = 1.0f;
    
    public float minH = -1f;
    public float maxH = 1f;
    public GameObject heartSpawn; // Array of item prefabs to spawn.
    public GameObject shieldSpawn; // Array of item prefabs to spawn.
    public GameObject poisonSpawn; // Array of item prefabs to spawn.
    public Transform spawnPoint; // The position where items will spawn.
    public float spawnInterval = 2.0f; // Time interval between spawns.
    
    private float timeSinceLastSpawn = 0.0f;

    private void Update()
    {

    }

    private void SpawnRandomItem()
    {
    }

    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnHeart), heartSpawnRate, heartSpawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnHeart));
    }

    private void SpawnHeart()
    {
        GameObject pipes = Instantiate(heartSpawn, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minH, maxH);
    }
}

