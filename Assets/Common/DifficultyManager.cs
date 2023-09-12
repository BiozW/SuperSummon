using PhEngine.Core;
using UnityEngine;
using UnityEngine.UI;

namespace SuperGame
{
    public class DifficultyManager : Singleton<DifficultyManager>
    {
        public int DifficultyLevel => difficultyLevel;
        [SerializeField] int difficultyLevel;
        [SerializeField] GameObject difficultyUI;
        [SerializeField] Button easyButton;
        [SerializeField] Button mediumButton;
        [SerializeField] Button hardButton;
        
        protected override void InitAfterAwake()
        {
            difficultyUI.SetActive(true);
            Button easy = easyButton.GetComponent<Button>();
            Button medium = mediumButton.GetComponent<Button>();
            Button hard = hardButton.GetComponent<Button>();

            easy.onClick.AddListener(Easy);
            medium.onClick.AddListener(Medium);
            hard.onClick.AddListener(Hard);
        }

        public void Easy()
        {
            Debug.Log("Easy Easy.");
            difficultyLevel = 1;
            difficultyUI.SetActive(false);
        }

        public void Medium()
        {
            Debug.Log("Medium then.");
            difficultyLevel = 2;
            difficultyUI.SetActive(false);
        }

        public void Hard()
        {
            Debug.Log("Hard it is.");
            difficultyLevel = 3;
            difficultyUI.SetActive(false);
        }

        public void SelectDifficultyLevel(int value)
        {
            difficultyLevel = value;
            //difficultyUI.SetActive(false);
            GameManager.Instance.StartLevel();
        }
    }
}