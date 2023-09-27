using UnityEngine;
private sealed class MVC_GameScene_Activator.<AnimateMatchBeginning>d__40 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MVC_GameScene_Activator <>4__this;
    private float <LeftPlayerAnimDuration>5__2;
    private float <RightPlayerAnimDuration>5__3;
    private float <GameOnAnimDuration>5__4;
    private float <BubbleSuctionDuration>5__5;
    private float <TimeDown>5__6;
    private bool <Activated_LeftPlayer>5__7;
    private bool <Activated_RightPlayer>5__8;
    private bool <Activated_GameOn>5__9;
    private bool <Activated_Bubbles>5__10;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVC_GameScene_Activator.<AnimateMatchBeginning>d__40(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        InkWars.Model.Model_Core val_56;
        int val_74;
        val_56 = this;
        if((this.<>1__state) <= 3)
        {
                var val_56 = 40826408 + (this.<>1__state) << 2;
            val_56 = val_56 + 40826408;
        }
        else
        {
                val_74 = 0;
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
