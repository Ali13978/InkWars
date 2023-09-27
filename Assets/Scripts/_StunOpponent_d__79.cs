using UnityEngine;
private sealed class LineControllerAI.<StunOpponent>d__79 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerAI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerAI.<StunOpponent>d__79(int <>1__state)
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
        var val_19;
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
        return (bool)val_18;
        label_1:
        this.<>1__state = 0;
        val_19 = static_value_032DD328;
        val_19 = static_value_032DD328;
        UnityEngine.Vector3 val_5 = static_value_032DD328 + 184.gameObject.transform.position;
        UnityEngine.Vector3 val_8 = static_value_032DD328 + 184.gameObject.transform.position;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
        val_17 = val_9.x;
        this.<>4__this.stunnerPopHolder = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.stunnerPop, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_17, y = val_9.y, z = val_9.z, w = val_9.w});
        UnityEngine.Object.Destroy(obj:  static_value_032DD328 + 184.gameObject);
        val_18 = 1;
        mem2[0] = val_18;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  4f);
        this.<>1__state = 3;
        return (bool)val_18;
        label_2:
        this.<>1__state = 0;
        val_15 = this.<>4__this.stunnerPopHolder.gameObject;
        UnityEngine.Object.Destroy(obj:  val_15);
        label_3:
        val_18 = 0;
        return (bool)val_18;
        label_6:
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.49f);
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = 2;
        return (bool)val_18;
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
