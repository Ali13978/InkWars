using UnityEngine;
public class RatioSpriteSwapper : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Image currentImage;
    private UnityEngine.Sprite Ratio16by9;
    private UnityEngine.Sprite Ratio4by3;
    
    // Methods
    private void Start()
    {
        UnityEngine.UI.Image val_5;
        UnityEngine.Sprite val_6;
        if((double)UnityEngine.Camera.main.aspect >= 1.7)
        {
            goto label_1;
        }
        
        if(UnityEngine.Camera.main.aspect >= 1.5f)
        {
                return;
        }
        
        val_5 = this.currentImage;
        val_6 = this.Ratio4by3;
        if(val_5 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_1:
        val_5 = this.currentImage;
        val_6 = this.Ratio16by9;
        if(val_5 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        val_5.sprite = val_6;
    }
    public void forceSwap()
    {
        UnityEngine.UI.Image val_5;
        UnityEngine.Sprite val_6;
        if((double)UnityEngine.Camera.main.aspect >= 1.7)
        {
            goto label_1;
        }
        
        if(UnityEngine.Camera.main.aspect >= 1.5f)
        {
                return;
        }
        
        val_5 = this.currentImage;
        val_6 = this.Ratio4by3;
        if(val_5 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_1:
        val_5 = this.currentImage;
        val_6 = this.Ratio16by9;
        if(val_5 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        val_5.sprite = val_6;
    }
    public RatioSpriteSwapper()
    {
    
    }

}
