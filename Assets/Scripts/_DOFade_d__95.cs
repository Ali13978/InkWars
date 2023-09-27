using UnityEngine;
private sealed class VSSHARE.<DOFade>d__95 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action OnUpdate;
    public UnityEngine.UI.Image im;
    public float _to;
    public System.Action OnCompleted;
    public float _from;
    public float time;
    public float delay;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VSSHARE.<DOFade>d__95(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.UI.Image val_9;
        float val_10;
        int val_11;
        float val_12;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        VSSHARE.<>c__DisplayClass95_0 val_1 = new VSSHARE.<>c__DisplayClass95_0();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .OnUpdate = this.OnUpdate;
        val_9 = (VSSHARE.<>c__DisplayClass95_0)[1152921529146161200].im;
        val_10 = (VSSHARE.<>c__DisplayClass95_0)[1152921529146161200]._to;
        .im = this.im;
        ._to = this._to;
        .OnCompleted = this.OnCompleted;
        goto label_4;
        label_1:
        val_11 = 0;
        this.<>1__state = 0;
        return (bool)val_11;
        label_2:
        val_11 = 0;
        return (bool)val_11;
        label_3:
        mem[16] = this.OnUpdate;
        val_9 = 24;
        mem[24] = this.im;
        val_10 = 32;
        mem[32] = this._to;
        mem[40] = this.OnCompleted;
        label_4:
        if(val_1 != null)
        {
            
        }
        else
        {
                val_12 = mem[32];
        }
        
        val_11 = 1;
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOColor(target:  mem[24], endValue:  new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = val_12}, duration:  this.time), delay:  this.delay), isIndependentUpdate:  true), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void VSSHARE.<>c__DisplayClass95_0::<DOFade>b__0())), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void VSSHARE.<>c__DisplayClass95_0::<DOFade>b__1()));
        this.<>2__current = 0;
        this.<>1__state = val_11;
        return (bool)val_11;
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
