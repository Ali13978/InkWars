using UnityEngine;
public class AnimDestroyerBlack : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator anim;
    public UnityEngine.GameObject[] particleEffectChild;
    
    // Methods
    private void Start()
    {
        var val_26;
        this.anim = this.gameObject.GetComponent<UnityEngine.Animator>();
        val_26 = null;
        val_26 = null;
        if(((((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "Red")) != true) && ((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "Blue")) != true)) && ((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "Green")) != true)) && ((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "Yellow")) != true))
        {
                if((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "Orange")) != true)
        {
                if((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "Purple")) == false)
        {
            goto label_9;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_9 = this.particleEffectChild[0].GetComponent<SeventyOneSquared.PDUnity>();
        val_9.Running = true;
        UnityEngine.GameObject val_27 = this.particleEffectChild[0];
        if(val_27 != null)
        {
            goto label_65;
        }
        
        label_66:
        label_65:
        val_27.SetActive(value:  true);
        label_68:
        UnityEngine.Coroutine val_10 = this.StartCoroutine(methodName:  "DestroyAnim");
        return;
        label_9:
        if(((((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "RedExtended")) != true) && ((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "BlueExtended")) != true)) && ((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "GreenExtended")) != true)) && ((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "YellowExtended")) != true))
        {
                if((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "OrangeExtended")) != true)
        {
                if((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "PurpleExtended")) == false)
        {
            goto label_22;
        }
        
        }
        
        }
        
        SeventyOneSquared.PDUnity val_17 = this.particleEffectChild[5].GetComponent<SeventyOneSquared.PDUnity>();
        val_17.Running = true;
        if(this.particleEffectChild[5] != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_22:
        if((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "Iron_Ball")) == false)
        {
            goto label_31;
        }
        
        SeventyOneSquared.PDUnity val_19 = this.particleEffectChild[3].GetComponent<SeventyOneSquared.PDUnity>();
        val_19.Running = true;
        if(this.particleEffectChild[3] != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_31:
        if((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "Rainbow_Bubble")) == false)
        {
            goto label_40;
        }
        
        SeventyOneSquared.PDUnity val_21 = this.particleEffectChild[1].GetComponent<SeventyOneSquared.PDUnity>();
        val_21.Running = true;
        if(this.particleEffectChild[1] != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_40:
        if((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "Color_Eraser_Ball")) == false)
        {
            goto label_49;
        }
        
        SeventyOneSquared.PDUnity val_23 = this.particleEffectChild[2].GetComponent<SeventyOneSquared.PDUnity>();
        val_23.Running = true;
        if(this.particleEffectChild[2] != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_49:
        if((System.String.Equals(a:  LineControllerAI.CPUPopTag, b:  "TrashPop")) == false)
        {
            goto label_58;
        }
        
        SeventyOneSquared.PDUnity val_25 = this.particleEffectChild[6].GetComponent<SeventyOneSquared.PDUnity>();
        val_25.Running = true;
        if(this.particleEffectChild[6] != null)
        {
            goto label_65;
        }
        
        goto label_66;
        label_58:
        this.anim.Play(stateName:  LineControllerAI.CPUPopTag, layer:  0, normalizedTime:  0f);
        goto label_68;
    }
    private System.Collections.IEnumerator DestroyAnim()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new AnimDestroyerBlack.<DestroyAnim>d__3();
    }
    public AnimDestroyerBlack()
    {
    
    }

}
