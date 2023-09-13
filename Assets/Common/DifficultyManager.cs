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

        [Header("Divider")]
        public float DividendLv1 = 10f;
        public float DividendLv2 = 10f;
        public float DividendLv3 = 10f;
        public float DiviorLv1 = 1f;
        public float DiviorLv2 = 1f;
        public float DiviorLv3 = 1f;
        
        public float heartSpawn = 1.0f;
        public float shieldSpawn = 1.0f;
        public float poisonSpawn = 1.0f;
        
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
                heartSpawn = DividendLv1 / DiviorLv1;
                shieldSpawn = DividendLv2 / DiviorLv2;
                Destroy(PoisonSpawner);
            }

            if(difficultyLevel == 2)
            {
                heartSpawn = DividendLv2 / DiviorLv2;
                shieldSpawn = DividendLv2 / DiviorLv2;
                poisonSpawn = DividendLv2 / DiviorLv2;
            }

            if(difficultyLevel == 3)
            {
                Destroy(HeartSpawner);
                Destroy(ShieldSpawner);
                poisonSpawn = DividendLv3 / DiviorLv3;
            }
        }
    }
}