using UnityEngine;
private sealed class LanPlaySceneManager.<shootBubbleBuffer>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int ballEntry;
    public int balltype;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LanPlaySceneManager.<shootBubbleBuffer>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        LineControllerP2 val_2;
        var val_3;
        var val_4;
        val_2 = this;
        if((this.<>1__state) >= 2)
        {
                return false;
        }
        
        this.<>1__state = 0;
        val_3 = null;
        val_3 = null;
        if(InstanceAnimator.areBallsInstantiated != false)
        {
                val_4 = null;
            val_4 = null;
            val_2 = LineControllerP2.instance;
            val_2.ShootBubble(grid:  this.ballEntry, networkBubble:  new System.Nullable<System.Int32>() {HasValue = false});
            return false;
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
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
