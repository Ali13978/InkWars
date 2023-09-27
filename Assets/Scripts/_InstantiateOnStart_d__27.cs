using UnityEngine;
private sealed class BallSwipeCPU.<InstantiateOnStart>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BallSwipeCPU <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BallSwipeCPU.<InstantiateOnStart>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BallSwipeCPU val_24;
        float val_25;
        float val_26;
        UnityEngine.Object val_27;
        var val_28;
        UnityEngine.GameObject[] val_29;
        var val_30;
        int val_31;
        UnityEngine.Sprite val_32;
        UnityEngine.Sprite val_33;
        val_24 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Color val_3 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.playerBalls[0].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_25 = val_6.r;
        val_26 = val_6.b;
        this.<>4__this.playerBalls[1].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_25, g = val_6.g, b = val_26, a = val_6.a};
        goto label_14;
        label_1:
        this.<>1__state = 0;
        label_14:
        val_27 = 1152921505075376128;
        val_28 = null;
        val_28 = null;
        val_29 = InstanceAnimator.playerInnerRingBalls;
        if(val_29 == null)
        {
            goto label_21;
        }
        
        val_29 = InstanceAnimator.playerInnerRingBalls;
        if(val_29 == null)
        {
            goto label_20;
        }
        
        if(InstanceAnimator.playerInnerRingBalls.Length == 0)
        {
            goto label_21;
        }
        
        val_30 = null;
        val_30 = null;
        val_27 = mem[InstanceAnimator.playerInnerRingBalls + 32];
        val_27 = InstanceAnimator.playerInnerRingBalls + 32;
        if(val_27 != 0)
        {
            goto label_28;
        }
        
        label_21:
        val_31 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_31;
        return (bool)val_31;
        label_28:
        if(val_24 != null)
        {
                val_24.chooseBallColorTag();
        }
        else
        {
                0.chooseBallColorTag();
        }
        
        UnityEngine.UI.Image val_9 = this.<>4__this.playerBalls[0].gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_27 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_11 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_27);
        if(val_9 == null)
        {
            goto label_38;
        }
        
        if(val_11 == null)
        {
            goto label_39;
        }
        
        label_41:
        val_27 = (null == null) ? (val_11) : 0;
        goto label_40;
        label_38:
        if(val_11 != null)
        {
            goto label_41;
        }
        
        label_39:
        val_32 = 0;
        label_40:
        val_9.sprite = val_32;
        this.<>4__this.playerBalls[0].gameObject.tag = this.<>4__this.ballTag;
        val_24.chooseBallColorTag();
        UnityEngine.UI.Image val_14 = this.<>4__this.playerBalls[1].gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_30 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_16 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_30);
        if(val_14 == null)
        {
            goto label_50;
        }
        
        if(val_16 == null)
        {
            goto label_51;
        }
        
        label_53:
        val_30 = (null == null) ? (val_16) : 0;
        goto label_52;
        label_50:
        if(val_16 != null)
        {
            goto label_53;
        }
        
        label_51:
        val_33 = 0;
        label_52:
        val_14.sprite = val_33;
        val_27 = this.<>4__this.playerBalls[1].gameObject;
        val_27.tag = this.<>4__this.ballTag;
        UnityEngine.Color val_20 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.playerBalls[0].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a};
        val_24 = this.<>4__this.playerBalls[1].gameObject.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_23 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_25 = val_23.r;
        val_26 = val_23.b;
        val_24.color = new UnityEngine.Color() {r = val_25, g = val_23.g, b = val_26, a = val_23.a};
        label_2:
        val_31 = 0;
        return (bool)val_31;
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
