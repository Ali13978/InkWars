using UnityEngine;
private sealed class BallSwipeVs.<DelayBallSwap>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BallSwipeVs <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BallSwipeVs.<DelayBallSwap>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_1;
        if((this.<>1__state) >= 2)
        {
                return false;
        }
        
        this.<>1__state = 0;
        val_1 = null;
        val_1 = null;
        if(BallSwipeVs.flag != false)
        {
                this.<>4__this.SwitchBall();
            return false;
        }
        
        this.<>2__current = 0;
        this.<>1__state = 1;
        return false;
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
