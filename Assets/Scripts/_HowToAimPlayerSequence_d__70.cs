using UnityEngine;
private sealed class DemoManager.<HowToAimPlayerSequence>d__70 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DemoManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DemoManager.<HowToAimPlayerSequence>d__70(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8 = 0;
        if((this.<>1__state) > 5)
        {
                return (bool);
        }
        
        var val_8 = 40827284;
        val_8 = (40827284 + (this.<>1__state) << 2) + val_8;
        goto (40827284 + (this.<>1__state) << 2 + 40827284);
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
