using UnityEngine;
private sealed class VSSHARE.<DelayAndShare>d__98 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AppAdvisory.SharingSystem.VSSHARE <>4__this;
    private string <filePath>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VSSHARE.<DelayAndShare>d__98(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_16;
        int val_17;
        val_16 = this;
        if((this.<>1__state) <= 3)
        {
                var val_16 = 40828064 + (this.<>1__state) << 2;
            val_16 = val_16 + 40828064;
        }
        else
        {
                val_17 = 0;
            return (bool)val_17;
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
