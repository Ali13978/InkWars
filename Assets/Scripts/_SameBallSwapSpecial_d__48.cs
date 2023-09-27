using UnityEngine;
private sealed class ballSwipeScript.<SameBallSwapSpecial>d__48 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ballSwipeScript <>4__this;
    public UnityEngine.Vector2 pos1;
    public UnityEngine.Vector2 pos2;
    public UnityEngine.Vector2 size1;
    public UnityEngine.Vector2 size2;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ballSwipeScript.<SameBallSwapSpecial>d__48(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_12;
        var val_13;
        var val_14;
        int val_15;
        val_12 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_13 = null;
        val_13 = null;
        ballSwipeScript.flag = false;
        this.<startTime>5__2 = 0f;
        goto label_6;
        label_1:
        this.<>1__state = 0;
        if((this.<startTime>5__2) > 1.2f)
        {
                val_12 = 1152921505080434688;
            val_14 = null;
            val_14 = null;
            val_15 = 0;
            ballSwipeScript.flag = true;
            return (bool)val_15;
        }
        
        label_6:
        UnityEngine.Transform val_1 = transform;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        val_1.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
        val_1.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        float val_12 = this.<startTime>5__2;
        val_12 = val_12 + 0.2f;
        this.<startTime>5__2 = val_12;
        val_15 = 1;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = val_15;
        return (bool)val_15;
        label_2:
        val_15 = 0;
        return (bool)val_15;
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
