using UnityEngine;
public class PlayerAnimDestroyer : MonoBehaviour
{
    // Fields
    public string overrideAnimation;
    private UnityEngine.Animator anim;
    public UnityEngine.GameObject[] particleEffectChild;
    
    // Methods
    public void Start()
    {
        string val_28;
        var val_29;
        var val_30;
        var val_32;
        val_28 = " ";
        this.anim = this.gameObject.GetComponent<UnityEngine.Animator>();
        if(InstanceAnimator.IsTutorialLevel == false)
        {
            goto label_4;
        }
        
        val_29 = null;
        val_29 = null;
        if(DemoManager.flagForDestroyAnim == false)
        {
            goto label_7;
        }
        
        label_4:
        val_30 = null;
        val_30 = null;
        if(LineController.flagForDestroyBallsAnim == true)
        {
            goto label_10;
        }
        
        val_32 = 1152921505075646480;
        goto label_13;
        label_7:
        val_32 = 1152921505070215192;
        label_13:
        label_10:
        if((System.String.IsNullOrEmpty(value:  this.overrideAnimation)) != true)
        {
                val_28 = this.overrideAnimation;
        }
        
        if(((((System.String.Equals(a:  val_28, b:  "Red")) != true) && ((System.String.Equals(a:  val_28, b:  "Blue")) != true)) && ((System.String.Equals(a:  val_28, b:  "Green")) != true)) && ((System.String.Equals(a:  val_28, b:  "Yellow")) != true))
        {
                if((System.String.Equals(a:  val_28, b:  "Orange")) != true)
        {
                if((System.String.Equals(a:  val_28, b:  "Purple")) == false)
        {
            goto label_20;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_11 = this.particleEffectChild[0].GetComponent<SeventyOneSquared.PDUnity>();
        val_11.Running = true;
        UnityEngine.GameObject val_29 = this.particleEffectChild[0];
        if(val_29 != null)
        {
            goto label_76;
        }
        
        label_77:
        label_76:
        val_29.SetActive(value:  true);
        label_79:
        UnityEngine.Coroutine val_12 = this.StartCoroutine(methodName:  "DestroyAnim");
        return;
        label_20:
        if(((((System.String.Equals(a:  val_28, b:  "RedExtended")) != true) && ((System.String.Equals(a:  val_28, b:  "BlueExtended")) != true)) && ((System.String.Equals(a:  val_28, b:  "GreenExtended")) != true)) && ((System.String.Equals(a:  val_28, b:  "YellowExtended")) != true))
        {
                if((System.String.Equals(a:  val_28, b:  "OrangeExtended")) != true)
        {
                if((System.String.Equals(a:  val_28, b:  "PurpleExtended")) == false)
        {
            goto label_33;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_19 = this.particleEffectChild[5].GetComponent<SeventyOneSquared.PDUnity>();
        val_19.Running = true;
        if(this.particleEffectChild[5] != null)
        {
            goto label_76;
        }
        
        goto label_77;
        label_33:
        if((System.String.Equals(a:  val_28, b:  "Iron_Ball")) == false)
        {
            goto label_42;
        }
        
        SeventyOneSquared.PDUnity val_21 = this.particleEffectChild[3].GetComponent<SeventyOneSquared.PDUnity>();
        val_21.Running = true;
        if(this.particleEffectChild[3] != null)
        {
            goto label_76;
        }
        
        goto label_77;
        label_42:
        if((System.String.Equals(a:  val_28, b:  "Rainbow_Bubble")) == false)
        {
            goto label_51;
        }
        
        SeventyOneSquared.PDUnity val_23 = this.particleEffectChild[1].GetComponent<SeventyOneSquared.PDUnity>();
        val_23.Running = true;
        if(this.particleEffectChild[1] != null)
        {
            goto label_76;
        }
        
        goto label_77;
        label_51:
        if((System.String.Equals(a:  val_28, b:  "Color_Eraser_Ball")) == false)
        {
            goto label_60;
        }
        
        SeventyOneSquared.PDUnity val_25 = this.particleEffectChild[2].GetComponent<SeventyOneSquared.PDUnity>();
        val_25.Running = true;
        if(this.particleEffectChild[2] != null)
        {
            goto label_76;
        }
        
        goto label_77;
        label_60:
        if((System.String.Equals(a:  val_28, b:  "TrashPop")) == false)
        {
            goto label_69;
        }
        
        SeventyOneSquared.PDUnity val_27 = this.particleEffectChild[6].GetComponent<SeventyOneSquared.PDUnity>();
        val_27.Running = true;
        if(this.particleEffectChild[6] != null)
        {
            goto label_76;
        }
        
        goto label_77;
        label_69:
        this.anim.Play(stateName:  val_28, layer:  0, normalizedTime:  0f);
        goto label_79;
    }
    private System.Collections.IEnumerator DestroyAnim()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new PlayerAnimDestroyer.<DestroyAnim>d__4();
    }
    public PlayerAnimDestroyer()
    {
    
    }

}
