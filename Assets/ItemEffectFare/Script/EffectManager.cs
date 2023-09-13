using UnityEngine;
using PhEngine.Core;

public class EffectManager : Singleton<EffectManager>
{
    [SerializeField] GameObject HeartItem;
    [SerializeField] GameObject ShieldItem;
    [SerializeField] GameObject PoisonItem; 

    protected override void InitAfterAwake()
    {
            
    }
    // Update is called once per frame
    public void Update()
    {
        
    }
}
