using UnityEngine;
private sealed class LineController.<StunOpponent>d__213 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<StunOpponent>d__213(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_15;
        var val_16;
        float val_17;
        int val_18;
        UnityEngine.GameObject val_19;
        var val_20;
        val_15 = this;
        if(((this.<>1__state) - 1) < 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 3)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        val_16 = null;
        val_16 = null;
        val_17 = InstanceAnimator.UniversalX;
        if(val_17 != 4.46f)
        {
            goto label_6;
        }
        
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.62f);
        this.<>2__current = new UnityEngine.WaitForSeconds();
        val_18 = 1;
        this.<>1__state = val_18;
        return val_18;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_8;
        }
        
        val_19 = this.<>4__this.stunnerPop;
        goto label_9;
        label_2:
        this.<>1__state = 0;
        val_15 = this.<>4__this.stunnerPopHolder.gameObject;
        UnityEngine.Object.Destroy(obj:  val_15);
        label_3:
        val_18 = 0;
        return val_18;
        label_8:
        val_19 = 0;
        label_9:
        UnityEngine.Vector3 val_6 = this.<>4__this.playerBall.gameObject.transform.position;
        UnityEngine.Vector3 val_9 = this.<>4__this.playerBall.gameObject.transform.position;
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        val_17 = val_10.x;
        this.<>4__this.stunnerPopHolder = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_19, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_17, y = val_10.y, z = val_10.z, w = val_10.w});
        UnityEngine.Object.Destroy(obj:  this.<>4__this.playerBall.gameObject);
        val_20 = null;
        val_20 = null;
        val_18 = true;
        LineController.stunFlag = val_18;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  4f);
        this.<>1__state = 3;
        return val_18;
        label_6:
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.49f);
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = 2;
        return val_18;
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
