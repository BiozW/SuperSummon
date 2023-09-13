using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSpawner : MonoBehaviour
{
    public float sheildSpawnRate = 1.0f;
    public bool waterfall = false;
    
    public float minH = -1f;
    public float maxH = 1f;
    public GameObject shieldSpawn; // Array of item prefabs to spawn.
    

    private void Update()
    {
        if (waterfall == true)
        {
            OnEnable();
        }
    }


    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnSheild), sheildSpawnRate, sheildSpawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnSheild));
    }

    private void SpawnSheild()
    {
        GameObject pipes = Instantiate(shieldSpawn, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minH, maxH);
    }
}