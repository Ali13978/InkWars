using UnityEngine;
public class CPUAnimDestroyer : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator anim;
    public UnityEngine.GameObject[] particleEffectChild;
    
    // Methods
    private void Start()
    {
        var val_26;
        var val_27;
        string val_28;
        this.anim = this.gameObject.GetComponent<UnityEngine.Animator>();
        val_26 = null;
        val_26 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
                val_27 = null;
            val_27 = null;
            val_28 = 1152921505077936152;
        }
        else
        {
                val_28 = 1152921505079480328;
        }
        
        if(((((System.String.Equals(a:  val_28, b:  "Red")) != true) && ((System.String.Equals(a:  val_28, b:  "Blue")) != true)) && ((System.String.Equals(a:  val_28, b:  "Green")) != true)) && ((System.String.Equals(a:  val_28, b:  "Yellow")) != true))
        {
                if((System.String.Equals(a:  val_28, b:  "Orange")) != true)
        {
                if((System.String.Equals(a:  val_28, b:  "Purple")) == false)
        {
            goto label_13;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_9 = this.particleEffectChild[0].GetComponent<SeventyOneSquared.PDUnity>();
        val_9.Running = true;
        UnityEngine.GameObject val_27 = this.particleEffectChild[0];
        if(val_27 != null)
        {
            goto label_69;
        }
        
        label_70:
        label_69:
        val_27.SetActive(value:  true);
        label_72:
        UnityEngine.Coroutine val_10 = this.StartCoroutine(methodName:  "DestroyAnim");
        return;
        label_13:
        if(((((System.String.Equals(a:  val_28, b:  "RedExtended")) != true) && ((System.String.Equals(a:  val_28, b:  "BlueExtended")) != true)) && ((System.String.Equals(a:  val_28, b:  "GreenExtended")) != true)) && ((System.String.Equals(a:  val_28, b:  "YellowExtended")) != true))
        {
                if((System.String.Equals(a:  val_28, b:  "OrangeExtended")) != true)
        {
                if((System.String.Equals(a:  val_28, b:  "PurpleExtended")) == false)
        {
            goto label_26;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_17 = this.particleEffectChild[5].GetComponent<SeventyOneSquared.PDUnity>();
        val_17.Running = true;
        if(this.particleEffectChild[5] != null)
        {
            goto label_69;
        }
        
        goto label_70;
        label_26:
        if((System.String.Equals(a:  val_28, b:  "Iron_Ball")) == false)
        {
            goto label_35;
        }
        
        SeventyOneSquared.PDUnity val_19 = this.particleEffectChild[3].GetComponent<SeventyOneSquared.PDUnity>();
        val_19.Running = true;
        if(this.particleEffectChild[3] != null)
        {
            goto label_69;
        }
        
        goto label_70;
        label_35:
        if((System.String.Equals(a:  val_28, b:  "Rainbow_Bubble")) == false)
        {
            goto label_44;
        }
        
        SeventyOneSquared.PDUnity val_21 = this.particleEffectChild[1].GetComponent<SeventyOneSquared.PDUnity>();
        val_21.Running = true;
        if(this.particleEffectChild[1] != null)
        {
            goto label_69;
        }
        
        goto label_70;
        label_44:
        if((System.String.Equals(a:  val_28, b:  "Color_Eraser_Ball")) == false)
        {
            goto label_53;
        }
        
        SeventyOneSquared.PDUnity val_23 = this.particleEffectChild[2].GetComponent<SeventyOneSquared.PDUnity>();
        val_23.Running = true;
        if(this.particleEffectChild[2] != null)
        {
            goto label_69;
        }
        
        goto label_70;
        label_53:
        if((System.String.Equals(a:  val_28, b:  "TrashPop")) == false)
        {
            goto label_62;
        }
        
        SeventyOneSquared.PDUnity val_25 = this.particleEffectChild[6].GetComponent<SeventyOneSquared.PDUnity>();
        val_25.Running = true;
        if(this.particleEffectChild[6] != null)
        {
            goto label_69;
        }
        
        goto label_70;
        label_62:
        this.anim.Play(stateName:  val_28, layer:  0, normalizedTime:  0f);
        goto label_72;
    }
    private System.Collections.IEnumerator DestroyAnim()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new CPUAnimDestroyer.<DestroyAnim>d__3();
    }
    public CPUAnimDestroyer()
    {
    
    }

}
