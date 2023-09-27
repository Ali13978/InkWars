using UnityEngine;
private sealed class DemoManager.<NowPopThoseBubblesPlayerSequence>d__103 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DemoManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DemoManager.<NowPopThoseBubblesPlayerSequence>d__103(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_35 = 0;
        if((this.<>1__state) > 10)
        {
                return (bool);
        }
        
        var val_35 = 40827352;
        val_35 = (40827352 + (this.<>1__state) << 2) + val_35;
        goto (40827352 + (this.<>1__state) << 2 + 40827352);
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
