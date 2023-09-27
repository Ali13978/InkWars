using UnityEngine;
private sealed class VSSHARE.<DORotate>d__92 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.RectTransform rect;
    public UnityEngine.Quaternion _quaternionStart;
    public UnityEngine.Quaternion _quaternionEnd;
    public float time;
    private float <elapsedTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VSSHARE.<DORotate>d__92(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        float val_6;
        UnityEngine.Quaternion val_7;
        float val_8;
        int val_9;
        UnityEngine.Quaternion val_10;
        float val_11;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.rect.rotation = new UnityEngine.Quaternion() {x = this._quaternionStart, y = V9.16B, z = V10.16B, w = V11.16B};
        val_5 = this;
        this.<elapsedTime>5__2 = 0f;
        val_6 = 0f;
        goto label_4;
        label_1:
        val_5 = this;
        val_6 = this.<elapsedTime>5__2;
        this.<>1__state = 0;
        label_4:
        if(val_6 < 0)
        {
            goto label_5;
        }
        
        val_7 = this._quaternionEnd;
        this.rect.rotation = new UnityEngine.Quaternion() {x = val_7, y = this.time, z = V10.16B, w = V11.16B};
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_5:
        val_10 = this._quaternionStart;
        val_11 = ???;
        val_10 = val_10;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_10, y = val_11, z = V15.16B, w = V14.16B}, b:  new UnityEngine.Quaternion() {x = this._quaternionEnd, y = V11.16B, z = V12.16B, w = V10.16B}, t:  val_6 / this.time);
        val_8 = val_2.z;
        this.rect.rotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_8, w = val_2.w};
        val_7 = (this.<elapsedTime>5__2) + UnityEngine.Time.deltaTime;
        this.<elapsedTime>5__2 = val_7;
        this.<elapsedTime>5__2 = UnityEngine.Mathf.Clamp01(value:  val_7);
        this.<>2__current = 0;
        val_9 = 1;
        this.<>1__state = val_9;
        return (bool)val_9;
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
