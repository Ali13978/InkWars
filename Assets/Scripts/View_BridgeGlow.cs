using UnityEngine;
public class View_BridgeGlow : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject Glow_Full;
    public UnityEngine.GameObject Glow_OuterEmpty;
    public UnityEngine.GameObject Glow_InnerEmpty;
    
    // Methods
    private void Awake()
    {
        this.Glow_Full.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 3;
        this.Glow_OuterEmpty.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 3;
        this.Glow_InnerEmpty.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 3;
    }
    public void ChangeGlow(BridgeGlowState state)
    {
        this.Glow_Full.SetActive(value:  false);
        this.Glow_OuterEmpty.SetActive(value:  false);
        this.Glow_InnerEmpty.SetActive(value:  false);
        if(state == 2)
        {
            goto label_3;
        }
        
        if(state == 1)
        {
            goto label_4;
        }
        
        if(state != 0)
        {
                return;
        }
        
        if(this.Glow_Full != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        this.Glow_Full.SetActive(value:  true);
        return;
        label_3:
        if(this.Glow_InnerEmpty != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_4:
        if(this.Glow_OuterEmpty != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    public View_BridgeGlow()
    {
    
    }

}
