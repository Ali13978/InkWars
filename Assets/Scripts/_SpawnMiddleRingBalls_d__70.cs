using UnityEngine;
private sealed class InstanceAnimator.<SpawnMiddleRingBalls>d__70 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InstanceAnimator <>4__this;
    public int negateX;
    public UnityEngine.GameObject[] middleRingBallsRef;
    public UnityEngine.Transform parent;
    private float <localSpeed>5__2;
    private float <upperAngle>5__3;
    private float <upperAngle1>5__4;
    private float <upperAngleLow>5__5;
    private float <upperAngleLow1>5__6;
    private float <startTime>5__7;
    private int <j>5__8;
    private int <k>5__9;
    private int <i>5__10;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InstanceAnimator.<SpawnMiddleRingBalls>d__70(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_85;
        if((this.<>1__state) <= 4)
        {
                var val_86 = 40830824 + (this.<>1__state) << 2;
            val_86 = val_86 + 40830824;
        }
        else
        {
                val_85 = 0;
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
