using PhEngine.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SuperGame
{
    
    public class PoisonSpawner : MonoBehaviour 
{
    public float poisonSpawnRate = 1.0f;
    public bool waterfall = false;
    
    public float minH = -1f;
    public float maxH = 1f;
    public GameObject poisonSpawn; // Array of item prefabs to spawn.
    

    private void Update()
    {
        if (waterfall == true)
        {
            OnEnable();
        }
    }


    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnPoison), poisonSpawnRate, poisonSpawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnPoison));
    }

    private void SpawnPoison()
    {
        GameObject pipes = Instantiate(poisonSpawn, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minH, maxH);
    }
}
}

