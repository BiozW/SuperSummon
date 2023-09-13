using PhEngine.Core;
using UnityEngine;

namespace SuperGame
{
    public class DifficultyManager : Singleton<DifficultyManager>
    {
        public int DifficultyLevel => difficultyLevel;
        //public ItemSpawner itemSpawner;
        //public ShieldSpawner shieldSpawner;
        //public PoisonSpawner poisonSpawner;
        [SerializeField] int difficultyLevel;
        [SerializeField] GameObject difficultyUI;
        
        protected override void InitAfterAwake()
        {
            difficultyUI.SetActive(true);
        }

        public void SelectDifficultyLevel(int value)
        {
            difficultyLevel = value;
            difficultyUI.SetActive(false);
            GameManager.Instance.StartLevel();
            
            /*float heartSpawn = GetComponent<itemSpawner>().heartSpawnRate;
            float shieldSpawn = GetComponent<shieldSpawner>().sheildSpawnRate;
            float poisonSpawn = GetComponent<poisonSpawner>().poisonSpawnRate;*/

            if(difficultyLevel == 1)
            {
                /*heartSpawn = 2f;
                shieldSpawn = 2f;
                poisonSpawn = 0f;*/
            }

            if(difficultyLevel == 2)
            {
                /*heartSpawn = 1f;
                shieldSpawn = 1f;
                posionSpawn = 1f;*/
            }

            if(difficultyLevel == 3)
            {
                /*heartSpawn = 0f;
                sheildSpawn = 0f;
                poisonSpawn = 3f;*/
            }
        }
    }
}