using UnityEngine;
public class View_BridgeManager : MonoBehaviour
{
    // Fields
    public View_Whirlpool InnerWhirlPool;
    public View_Whirlpool MiddleWhirlPool;
    public View_Whirlpool OuterWhirlPool;
    public View_BridgeGlow BridgeGlow;
    
    // Methods
    public void TriggerWhirlEffect()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.InnerWhirlPool.TriggerWhirlEffect());
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.MiddleWhirlPool.TriggerWhirlEffect());
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.OuterWhirlPool.TriggerWhirlEffect());
    }
    public void UpdateGlow()
    {
        if(this.MiddleWhirlPool.RingEmpty == false)
        {
            goto label_1;
        }
        
        label_6:
        label_24:
        label_20:
        this.BridgeGlow.ChangeGlow(state:  3);
        return;
        label_1:
        if(this.InnerWhirlPool.RingEmpty != false)
        {
                if(this.OuterWhirlPool.RingEmpty == true)
        {
            goto label_6;
        }
        
        }
        
        if((this.InnerWhirlPool.RingEmpty != false) && (this.MiddleWhirlPool.RingEmpty != true))
        {
                if(this.OuterWhirlPool.RingEmpty == false)
        {
            goto label_12;
        }
        
        }
        
        if((this.OuterWhirlPool.RingEmpty != false) && (this.MiddleWhirlPool.RingEmpty != true))
        {
                if(this.InnerWhirlPool.RingEmpty == false)
        {
            goto label_18;
        }
        
        }
        
        if(this.BridgeGlow != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_12:
        if(this.BridgeGlow != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_18:
        if(this.BridgeGlow != null)
        {
            goto label_24;
        }
        
        goto label_24;
    }
    public View_BridgeManager()
    {
    
    }

}
