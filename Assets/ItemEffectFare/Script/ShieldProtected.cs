using UnityEngine;
using PhEngine.Core;

namespace SuperGame
{
    public class ShieldProtected : Singleton<ShieldProtected>
{
    [SerializeField] GameObject ShieldAura;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.CompareTag("Obstacle"))//เมื่อชนอุปสรรคแล้วหาย
        {
            Destroy(other.gameObject);
            Destroy(ShieldAura.gameObject);
            Debug.Log("ติดเว้ย");
        }

    }
    protected override void InitAfterAwake()
    {
        
    } 
}
}

