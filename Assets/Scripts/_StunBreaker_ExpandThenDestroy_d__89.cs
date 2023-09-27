using UnityEngine;
private sealed class View_Core.<StunBreaker_ExpandThenDestroy>d__89 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.GameObject obj;
    public float speed;
    private UnityEngine.RectTransform <rectTrans>5__2;
    private UnityEngine.UI.Image <image>5__3;
    private float <Lerp>5__4;
    private UnityEngine.Vector3 <StartingScale>5__5;
    private UnityEngine.Vector3 <EndingScale>5__6;
    private UnityEngine.Color <StartingColor>5__7;
    private UnityEngine.Color <EndingColor>5__8;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_Core.<StunBreaker_ExpandThenDestroy>d__89(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_11;
        float val_12;
        UnityEngine.Color val_13;
        float val_14;
        int val_15;
        val_11 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<rectTrans>5__2 = this.obj.GetComponent<UnityEngine.RectTransform>();
        this.<image>5__3 = this.obj.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Object.Destroy(obj:  this.obj.GetComponent<ColorFlash>());
        val_12 = val_11;
        this.<Lerp>5__4 = 0f;
        UnityEngine.Vector3 val_4 = this.<rectTrans>5__2.localScale;
        this.<StartingScale>5__5 = val_4;
        mem[1152921528349844552] = val_4.y;
        mem[1152921528349844556] = val_4.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  2f);
        this.<EndingScale>5__6 = val_5;
        mem[1152921528349844564] = val_5.y;
        mem[1152921528349844568] = val_5.z;
        UnityEngine.Color val_6 = this.<image>5__3.color;
        this.<StartingColor>5__7 = val_6;
        mem[1152921528349844576] = val_6.g;
        mem[1152921528349844580] = val_6.b;
        mem[1152921528349844584] = val_6.a;
        this.<EndingColor>5__8 = val_6;
        mem[1152921528349844592] = val_6.g;
        mem[1152921528349844596] = val_6.b;
        mem[1152921528349844600] = 0;
        goto label_13;
        label_1:
        val_12 = this.<Lerp>5__4;
        this.<>1__state = 0;
        label_13:
        float val_11 = val_12;
        if(val_11 < 0)
        {
            goto label_14;
        }
        
        this.<rectTrans>5__2.localScale = new UnityEngine.Vector3() {x = this.<EndingScale>5__6, y = 1f, z = V10.16B};
        val_13 = this.<EndingColor>5__8;
        this.<image>5__3.color = new UnityEngine.Color() {r = val_13, g = 1f, b = V10.16B, a = V11.16B};
        val_11 = this.obj;
        UnityEngine.Object.Destroy(obj:  val_11);
        label_2:
        val_15 = 0;
        return (bool)val_15;
        label_14:
        float val_7 = UnityEngine.Time.deltaTime;
        float val_8 = 1f - val_11;
        val_8 = val_8 * val_7;
        val_7 = (val_11 < 0) ? (val_7) : (val_8);
        val_7 = val_7 * this.speed;
        val_11 = val_7 + val_11;
        this.<Lerp>5__4 = val_11;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<StartingScale>5__5, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.<EndingScale>5__6, y = V11.16B, z = 1f}, t:  val_11);
        this.<rectTrans>5__2.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Color val_10 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.<StartingColor>5__7, g = val_9.y, b = val_9.z, a = this.<EndingScale>5__6}, b:  new UnityEngine.Color() {r = this.<EndingColor>5__8, g = 1f, b = val_11}, t:  this.<Lerp>5__4);
        val_13 = val_10.r;
        val_14 = val_10.b;
        this.<image>5__3.color = new UnityEngine.Color() {r = val_13, g = val_10.g, b = val_14, a = val_10.a};
        val_15 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_15;
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
