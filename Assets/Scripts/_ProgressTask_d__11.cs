using UnityEngine;
private sealed class RematchProgressBar.<ProgressTask>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RematchProgressBar <>4__this;
    private float <steps>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RematchProgressBar.<ProgressTask>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RematchProgressBar val_11;
        int val_17;
        if((this.<>1__state) <= 4)
        {
                var val_10 = 40824680 + (this.<>1__state) << 2;
            val_11 = this.<>4__this;
            val_10 = val_10 + 40824680;
        }
        else
        {
                val_17 = 0;
            return (bool);
        }
    
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
