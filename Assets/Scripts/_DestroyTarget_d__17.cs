using UnityEngine;
private sealed class TargetBallCPU.<DestroyTarget>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TargetBallCPU <>4__this;
    public UnityEngine.GameObject[] outerRingBalls;
    public int negateX;
    public UnityEngine.GameObject[] middleRingBalls;
    public UnityEngine.GameObject[] innerRingBalls;
    private int <count>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TargetBallCPU.<DestroyTarget>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_472 = 0;
        if((this.<>1__state) > 19)
        {
                return (bool);
        }
        
        var val_469 = 40838864;
        val_469 = (40838864 + (this.<>1__state) << 2) + val_469;
        goto (40838864 + (this.<>1__state) << 2 + 40838864);
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
