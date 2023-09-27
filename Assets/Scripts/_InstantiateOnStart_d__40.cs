using UnityEngine;
private sealed class ballSwipeScript.<InstantiateOnStart>d__40 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ballSwipeScript <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ballSwipeScript.<InstantiateOnStart>d__40(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ballSwipeScript val_32;
        float val_33;
        float val_34;
        UnityEngine.Object val_35;
        var val_36;
        UnityEngine.GameObject[] val_37;
        var val_38;
        int val_39;
        UnityEngine.Sprite val_40;
        UnityEngine.Sprite val_41;
        int val_42;
        val_32 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_68;
        }
        
        this.<>1__state = 0;
        UnityEngine.UI.Image val_2 = X21 + 32.gameObject.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_2.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_33 = val_6.r;
        val_34 = val_6.b;
        val_2.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_33, g = val_6.g, b = val_34, a = val_6.a};
        goto label_14;
        label_1:
        this.<>1__state = 0;
        label_14:
        val_35 = 1152921505075376128;
        val_36 = null;
        val_36 = null;
        val_37 = InstanceAnimator.innerRingBalls;
        if(val_37 == null)
        {
            goto label_21;
        }
        
        val_37 = InstanceAnimator.innerRingBalls;
        if(val_37 == null)
        {
            goto label_20;
        }
        
        if(InstanceAnimator.innerRingBalls.Length == 0)
        {
            goto label_21;
        }
        
        val_38 = null;
        val_38 = null;
        val_35 = mem[InstanceAnimator.innerRingBalls + 32];
        val_35 = InstanceAnimator.innerRingBalls + 32;
        if(val_35 != 0)
        {
            goto label_28;
        }
        
        label_21:
        val_39 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_39;
        return (bool)val_39;
        label_28:
        if(val_32 != null)
        {
                val_32.chooseBallColorTag();
        }
        else
        {
                0.chooseBallColorTag();
        }
        
        UnityEngine.UI.Image val_9 = this.<>4__this.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_32 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_11 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_32);
        if(val_9 == null)
        {
            goto label_38;
        }
        
        if(val_11 == null)
        {
            goto label_39;
        }
        
        label_41:
        val_32 = (null == null) ? (val_11) : 0;
        goto label_40;
        label_38:
        if(val_11 != null)
        {
            goto label_41;
        }
        
        label_39:
        val_40 = 0;
        label_40:
        val_9.sprite = val_40;
        val_9.gameObject.tag = this.<>4__this.ballTag;
        val_32.chooseBallColorTag();
        UnityEngine.UI.Image val_14 = this.<>4__this.ballTag.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_33 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_16 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_33);
        if(val_14 == null)
        {
            goto label_50;
        }
        
        if(val_16 == null)
        {
            goto label_51;
        }
        
        label_53:
        val_33 = (null == null) ? (val_16) : 0;
        goto label_52;
        label_50:
        if(val_16 != null)
        {
            goto label_53;
        }
        
        label_51:
        val_41 = 0;
        label_52:
        val_14.sprite = val_41;
        val_35 = val_14.gameObject;
        val_35.tag = this.<>4__this.ballTag;
        UnityEngine.UI.Image val_19 = this.<>4__this.ballTag.gameObject.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_20 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_19.color = new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a};
        UnityEngine.UI.Image val_22 = val_19.gameObject.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_23 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_33 = val_23.r;
        val_34 = val_23.b;
        val_22.color = new UnityEngine.Color() {r = val_33, g = val_23.g, b = val_34, a = val_23.a};
        if(NetworkManager_Custom.IsNetwork != false)
        {
                UnityEngine.GameObject val_25 = val_22.gameObject;
            string val_26 = val_25.tag;
            val_32 = val_26.GetTagAsInt(tag:  val_26);
            string val_29 = val_25.gameObject.tag;
            int[] val_31 = new int[2];
            val_35 = val_31;
            val_42 = val_31.Length;
            if(val_42 == 0)
        {
                val_42 = val_31.Length;
        }
        
            val_35[0] = val_32;
            val_35[0] = val_29.GetTagAsInt(tag:  val_29);
            NetworkBehaviour_PlayScene.syncMessageId.sendFunctionRPC(functionNumber:  30, intVariables:  val_31, string1:  "");
        }
        
        label_68:
        val_39 = 0;
        return (bool)val_39;
        label_20:
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
