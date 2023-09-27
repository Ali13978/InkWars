using UnityEngine;
private sealed class swipeika.<FillMeter>d__35 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public swipeika.<FillMeter>d__35(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        float val_4;
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
        val_3 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        val_4 = this.<startTime>5__2;
        this.<>1__state = 0;
        if(val_4 <= 1f)
        {
            goto label_5;
        }
        
        label_3:
        val_3 = 0;
        return (bool)val_3;
        label_2:
        val_4 = 0f;
        this.<startTime>5__2 = 0f;
        this.<>1__state = 0;
        label_5:
        val_4 = val_4 + 0.02f;
        this.<startTime>5__2 = val_4;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.01f);
        this.<>1__state = 2;
        val_3 = 1;
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
