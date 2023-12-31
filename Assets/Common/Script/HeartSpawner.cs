using PhEngine.Core;
using UnityEngine;

namespace SuperGame
{
    public class HeartSpawner : Singleton<HeartSpawner>
    {
        public float heartSpawnRate = 1.0f;
        public bool waterfall = false;
        public float minH = -1f;
        public float maxH = 1f;
        public DifficultyManager difficultyManager;
        public GameObject heartSpawn; // Array of item prefabs to spawn.


        protected override void InitAfterAwake()
        {

        }
        private void Update()
        {
            heartSpawnRate = difficultyManager.heartSpawn;
            if (waterfall == true)
            {
                OnEnable();
            }
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
            GameObject heart = Instantiate(heartSpawn, transform.position, Quaternion.identity);
            heart.transform.position += Vector3.up * Random.Range(minH, maxH);
        }
    }
}


