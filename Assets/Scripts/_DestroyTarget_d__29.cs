using UnityEngine;
private sealed class TargetBallVs.<DestroyTarget>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TargetBallVs <>4__this;
    public UnityEngine.GameObject[] outerRingBalls;
    public int negateX;
    public int incrementCounter;
    public UnityEngine.GameObject[] middleRingBalls;
    public UnityEngine.GameObject[] innerRingBalls;
    private int <i>5__2;
    private int <count>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TargetBallVs.<DestroyTarget>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4 = 40873240;
        val_4 = (40873240 + (this.<>1__state) << 2) + val_4;
        goto (40873240 + (this.<>1__state) << 2 + 40873240);
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
