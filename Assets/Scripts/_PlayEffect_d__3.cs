using UnityEngine;
private sealed class View_PopAnimations.<PlayEffect>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_PopAnimations <>4__this;
    public InkWars.Model.BubbleTypes type;
    public string customAnimKey;
    public int basedLayer;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_PopAnimations.<PlayEffect>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_4;
        int val_5;
        val_4 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_4;
        }
        
        this.<>4__this.PlayHitEffectByBubbleType(type:  this.type, customAnimKey:  this.customAnimKey, basedLayer:  this.basedLayer);
        goto label_5;
        label_1:
        this.<>1__state = 0;
        val_4 = this.<>4__this.gameObject;
        UnityEngine.Object.Destroy(obj:  val_4);
        label_3:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        this.<>1__state = 0;
        goto label_11;
        label_4:
        0.PlayHitEffectByBubbleType(type:  this.type, customAnimKey:  this.customAnimKey, basedLayer:  this.basedLayer);
        label_5:
        if((this.<>4__this.IsPlaying()) != false)
        {
                val_5 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        label_11:
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = 2;
        val_5 = 1;
        return (bool)val_5;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
