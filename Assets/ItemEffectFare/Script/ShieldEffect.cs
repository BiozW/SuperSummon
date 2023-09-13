using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhEngine.Core;

namespace SuperGame
{
    public class ShieldEffect : Singleton<ShieldEffect>
    {
        [SerializeField] GameObject Armor;
        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.CompareTag("Player"))//เก็บเกราะกะplayer
            {
                Vector3 spawnPosition = new Vector3(-100, transform.position.y, transform.position.z);
                Instantiate(Armor, spawnPosition, Quaternion.identity);
                Debug.Log("Shield Collected");
                
            }
            
        }
        protected override void InitAfterAwake()
        {
        
        } 
    }
    
}

