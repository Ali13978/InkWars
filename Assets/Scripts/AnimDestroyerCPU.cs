using UnityEngine;
public class AnimDestroyerCPU : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator anim;
    public UnityEngine.GameObject[] particleEffectChild;
    
    // Methods
    private void Start()
    {
        var val_29;
        this.anim = this.gameObject.GetComponent<UnityEngine.Animator>();
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_3.m_Handle.name, b:  "PlaySceneVs")) != false)
        {
                val_29 = 1152921505080061952;
        }
        else
        {
                val_29 = 1152921505079476224;
        }
        
        if(((((System.String.Equals(a:  TargetBallCPU.popTag, b:  "Red")) != true) && ((System.String.Equals(a:  TargetBallCPU.popTag, b:  "Blue")) != true)) && ((System.String.Equals(a:  TargetBallCPU.popTag, b:  "Green")) != true)) && ((System.String.Equals(a:  TargetBallCPU.popTag, b:  "Yellow")) != true))
        {
                if((System.String.Equals(a:  TargetBallCPU.popTag, b:  "Orange")) != true)
        {
                if((System.String.Equals(a:  TargetBallCPU.popTag, b:  "Purple")) == false)
        {
            goto label_11;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_12 = this.particleEffectChild[0].GetComponent<SeventyOneSquared.PDUnity>();
        val_12.Running = true;
        UnityEngine.GameObject val_30 = this.particleEffectChild[0];
        if(val_30 != null)
        {
            goto label_67;
        }
        
        label_68:
        label_67:
        val_30.SetActive(value:  true);
        label_70:
        UnityEngine.Coroutine val_13 = this.StartCoroutine(methodName:  "DestroyAnim");
        return;
        label_11:
        if(((((System.String.Equals(a:  TargetBallCPU.popTag, b:  "RedExtended")) != true) && ((System.String.Equals(a:  TargetBallCPU.popTag, b:  "BlueExtended")) != true)) && ((System.String.Equals(a:  TargetBallCPU.popTag, b:  "GreenExtended")) != true)) && ((System.String.Equals(a:  TargetBallCPU.popTag, b:  "YellowExtended")) != true))
        {
                if((System.String.Equals(a:  TargetBallCPU.popTag, b:  "OrangeExtended")) != true)
        {
                if((System.String.Equals(a:  TargetBallCPU.popTag, b:  "PurpleExtended")) == false)
        {
            goto label_24;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_20 = this.particleEffectChild[5].GetComponent<SeventyOneSquared.PDUnity>();
        val_20.Running = true;
        if(this.particleEffectChild[5] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_24:
        if((System.String.Equals(a:  TargetBallCPU.popTag, b:  "Iron_Ball")) == false)
        {
            goto label_33;
        }
        
        SeventyOneSquared.PDUnity val_22 = this.particleEffectChild[3].GetComponent<SeventyOneSquared.PDUnity>();
        val_22.Running = true;
        if(this.particleEffectChild[3] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_33:
        if((System.String.Equals(a:  TargetBallCPU.popTag, b:  "Rainbow_Bubble")) == false)
        {
            goto label_42;
        }
        
        SeventyOneSquared.PDUnity val_24 = this.particleEffectChild[1].GetComponent<SeventyOneSquared.PDUnity>();
        val_24.Running = true;
        if(this.particleEffectChild[1] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_42:
        if((System.String.Equals(a:  TargetBallCPU.popTag, b:  "Color_Eraser_Ball")) == false)
        {
            goto label_51;
        }
        
        SeventyOneSquared.PDUnity val_26 = this.particleEffectChild[2].GetComponent<SeventyOneSquared.PDUnity>();
        val_26.Running = true;
        if(this.particleEffectChild[2] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_51:
        if((System.String.Equals(a:  TargetBallCPU.popTag, b:  "TrashPop")) == false)
        {
            goto label_60;
        }
        
        SeventyOneSquared.PDUnity val_28 = this.particleEffectChild[6].GetComponent<SeventyOneSquared.PDUnity>();
        val_28.Running = true;
        if(this.particleEffectChild[6] != null)
        {
            goto label_67;
        }
        
        goto label_68;
        label_60:
        this.anim.Play(stateName:  TargetBallCPU.popTag, layer:  0, normalizedTime:  0f);
        goto label_70;
    }
    private System.Collections.IEnumerator DestroyAnim()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new AnimDestroyerCPU.<DestroyAnim>d__3();
    }
    public AnimDestroyerCPU()
    {
    
    }

}
