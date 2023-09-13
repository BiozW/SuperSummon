using System.Collections;
using System.Collections.Generic;
using PhEngine.Core;
using UnityEngine;

namespace SuperGame
{
    public class ShieldSpawner : Singleton<ShieldSpawner>
    {
        public float sheildSpawnRate = 1.0f;
        public bool waterfall = false;

        public float minH = -1f;
        public float maxH = 1f;
        public DifficultyManager difficultyManager;
        public GameObject shieldSpawn; // Array of item prefabs to spawn.
        protected override void InitAfterAwake()
        {
            
        }

        private void Update()
        {
            sheildSpawnRate = difficultyManager.shieldSpawn;
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
            GameObject shield = Instantiate(shieldSpawn, transform.position, Quaternion.identity);
            shield.transform.position += Vector3.up * Random.Range(minH, maxH);
        }
    }
}


