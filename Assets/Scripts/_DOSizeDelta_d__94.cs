using UnityEngine;
private sealed class VSSHARE.<DOSizeDelta>d__94 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.RectTransform rect;
    public UnityEngine.Vector2 _start;
    public UnityEngine.Vector2 _end;
    public float time;
    public System.Action onUpdate;
    public System.Action callback;
    private float <elapsedTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VSSHARE.<DOSizeDelta>d__94(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Vector2 val_5;
        var val_6;
        float val_7;
        System.Action val_8;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        val_5 = this._start;
        this.<>1__state = 0;
        this.rect.sizeDelta = new UnityEngine.Vector2() {x = val_5, y = V9.16B};
        val_6 = this;
        this.<elapsedTime>5__2 = 0f;
        val_7 = 0f;
        goto label_5;
        label_1:
        val_8 = this.callback;
        this.<>1__state = 0;
        if(val_8 == null)
        {
                return (bool)val_8;
        }
        
        val_8.Invoke();
        label_3:
        val_8 = 0;
        return (bool)val_8;
        label_2:
        val_6 = this;
        val_7 = this.<elapsedTime>5__2;
        this.<>1__state = 0;
        label_5:
        if(val_7 >= 0)
        {
                this.<>2__current = 0;
            this.<>1__state = 2;
            val_8 = 1;
            return (bool)val_8;
        }
        
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = this._start, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this._end, y = V8.16B}, t:  val_7 / this.time);
        this.rect.sizeDelta = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        val_5 = (this.<elapsedTime>5__2) + UnityEngine.Time.deltaTime;
        this.<elapsedTime>5__2 = val_5;
        this.<elapsedTime>5__2 = UnityEngine.Mathf.Clamp01(value:  val_5);
        if(this.onUpdate != null)
        {
                this.onUpdate.Invoke();
        }
        
        this.<>2__current = 0;
        val_8 = 1;
        this.<>1__state = val_8;
        return (bool)val_8;
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
