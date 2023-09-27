using UnityEngine;
public class CpuBridgeScript : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject alienFull;
    public UnityEngine.GameObject alienOuterEmpty;
    public UnityEngine.GameObject alienInnerEmpty;
    
    // Methods
    private void Start()
    {
    
    }
    public void changeAlienSign(int i)
    {
        UnityEngine.GameObject val_1;
        var val_2;
        if(i == 0)
        {
            goto label_0;
        }
        
        this.alienFull.SetActive(value:  false);
        this.alienOuterEmpty.SetActive(value:  false);
        val_1 = this.alienInnerEmpty;
        if(i != 1)
        {
            goto label_8;
        }
        
        val_2 = 1;
        goto label_5;
        label_0:
        this.alienFull.SetActive(value:  false);
        this.alienOuterEmpty.SetActive(value:  true);
        val_1 = this.alienInnerEmpty;
        label_8:
        val_2 = 0;
        label_5:
        val_1.SetActive(value:  false);
    }
    public CpuBridgeScript()
    {
    
    }

}
