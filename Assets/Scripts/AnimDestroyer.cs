using UnityEngine;
public class AnimDestroyer : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator anim;
    public UnityEngine.GameObject[] particleEffectChild;
    
    // Methods
    private void Start()
    {
        var val_27;
        this.anim = this.gameObject.GetComponent<UnityEngine.Animator>();
        if(InstanceAnimator.IsTutorialLevel != false)
        {
                val_27 = 1152921505144279040;
        }
        else
        {
                val_27 = 1152921505079742464;
        }
        
        if(((((System.String.Equals(a:  TargetBallScript.popTag, b:  "Red")) != true) && ((System.String.Equals(a:  TargetBallScript.popTag, b:  "Blue")) != true)) && ((System.String.Equals(a:  TargetBallScript.popTag, b:  "Green")) != true)) && ((System.String.Equals(a:  TargetBallScript.popTag, b:  "Yellow")) != true))
        {
                if((System.String.Equals(a:  TargetBallScript.popTag, b:  "Orange")) != true)
        {
                if((System.String.Equals(a:  TargetBallScript.popTag, b:  "Purple")) == false)
        {
            goto label_11;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_10 = this.particleEffectChild[0].GetComponent<SeventyOneSquared.PDUnity>();
        val_10.Running = true;
        UnityEngine.GameObject val_28 = this.particleEffectChild[0];
        if(val_28 != null)
        {
            goto label_67;
        }
        
        label_68:
        label_67:
        val_28.SetActive(value:  true);
        label_70:
        UnityEngine.Coroutine val_11 = this.StartCoroutine(methodName:  "DestroyAnim");
        return;
        label_11:
        if(((((System.String.Equals(a:  TargetBallScript.popTag, b:  "RedExtended")) != true) && ((System.String.Equals(a:  TargetBallScript.popTag, b:  "BlueExtended")) != true)) && ((System.String.Equals(a:  TargetBallScript.popTag, b:  "GreenExtended")) != true)) && ((System.String.Equals(a:  TargetBallScript.popTag, b:  "YellowExtended")) != true))
        {
                if((System.String.Equals(a:  TargetBallScript.popTag, b:  "OrangeExtended")) != true)
        {
                if((System.String.Equals(a:  TargetBallScript.popTag, b:  "PurpleExtended")) == false)
        {
            goto label_24;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_18 = this.particleEffectChild[5].GetComponent<SeventyOneSquared.PDUnity>();
        val_18.Running = true;
        if(this.particleEffectChild[5] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_24:
        if((System.String.Equals(a:  TargetBallScript.popTag, b:  "Iron_Ball")) == false)
        {
            goto label_33;
        }
        
        SeventyOneSquared.PDUnity val_20 = this.particleEffectChild[3].GetComponent<SeventyOneSquared.PDUnity>();
        val_20.Running = true;
        if(this.particleEffectChild[3] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_33:
        if((System.String.Equals(a:  TargetBallScript.popTag, b:  "Rainbow_Bubble")) == false)
        {
            goto label_42;
        }
        
        SeventyOneSquared.PDUnity val_22 = this.particleEffectChild[1].GetComponent<SeventyOneSquared.PDUnity>();
        val_22.Running = true;
        if(this.particleEffectChild[1] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_42:
        if((System.String.Equals(a:  TargetBallScript.popTag, b:  "Color_Eraser_Ball")) == false)
        {
            goto label_51;
        }
        
        SeventyOneSquared.PDUnity val_24 = this.particleEffectChild[2].GetComponent<SeventyOneSquared.PDUnity>();
        val_24.Running = true;
        if(this.particleEffectChild[2] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_51:
        if((System.String.Equals(a:  TargetBallScript.popTag, b:  "TrashPop")) == false)
        {
            goto label_60;
        }
        
        SeventyOneSquared.PDUnity val_26 = this.particleEffectChild[6].GetComponent<SeventyOneSquared.PDUnity>();
        val_26.Running = true;
        if(this.particleEffectChild[6] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_60:
        this.anim.Play(stateName:  TargetBallScript.popTag, layer:  0, normalizedTime:  0f);
        goto label_70;
    }
    private System.Collections.IEnumerator DestroyAnim()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new AnimDestroyer.<DestroyAnim>d__3();
    }
    public AnimDestroyer()
    {
    
    }

}
