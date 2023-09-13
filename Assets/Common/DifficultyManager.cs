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
        [SerializeField] GameObject ItemSpawner;
        [SerializeField] GameObject ShieldSpawner;
        [SerializeField] GameObject PoisonSpawner;
        
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
                /*heartSpawn = 2f;
                shieldSpawn = 2f;
                Destroy(PoisonSpawner);*/
            }

            if(difficultyLevel == 2)
            {
                /*heartSpawn = 1f;
                shieldSpawn = 1f;
                posionSpawn = 1f;*/
            }

            if(difficultyLevel == 3)
            {
                /*Destroy(ItemSpawner);
                Destroy(ShieldSpawner);
                poisonSpawn = 3f;*/
            }
        }
    }
}