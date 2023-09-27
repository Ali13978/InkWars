using UnityEngine;
private sealed class TargetBallDemo.<DestroyTarget>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TargetBallDemo <>4__this;
    public UnityEngine.GameObject[] ringBalls;
    private int <destroyedBubbles>5__2;
    private int <i>5__3;
    private int <i>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TargetBallDemo.<DestroyTarget>d__24(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_22;
        int val_23;
        int val_27;
        int val_28;
        object val_29;
        int val_30;
        val_22 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_22;
        }
        
        var val_22 = 40838992;
        val_22 = (40838992 + (this.<>1__state) << 2) + val_22;
        goto (40838992 + (this.<>1__state) << 2 + 40838992);
        label_32:
        if((this.<>4__this.DestroyBubble(ringBalls:  this.ringBalls, index:  0)) == false)
        {
            goto label_29;
        }
        
        int val_24 = this.<destroyedBubbles>5__2;
        val_24 = val_24 + 1;
        this.<destroyedBubbles>5__2 = val_24;
        UnityEngine.WaitForSeconds val_16 = null;
        val_29 = val_16;
        val_16 = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.destroyLag);
        val_30 = 1;
        goto label_37;
        label_29:
        val_23 =  - 1;
        this.<i>5__3 = val_23;
        if((val_23 & 2147483648) == 0)
        {
            goto label_32;
        }
        
        goto label_33;
        label_38:
        if((this.<>4__this.DestroyBubble(ringBalls:  this.ringBalls, index:  val_23)) == false)
        {
            goto label_35;
        }
        
        int val_25 = this.<destroyedBubbles>5__2;
        val_25 = val_25 + 1;
        this.<destroyedBubbles>5__2 = val_25;
        UnityEngine.WaitForSeconds val_18 = null;
        val_29 = val_18;
        val_18 = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.destroyLag);
        val_30 = 2;
        goto label_37;
        label_35:
        val_28 =  + 1;
        this.<i>5__4 = val_28;
        val_27 = mem[this.<i>5__3];
        val_27 = ;
        if(val_28 <= val_27)
        {
            goto label_38;
        }
        
        label_33:
        UnityEngine.Object.Destroy(obj:  this.<>4__this.gameObject);
        InteractiveTutorialManager.Instance.OnPoppedBubbles(ShotByCPU:  ((this.<>4__this.isCPUBall) == true) ? 1 : 0, destroyedBubbles:  this.<destroyedBubbles>5__2);
        val_29 = 0;
        val_30 = 3;
        label_37:
        val_22 = 1;
        this.<>2__current = val_29;
        this.<>1__state = val_30;
        return (bool)val_22;
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
