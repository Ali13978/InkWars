using UnityEngine;
private sealed class BattleVSGates.<AnimateVsSplashScreen>d__28 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BattleVSGates <>4__this;
    private ballSwipeScript <ballSwipe>5__2;
    private BallSwipeVs <ballSwipeVs>5__3;
    private LineController <leftController>5__4;
    private LineControllerP2 <rightController>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattleVSGates.<AnimateVsSplashScreen>d__28(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_85;
        if((this.<>1__state) <= 12)
        {
                var val_84 = 40825904 + (this.<>1__state) << 2;
            val_84 = val_84 + 40825904;
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
