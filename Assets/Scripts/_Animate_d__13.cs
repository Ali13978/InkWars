using UnityEngine;
private sealed class LoadingBar.<Animate>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LoadingBar <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingBar.<Animate>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_14;
        float val_15;
        int val_16;
        float val_17;
        UnityEngine.Vector2 val_18;
        UnityEngine.Vector2 val_19;
        float val_20;
        float val_22;
        UnityEngine.UI.Image val_24;
        if((this.<>1__state) > 1)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_2;
        }
        
        val_14 = this.<>4__this;
        val_15 = this.<>4__this.lastSeenPercentage;
        goto label_3;
        label_1:
        val_16 = 0;
        return (bool)val_16;
        label_2:
        val_14 = 64;
        val_15 = 1.401298E-45f;
        label_3:
        val_17 = this.<>4__this.percent;
        if(val_15 == val_17)
        {
                val_18 = this.<>4__this;
            val_19 = this.<>4__this.targetDimensions;
            val_20 = mem[this.<>4__this + 56 + 4];
            val_20 = this.<>4__this + 56 + 4;
        }
        else
        {
                mem[64] = val_17;
            val_17 = this.<>4__this.percent;
            UnityEngine.Vector2 val_1 = this.<>4__this.GetPercentToVector2(percent:  val_17);
            val_19 = val_1.x;
            val_20 = val_1.y;
            val_18 = this.<>4__this.targetDimensions;
            this.<>4__this.targetDimensions = val_1;
            mem2[0] = val_20;
        }
        
        UnityEngine.Vector2 val_2 = this.<>4__this.loadingBar.sizeDelta;
        val_22 = val_19;
        if((this.<>4__this.AlmostSame(a:  new UnityEngine.Vector2() {x = val_22, y = val_20}, b:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) == true)
        {
            goto label_8;
        }
        
        UnityEngine.Vector2 val_16 = this.<>4__this.targetDimensions;
        UnityEngine.Vector2 val_4 = this.<>4__this.loadingBar.sizeDelta;
        float val_15 = val_4.x;
        val_15 = (System.Math.Abs(val_16 - val_15)) / (this.<>4__this.maxWidth);
        val_16 = val_15 * (this.<>4__this.pixelMaxVelocity);
        UnityEngine.Vector2 val_6 = this.<>4__this.loadingBar.sizeDelta;
        val_19 = val_6.x;
        val_16 = val_16 + 2f;
        UnityEngine.Vector2 val_7 = this.<>4__this.loadingBar.sizeDelta;
        if((this.<>4__this.targetDimensions) >= 0)
        {
            goto label_14;
        }
        
        val_7.x = val_7.x - val_16;
        if(val_7.x < 0)
        {
            goto label_19;
        }
        
        UnityEngine.Vector2 val_8 = this.<>4__this.loadingBar.sizeDelta;
        val_8.x = val_8.x - val_16;
        goto label_19;
        label_14:
        float val_17 = this.<>4__this.tolerance;
        val_7.x = val_16 + val_7.x;
        val_17 = (this.<>4__this.maxWidth) - val_17;
        if(val_7.x > val_17)
        {
            
        }
        else
        {
                UnityEngine.Vector2 val_9 = this.<>4__this.loadingBar.sizeDelta;
            val_9.x = val_16 + val_9.x;
        }
        
        label_19:
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_9.x, y:  val_9.y);
        val_22 = val_10.x;
        this.<>4__this.loadingBar.sizeDelta = new UnityEngine.Vector2() {x = val_22, y = val_10.y};
        label_8:
        val_24 = this.<>4__this.filledLoadingImage;
        if(0 != val_24)
        {
                val_24 = this.<>4__this.filledLoadingImage;
            val_19 = this.<>4__this.animatedPercentage;
            float val_18 = 0.01f;
            val_18 = val_19 * val_18;
            val_24.fillAmount = val_18;
        }
        
        val_16 = 1;
        this.<>2__current = new UnityEngine.WaitForSecondsRealtime(time:  0.01f);
        this.<>1__state = val_16;
        return (bool)val_16;
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
