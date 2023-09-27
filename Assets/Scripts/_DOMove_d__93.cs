using UnityEngine;
private sealed class VSSHARE.<DOMove>d__93 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.RectTransform rect;
    public UnityEngine.Vector2 _start;
    public UnityEngine.Vector2 _end;
    public float time;
    private float <elapsedTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VSSHARE.<DOMove>d__93(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        float val_9;
        float val_10;
        float val_11;
        int val_12;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this._start, y = V8.16B});
        this.rect.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        val_8 = this;
        this.<elapsedTime>5__2 = 0f;
        val_9 = 0f;
        goto label_6;
        label_1:
        val_8 = this;
        val_9 = this.<elapsedTime>5__2;
        this.<>1__state = 0;
        label_6:
        if(val_9 < 0)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this._end, y = V8.16B});
        val_10 = val_2.x;
        val_11 = val_2.z;
        this.rect.localPosition = new UnityEngine.Vector3() {x = val_10, y = val_2.y, z = val_11};
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_7:
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = this._start, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this._end, y = V8.16B}, t:  val_9 / this.time);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        val_11 = val_5.z;
        this.rect.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_11};
        val_10 = (this.<elapsedTime>5__2) + UnityEngine.Time.deltaTime;
        this.<elapsedTime>5__2 = val_10;
        this.<elapsedTime>5__2 = UnityEngine.Mathf.Clamp01(value:  val_10);
        this.<>2__current = 0;
        val_12 = 1;
        this.<>1__state = val_12;
        return (bool)val_12;
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
