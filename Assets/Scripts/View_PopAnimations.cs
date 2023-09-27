using UnityEngine;
public class View_PopAnimations : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<View_PopAnimations.BubbleHitEffectData> effects;
    
    // Methods
    public void Initialize(InkWars.Model.BubbleTypes type, string customAnimKey, int basedLayer)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.PlayEffect(type:  type, customAnimKey:  customAnimKey, basedLayer:  basedLayer));
    }
    private System.Collections.IEnumerator PlayEffect(InkWars.Model.BubbleTypes type, string customAnimKey, int basedLayer)
    {
        View_PopAnimations.<PlayEffect>d__3 val_1 = new View_PopAnimations.<PlayEffect>d__3();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .type = type;
            .customAnimKey = customAnimKey;
        }
        else
        {
                mem[32] = this;
            mem[40] = type;
            mem[48] = customAnimKey;
        }
        
        .basedLayer = basedLayer;
        return (System.Collections.IEnumerator)val_1;
    }
    private void PlayHitEffectByBubbleType(InkWars.Model.BubbleTypes type, string customAnimKey, int basedLayer)
    {
        InkWars.Model.BubbleTypes val_10;
        object val_11;
        System.Predicate<T> val_12;
        var val_13;
        var val_14;
        val_10 = type;
        View_PopAnimations.<>c__DisplayClass4_0 val_1 = null;
        val_11 = val_1;
        val_1 = new View_PopAnimations.<>c__DisplayClass4_0();
        if(val_11 == null)
        {
            goto label_1;
        }
        
        .type = val_10;
        .customAnimKey = customAnimKey;
        if(val_10 != 0)
        {
            goto label_2;
        }
        
        return;
        label_1:
        mem[16] = val_10;
        mem[24] = customAnimKey;
        val_10 = mem[16];
        if(val_10 == 0)
        {
                return;
        }
        
        label_2:
        System.Predicate<BubbleHitEffectData> val_2 = null;
        val_12 = val_2;
        val_2 = new System.Predicate<BubbleHitEffectData>(object:  val_1, method:  System.Boolean View_PopAnimations.<>c__DisplayClass4_0::<PlayHitEffectByBubbleType>b__0(View_PopAnimations.BubbleHitEffectData x));
        if((this.effects.Find(match:  val_2)) == null)
        {
                System.Predicate<BubbleHitEffectData> val_4 = null;
            val_12 = val_4;
            val_4 = new System.Predicate<BubbleHitEffectData>(object:  val_1, method:  System.Boolean View_PopAnimations.<>c__DisplayClass4_0::<PlayHitEffectByBubbleType>b__1(View_PopAnimations.BubbleHitEffectData x));
            if((this.effects.Find(match:  val_4)) == null)
        {
                System.Predicate<BubbleHitEffectData> val_6 = null;
            val_12 = val_6;
            val_6 = new System.Predicate<BubbleHitEffectData>(object:  val_1, method:  System.Boolean View_PopAnimations.<>c__DisplayClass4_0::<PlayHitEffectByBubbleType>b__2(View_PopAnimations.BubbleHitEffectData x));
            if((this.effects.Find(match:  val_6)) == null)
        {
                val_13 = 1152921505098059776;
            val_14 = null;
            val_14 = null;
            val_11 = View_PopAnimations.<>c.<>9__4_3;
            if(val_11 == null)
        {
                System.Predicate<BubbleHitEffectData> val_8 = null;
            val_11 = val_8;
            val_8 = new System.Predicate<BubbleHitEffectData>(object:  View_PopAnimations.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean View_PopAnimations.<>c::<PlayHitEffectByBubbleType>b__4_3(View_PopAnimations.BubbleHitEffectData x));
            View_PopAnimations.<>c.<>9__4_3 = val_11;
        }
        
            BubbleHitEffectData val_9 = this.effects.Find(match:  val_8);
            if(val_9 == null)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        val_9.PlayAnimation(basedLayer:  basedLayer);
    }
    private bool IsPlaying()
    {
        var val_5;
        if((this.effects == null) || (this.effects.Count == 0))
        {
            goto label_2;
        }
        
        List.Enumerator<T> val_2 = this.effects.GetEnumerator();
        label_6:
        if(((-1997426696) & 1) == 0)
        {
            goto label_4;
        }
        
        System.Type val_3 = 0.InitialType;
        if((val_3 == null) || (val_3.IsPlaying() == false))
        {
            goto label_6;
        }
        
        val_5 = 1;
        goto label_7;
        label_4:
        val_5 = 0;
        label_7:
        0.Add(driver:  public System.Void List.Enumerator<BubbleHitEffectData>::Dispose(), rectTransform:  null, drivenProperties:  null);
        return (bool)val_5;
        label_2:
        val_5 = 0;
        return (bool)val_5;
    }
    public View_PopAnimations()
    {
        this.effects = new System.Collections.Generic.List<BubbleHitEffectData>();
    }

}
