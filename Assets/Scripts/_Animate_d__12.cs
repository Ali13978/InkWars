using UnityEngine;
private sealed class View_ScorePopUp.<Animate>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_ScorePopUp <>4__this;
    private float <Lerp>5__2;
    private float <TimeScale>5__3;
    private UnityEngine.RectTransform <rectTransform>5__4;
    private UnityEngine.Vector3 <OriginalPos>5__5;
    private UnityEngine.Vector3 <OriginalScale>5__6;
    private UnityEngine.Vector3 <EndPos>5__7;
    private UnityEngine.Vector3 <EndScale>5__8;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_ScorePopUp.<Animate>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.IEnumerator val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_23;
        var val_24;
        float val_25;
        int val_26;
        float val_27;
        val_17 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<Lerp>5__2 = 0f;
        if((this.<>4__this) == null)
        {
            goto label_3;
        }
        
        val_18 = 1f;
        val_19 = val_18 / (this.<>4__this.LifeSpan);
        this.<TimeScale>5__3 = val_19;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_5;
        }
        
        val_20 = 0f;
        if(val_20 > 0f)
        {
            goto label_6;
        }
        
        val_17 = 0.FlyToPlayerScore();
        goto label_7;
        label_3:
        val_18 = 1f;
        val_19 = val_18 / 0f;
        this.<TimeScale>5__3 = val_19;
        label_4:
        UnityEngine.RectTransform val_3 = this.<>4__this.gameObject.GetComponent<UnityEngine.RectTransform>();
        this.<rectTransform>5__4 = val_3;
        UnityEngine.Vector2 val_4 = val_3.anchoredPosition;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        this.<OriginalPos>5__5 = val_5;
        mem[1152921528386335724] = val_5.y;
        mem[1152921528386335728] = 0;
        UnityEngine.Vector3 val_6 = this.<rectTransform>5__4.localScale;
        this.<OriginalScale>5__6 = val_6;
        mem[1152921528386335736] = val_6.y;
        mem[1152921528386335740] = val_6.z;
        if((this.<>4__this) != null)
        {
                val_21 = this.<>4__this.EndOffsetX;
        }
        else
        {
                val_21 = 0f;
        }
        
        float val_17 = this.<>4__this.EndOffsetY;
        float val_7 = (this.<OriginalPos>5__5) + val_21;
        val_17 = S10 + val_17;
        val_20 = this.<OriginalScale>5__6;
        this.<EndPos>5__7 = 0;
        mem[1152921528386335752] = 0;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = V10.16B}, d:  this.<>4__this.EndScaleMuliplier);
        this.<EndScale>5__8 = val_8;
        mem[1152921528386335760] = val_8.y;
        mem[1152921528386335764] = val_8.z;
        label_5:
        val_24 = this.<>4__this;
        val_25 = this.<>4__this.LifeSpan;
        if(val_25 > 0f)
        {
            goto label_18;
        }
        
        val_17 = this.<>4__this.FlyToPlayerScore();
        label_7:
        UnityEngine.Coroutine val_10 = this.<>4__this.StartCoroutine(routine:  val_17);
        label_2:
        val_26 = 0;
        return (bool)val_26;
        label_18:
        val_27 = UnityEngine.Time.deltaTime;
        goto label_20;
        label_6:
        val_24 = 80;
        val_25 = 0f;
        float val_12 = UnityEngine.Time.deltaTime;
        val_27 = val_12;
        label_20:
        val_12 = val_25 - val_27;
        mem[80] = val_12;
        float val_18 = this.<Lerp>5__2;
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = (this.<TimeScale>5__3) * val_13;
        val_18 = val_18 + val_13;
        this.<Lerp>5__2 = val_18;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<OriginalPos>5__5, y = V10.16B, z = V14.16B}, b:  new UnityEngine.Vector3() {x = this.<EndPos>5__7, y = V11.16B, z = V12.16B}, t:  val_18);
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        this.<rectTransform>5__4.anchoredPosition = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<OriginalScale>5__6, y = val_15.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = this.<EndScale>5__8, y = V11.16B, z = V12.16B}, t:  this.<Lerp>5__2);
        val_20 = val_16.x;
        val_23 = val_16.z;
        this.<rectTransform>5__4.localScale = new UnityEngine.Vector3() {x = val_20, y = val_16.y, z = val_23};
        val_26 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_26;
        return (bool)val_26;
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
