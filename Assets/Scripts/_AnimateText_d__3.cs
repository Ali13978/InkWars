using UnityEngine;
private sealed class popScoreScript.<AnimateText>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public popScoreScript <>4__this;
    public UnityEngine.Vector2 pos;
    public UnityEngine.Vector2 size;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public popScoreScript.<AnimateText>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_28;
        int val_29;
        val_28 = this;
        if((this.<>1__state) <= 4)
        {
                var val_28 = 40844196 + (this.<>1__state) << 2;
            val_28 = val_28 + 40844196;
        }
        else
        {
                val_29 = 0;
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
