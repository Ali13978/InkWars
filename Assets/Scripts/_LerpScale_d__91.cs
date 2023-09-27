using UnityEngine;
private sealed class VSSHARE.<LerpScale>d__91 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action OnUpdate;
    public float _from;
    public float _to;
    public float time;
    public UnityEngine.RectTransform rect;
    public System.Action OnCompleted;
    private float <elapsedTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VSSHARE.<LerpScale>d__91(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        System.Action val_12;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<elapsedTime>5__2 = 0f;
        this.<>1__state = 0;
        val_8 = 0f;
        goto label_3;
        label_1:
        val_8 = this.<elapsedTime>5__2;
        this.<>1__state = 0;
        label_3:
        val_9 = this.time;
        if(val_8 < 0)
        {
            goto label_4;
        }
        
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  this._to, y:  this._to);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        val_10 = val_2.x;
        val_11 = val_2.z;
        this.rect.localScale = new UnityEngine.Vector3() {x = val_10, y = val_2.y, z = val_11};
        val_12 = this.OnCompleted;
        if(val_12 == null)
        {
                return (bool)val_12;
        }
        
        val_12.Invoke();
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_4:
        if(this.OnUpdate != null)
        {
                this.OnUpdate.Invoke();
            val_9 = this.time;
        }
        
        float val_4 = UnityEngine.Mathf.Lerp(a:  this._from, b:  this._to, t:  (this.<elapsedTime>5__2) / val_9);
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4, y:  val_4);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        val_11 = val_6.z;
        this.rect.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_11};
        val_10 = this.<elapsedTime>5__2;
        float val_7 = UnityEngine.Time.deltaTime;
        val_7 = val_10 + val_7;
        this.<elapsedTime>5__2 = val_7;
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
