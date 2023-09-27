using UnityEngine;
private sealed class View_ScorePopUp.<FlyToPlayerScore>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_ScorePopUp <>4__this;
    private UnityEngine.Vector3 <originalPos>5__2;
    private UnityEngine.Vector3 <finalPos>5__3;
    private float <timeScale>5__4;
    private float <Lerp>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_ScorePopUp.<FlyToPlayerScore>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        View_ScorePopUp val_11;
        int val_12;
        var val_13;
        float val_14;
        float val_15;
        float val_16;
        var val_17;
        View_Objects val_18;
        float val_19;
        var val_20;
        int val_21;
        var val_22;
        float val_23;
        var val_24;
        var val_25;
        var val_26;
        int val_27;
        val_11 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_12 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_2 = val_11.transform.position;
        this.<originalPos>5__2 = val_2;
        mem[1152921528387111132] = val_2.y;
        mem[1152921528387111136] = val_2.z;
        val_13 = this.<>4__this.Player_ScoreTarget.ScoreText.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector3 val_4 = val_13.position;
        this.<finalPos>5__3 = val_4;
        mem[1152921528387111144] = val_4.y;
        mem[1152921528387111148] = val_4.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this.<originalPos>5__2, y = V11.16B, z = V12.16B});
        val_14 = 0f;
        this.<Lerp>5__5 = 0f;
        val_15 = (this.<>4__this.Speed) / val_5.x;
        this.<timeScale>5__4 = val_15;
        goto label_12;
        label_1:
        val_16 = this.<Lerp>5__5;
        val_15 = 1f;
        this.<>1__state = 0;
        if(val_16 < 0)
        {
            goto label_12;
        }
        
        if(val_11 == null)
        {
            goto label_13;
        }
        
        val_17 = val_11;
        val_18 = this.<>4__this.Player_ScoreTarget;
        goto label_14;
        label_12:
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = val_6 * (this.<timeScale>5__4);
        val_6 = val_14 + val_6;
        this.<Lerp>5__5 = val_6;
        val_11 = val_11.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<originalPos>5__2, y = val_4.y, z = V14.16B}, b:  new UnityEngine.Vector3() {x = this.<finalPos>5__3, y = V12.16B, z = val_4.z}, t:  this.<Lerp>5__5);
        val_19 = val_8.x;
        val_11.position = new UnityEngine.Vector3() {x = val_19, y = val_8.y, z = val_8.z};
        val_12 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_12;
        return (bool)val_12;
        label_13:
        val_17 = 64;
        val_18 = 1;
        label_14:
        val_18.SetScoreMultiplierText(comboType:  this.<>4__this.ComboType);
        if((this.<>4__this.ComboType) == 4)
        {
            goto label_21;
        }
        
        if((this.<>4__this.ComboType) == 3)
        {
            goto label_22;
        }
        
        if((this.<>4__this.ComboType) != 2)
        {
            goto label_23;
        }
        
        val_20 = val_11;
        val_21 = this.<>4__this.Score;
        val_22 = null;
        val_22 = null;
        val_23 = 1152921505152749840;
        goto label_29;
        label_21:
        val_20 = val_11;
        val_21 = this.<>4__this.Score;
        val_24 = null;
        val_24 = null;
        val_23 = 1152921505152749848;
        goto label_29;
        label_22:
        val_20 = val_11;
        val_21 = this.<>4__this.Score;
        val_25 = null;
        val_25 = null;
        val_23 = 1152921505152749844;
        label_29:
        val_23 = val_23 * (float)val_21;
        mem2[0] = (int)val_23;
        label_23:
        if(val_17 != 0)
        {
                val_13 = mem[21474836689];
            val_27 = this.<>4__this.Score;
        }
        else
        {
                val_26 = 208;
            val_13 = 496;
            val_27 = this.<>4__this.Score;
        }
        
        mem[208] = val_13 + val_27;
        int val_11 = mem[21474836801] + 200;
        val_11 = (this.<>4__this.Score) + val_11;
        mem2[0] = val_11;
        val_11 = val_11.gameObject;
        UnityEngine.Object.Destroy(obj:  val_11);
        val_12 = 0;
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
