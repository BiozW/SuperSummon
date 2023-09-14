using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhEngine.Core;
using TMPro;

namespace SuperGame
{
        public class PoisonEffect : Singleton<PoisonEffect>
    {
        public GameObject PoisonUI;
        [SerializeField] TextMeshProUGUI PoisoningTimer;
        [SerializeField] public bool isPoisoning;
        
        private IEnumerator PoisonCountdown()
        {
            PoisonUI.SetActive(true); isPoisoning = true;
            float timer = 3;

            while (timer > 0)
            {
                PoisoningTimer.text="Poison: " + timer.ToString("F1");
                yield return new WaitForSeconds(1f); // Wait for 1 second
                timer -= 1f;
            }
            PoisonUI.SetActive(false); isPoisoning = false;
        }
        private void OnTriggerEnter2D(Collider2D Poison) 
        {
            if(Poison.CompareTag("Player"))
            {
            StartCoroutine(PoisonCountdown());
            Destroy(Poison.gameObject); //เก็บแล้วitemหายไป
            
            }
            
            
        }
        protected override void InitAfterAwake()
        {
        
        }
    }
}

