using PhEngine.Core;
using UnityEngine;

namespace SuperGame
{
    public class HeartSpawner : Singleton<HeartSpawner>
    {
        public float heartSpawnRate = 1.0f;
    
        public float minH = -1f;
        public float maxH = 1f;
        public GameObject heartSpawn; // Array of item prefabs to spawn.

        //public DifficultyManager difficultyManager;

        public bool waterfall = false;

        protected override void InitAfterAwake()
        {

        }
        private void Update()
        {
            //heartSpawnRate = difficultyManager.heartSpawn;
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


