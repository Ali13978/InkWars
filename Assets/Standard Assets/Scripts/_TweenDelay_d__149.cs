using UnityEngine;
private sealed class iTween.<TweenDelay>d__149 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public iTween <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public iTween.<TweenDelay>d__149(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_6;
        }
        
        this.<>1__state = 0;
        float val_1 = UnityEngine.Time.time;
        if((this.<>4__this) == null)
        {
            goto label_3;
        }
        
        this.<>4__this.delayStarted = val_1;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this.wasPaused) != false)
        {
                this.<>4__this.wasPaused = false;
            this.<>4__this.TweenStart();
        }
        
        label_6:
        val_3 = 0;
        return (bool)val_3;
        label_3:
        mem[88] = val_1;
        label_4:
        val_3 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.delay);
        this.<>1__state = val_3;
        return (bool)val_3;
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
