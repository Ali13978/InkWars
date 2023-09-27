using UnityEngine;
private sealed class ballSwipeScript.<BallSwapSpecial>d__49 : IEnumerator<object>, IEnumerator, IDisposable
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
    public ballSwipeScript.<BallSwapSpecial>d__49(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_64;
        int val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        val_64 = this;
        if((this.<>1__state) != 1)
        {
                val_65 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_65;
        }
        
            this.<>1__state = 0;
            UnityEngine.UI.Image val_2 = mem[53674016].gameObject.GetComponent<UnityEngine.UI.Image>();
            val_2.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_2.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_66 = null;
            val_66 = null;
            val_67 = val_64;
            val_68 = 0;
            ballSwipeScript.flag = false;
            this.<startTime>5__2 = 0f;
        }
        else
        {
                val_67 = val_64;
            this.<>1__state = 0;
            var val_5 = ((this.<startTime>5__2) > 1.2f) ? 1 : 0;
        }
        
        if(mem[53674016] == 0)
        {
            goto label_20;
        }
        
        if(val_5 == 0)
        {
            goto label_21;
        }
        
        label_92:
        UnityEngine.GameObject val_6 = mem[53674016].gameObject;
        mem2[0] = val_6;
        UnityEngine.GameObject val_7 = val_6.gameObject;
        string val_9 = mem[53674016] + 32.gameObject.tag;
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
        
            val_69 = null;
            val_69 = null;
            string val_29 = val_17.gameObject.tag + "_Count";
            DataStructs.UserDataDictionary.Items.AddSpecialBallCountById(id:  val_29, addition:  1);
            string val_32 = val_29.gameObject.tag + "_Count";
            int val_33 = DataStructs.UserDataDictionary.Items.GetSpecialBallCountById(id:  val_32);
            DataStructs.UserDataDictionary.Stats.AddSpecialBallUsedById(id:  val_32.gameObject.tag + "_Used", addition:  0);
            this.<>4__this.isSpecialHit = false;
        }
        
        label_68:
        if((this.<>4__this.specialBallSelectorCount) == 2)
        {
            goto label_86;
        }
        
        if((this.<>4__this.specialBallSelectorCount) == 1)
        {
            goto label_87;
        }
        
        val_70 = null;
        val_70 = null;
        val_71 = DataStructs.UserDataDictionary.Items;
        val_72 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_37 = val_71.ColorEraserBall;
        goto label_114;
        label_20:
        if(val_5 != 0)
        {
            goto label_92;
        }
        
        label_21:
        UnityEngine.Transform val_38 = mem[53674016].transform;
        UnityEngine.Vector2 val_41 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_42 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y});
        val_38.position = new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z};
        UnityEngine.Transform val_43 = val_38.transform;
        UnityEngine.Vector2 val_46 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos2, b:  this.pos1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_47 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_46.x, y = val_46.y});
        val_43.position = new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z};
        UnityEngine.Transform val_48 = val_43.transform;
        UnityEngine.Vector2 val_51 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_52 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_51.x, y = val_51.y});
        val_48.localScale = new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z};
        UnityEngine.Vector2 val_56 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size2, b:  this.size1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_57 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_56.x, y = val_56.y});
        val_48.transform.localScale = new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z};
        float val_64 = this.<startTime>5__2;
        val_64 = val_64 + 0.2f;
        this.<startTime>5__2 = val_64;
        val_65 = 1;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = val_65;
        return (bool)val_65;
        label_86:
        val_73 = null;
        val_73 = null;
        val_71 = DataStructs.UserDataDictionary.Items;
        val_72 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_59 = val_71.StunnerBall;
        goto label_114;
        label_87:
        val_74 = null;
        val_74 = null;
        val_71 = DataStructs.UserDataDictionary.Items;
        val_72 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_60 = val_71.IronBall;
        label_114:
        string val_63 = "   " + CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_60.currentCryptoKey, hiddenValue = val_60.hiddenValue, fakeValue = val_60.fakeValue, inited = val_60.inited}).ToString()(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_60.currentCryptoKey, hiddenValue = val_60.hiddenValue, fakeValue = val_60.fakeValue, inited = val_60.inited}).ToString());
        val_64 = 1152921505080434688;
        val_75 = null;
        val_75 = null;
        val_65 = 0;
        ballSwipeScript.flag = true;
        return (bool)val_65;
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
