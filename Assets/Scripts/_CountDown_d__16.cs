using UnityEngine;
private sealed class InkUpTutorialScript.<CountDown>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InkUpTutorialScript <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InkUpTutorialScript.<CountDown>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        float val_4 = this.<>4__this.inkCountdown;
        if(val_4 > (-1f))
        {
            goto label_3;
        }
        
        label_1:
        val_4 = 0;
        return (bool)val_4;
        label_3:
        val_4 = val_4 + (-0.02f);
        this.<>4__this.inkCountdown = (val_4 > 0f) ? (val_4) : 10f;
        string val_2 = this.<>4__this + 72.ToString(format:  "F2");
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_4;
        return (bool)val_4;
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
