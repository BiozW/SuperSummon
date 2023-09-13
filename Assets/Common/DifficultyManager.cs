using PhEngine.Core;
using UnityEngine;

namespace SuperGame
{
    public class DifficultyManager : Singleton<DifficultyManager>
    {
        public int DifficultyLevel => difficultyLevel;
        [SerializeField] int difficultyLevel;
        [SerializeField] GameObject difficultyUI;

        [Header("Spawner")]
        public GameObject HeartSpawner;
        public GameObject ShieldSpawner;
        public GameObject PoisonSpawner;
        
        /*public float heartSpawn = 1.0f;
        public float shieldSpawn = 1.0f;
        public float poisonSpawn = 1.0f;*/
        
        protected override void InitAfterAwake()
        {
            difficultyUI.SetActive(true);
        }

        public void SelectDifficultyLevel(int value)
        {
            difficultyLevel = value;
            difficultyUI.SetActive(false);
            GameManager.Instance.StartLevel();

            if(difficultyLevel == 1)
            {
                /*heartSpawn = 10f / 1f;
                shieldSpawn = 10f / 1f;
                Destroy(PoisonSpawner);*/
            }

            if(difficultyLevel == 2)
            {
                /*heartSpawn = 10f / 1f;
                shieldSpawn = 10f / 1f;
                poisonSpawn = 10f / 1f;*/
            }

            if(difficultyLevel == 3)
            {
                /*Destroy(HeartSpawner);
                Destroy(ShieldSpawner);
                poisonSpawn = 10f / 3f;*/
            }
        }
    }
}