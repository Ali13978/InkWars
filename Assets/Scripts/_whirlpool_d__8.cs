using UnityEngine;
private sealed class WhirlpoolScript.<whirlpool>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WhirlpoolScript <>4__this;
    private float <rotationAngle>5__2;
    private float <lerpVariable>5__3;
    private float <startTime>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WhirlpoolScript.<whirlpool>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_17;
        int val_19;
        val_17 = this;
        if((this.<>1__state) <= 3)
        {
                var val_17 = 40829544 + (this.<>1__state) << 2;
            val_17 = val_17 + 40829544;
        }
        else
        {
                val_19 = 0;
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
