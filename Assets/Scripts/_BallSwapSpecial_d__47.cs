using UnityEngine;
private sealed class BallSwipeVs.<BallSwapSpecial>d__47 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BallSwipeVs <>4__this;
    public UnityEngine.Vector2 pos1;
    public UnityEngine.Vector2 pos2;
    public UnityEngine.Vector2 size1;
    public UnityEngine.Vector2 size2;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BallSwipeVs.<BallSwapSpecial>d__47(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_60;
        BallSwipeVs val_61;
        int val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        val_60 = this;
        val_61 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_62 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_62;
        }
        
            this.<>1__state = 0;
            UnityEngine.UI.Image val_2 = static_value_03331020.gameObject.GetComponent<UnityEngine.UI.Image>();
            val_2.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_2.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_63 = null;
            val_63 = null;
            val_64 = val_60;
            val_65 = 0;
            BallSwipeVs.flag = false;
            this.<startTime>5__2 = 0f;
        }
        else
        {
                val_64 = val_60;
            this.<>1__state = 0;
        }
        
        if((((this.<startTime>5__2) > 1.2f) ? 1 : 0) == 0)
        {
            goto label_21;
        }
        
        UnityEngine.GameObject val_6 = static_value_03331020.gameObject;
        mem2[0] = val_6;
        UnityEngine.GameObject val_7 = val_6.gameObject;
        string val_9 = static_value_03331020 + 32.gameObject.tag;
        val_7.tag = val_9;
        UnityEngine.GameObject val_10 = val_7.gameObject;
        mem2[0] = val_10;
        UnityEngine.GameObject val_11 = val_10.gameObject;
        string val_13 = val_9.gameObject.tag;
        val_11.tag = val_13;
        UnityEngine.GameObject val_14 = val_11.gameObject;
        mem2[0] = val_14;
        UnityEngine.GameObject val_15 = val_14.gameObject;
        string val_17 = val_13.gameObject.tag;
        val_15.tag = val_17;
        if((this.<>4__this.isSpecialHit) != true)
        {
                UnityEngine.GameObject val_18 = val_15.gameObject;
            if((System.String.op_Equality(a:  val_18.tag, b:  "Color_Eraser_Ball")) != true)
        {
                UnityEngine.GameObject val_21 = val_18.gameObject;
            if((System.String.op_Equality(a:  val_21.tag, b:  "Iron_Ball")) != true)
        {
                if((System.String.op_Equality(a:  val_21.gameObject.tag, b:  "Stunner_Ball")) == false)
        {
            goto label_68;
        }
        
        }
        
        }
        
            val_66 = null;
            val_66 = null;
            string val_29 = val_17.gameObject.tag + "_Count";
            DataStructs.UserDataDictionary.Items.AddSpecialBallCountById(id:  val_29, addition:  1);
            DataStructs.UserDataDictionary.Stats.AddSpecialBallUsedById(id:  val_29.gameObject.tag + "_Used", addition:  0);
            this.<>4__this.isSpecialHit = false;
        }
        
        label_68:
        val_67 = null;
        val_67 = null;
        var val_33 = 1152921505151520768 + ((this.<>4__this.specialBallSelectorCount) << 3);
        val_61 = (1152921505151520768 + (this.<>4__this.specialBallSelectorCount) << 3) + 32.name((1152921505151520768 + (this.<>4__this.specialBallSelectorCount) << 3) + 32.name) + "_Count";
        string val_38 = "x" + DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  val_61).ToString()(DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  val_61).ToString());
        val_60 = 1152921505080807424;
        val_68 = null;
        val_68 = null;
        val_62 = 0;
        BallSwipeVs.flag = true;
        return (bool)val_62;
        label_21:
        UnityEngine.Transform val_39 = static_value_03331020.transform;
        UnityEngine.Vector2 val_42 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_43 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y});
        val_39.position = new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z};
        UnityEngine.Transform val_44 = val_39.transform;
        UnityEngine.Vector2 val_47 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos2, b:  this.pos1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_48 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_47.x, y = val_47.y});
        val_44.position = new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z};
        UnityEngine.Transform val_49 = val_44.transform;
        UnityEngine.Vector2 val_52 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_53 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_52.x, y = val_52.y});
        val_49.localScale = new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z};
        UnityEngine.Vector2 val_57 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size2, b:  this.size1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_58 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_57.x, y = val_57.y});
        val_49.transform.localScale = new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z};
        float val_60 = this.<startTime>5__2;
        val_60 = val_60 + 0.2f;
        this.<startTime>5__2 = val_60;
        val_62 = 1;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = val_62;
        return (bool)val_62;
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
