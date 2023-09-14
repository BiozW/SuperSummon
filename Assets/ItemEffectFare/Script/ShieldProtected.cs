using UnityEngine;
using PhEngine.Core;

namespace SuperGame
{
    public class ShieldProtected : Singleton<ShieldProtected>
{
    [SerializeField] GameObject ShieldAura;
    private void OnTriggerEnter2D(Collider2D Shielded) 
    {
        
        if(Shielded.CompareTag("Obstacle"))//เมื่อชนอุปสรรคแล้วหาย
        {
            Destroy(Shielded.gameObject);
            Destroy(ShieldAura.gameObject);
            Debug.Log("ติดเว้ย");
        }

    }
    protected override void InitAfterAwake()
    {
        
    } 
}
}

