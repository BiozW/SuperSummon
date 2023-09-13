using PhEngine.Core;
using UnityEngine;

namespace SuperGame
{
    public class DifficultyManager : Singleton<DifficultyManager>
    {
        public int DifficultyLevel => difficultyLevel;
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

            if(difficultyLevel == 1)
            {
                GetComponent<HeartSpawner>().heartSpawnRate = 2f;
                GetComponent<ShieldSpawner>().sheildSpawnRate = 1f;
                GetComponent<PoisonSpawner>().poisonSpawnRate = 0f;
            }

            if(difficultyLevel == 2)
            {
                /*GetComponent<itemSpawner>().heartSpawnRate = 1f;
                GetComponent<itemSpawner>().sheildSpawnRate = 1f;
                GetComponent<itemSpawner>().poisonSpawnRate = 1f;*/
            }

            if(difficultyLevel == 3)
            {
                /*GetComponent<itemSpawner>().heartSpawnRate = 0f;
                GetComponent<itemSpawner>().sheildSpawnRate = 0f;
                GetComponent<itemSpawner>().poisonSpawnRate = 3f;*/
            }
        }
    }
}