using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhEngine.Core;

namespace SuperGame
{
    public class HeartEffect : Singleton<HeartEffect>
    {
        private void OnTriggerEnter2D(Collider2D other) 
        {
            
            if(other.CompareTag("Player"))
            {
                if(GameManager.Instance.GetLifeCount() < GameManager.Instance.GetMaxLifeCount()) 
                {
                    GameManager.Instance.AddLifeCount();
                    Debug.Log("Healed");
                    Destroy(other.gameObject); //เก็บแล้วitemหายไป
            
                }
            }
        }
        protected override void InitAfterAwake()
        {
        
        }
        
    }

}
