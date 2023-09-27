using UnityEngine;
private sealed class BallSwipeVs.<InstantiateOnStart>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BallSwipeVs <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BallSwipeVs.<InstantiateOnStart>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BallSwipeVs val_25;
        float val_26;
        float val_27;
        UnityEngine.Object val_28;
        var val_29;
        UnityEngine.GameObject[] val_30;
        var val_31;
        int val_32;
        UnityEngine.Sprite val_33;
        UnityEngine.Sprite val_34;
        val_25 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        if(NetworkManager_Custom.IsNetwork == true)
        {
            goto label_3;
        }
        
        UnityEngine.UI.Image val_3 = X21 + 32.gameObject.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_4 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_3.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        UnityEngine.Color val_7 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_26 = val_7.r;
        val_27 = val_7.b;
        val_3.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_26, g = val_7.g, b = val_27, a = val_7.a};
        goto label_15;
        label_1:
        this.<>1__state = 0;
        label_15:
        val_28 = 1152921505075376128;
        val_29 = null;
        val_29 = null;
        val_30 = InstanceAnimator.playerInnerRingBalls;
        if(val_30 == null)
        {
            goto label_22;
        }
        
        val_30 = InstanceAnimator.playerInnerRingBalls;
        if(val_30 == null)
        {
            goto label_21;
        }
        
        if(InstanceAnimator.playerInnerRingBalls.Length == 0)
        {
            goto label_22;
        }
        
        val_31 = null;
        val_31 = null;
        val_28 = mem[InstanceAnimator.playerInnerRingBalls + 32];
        val_28 = InstanceAnimator.playerInnerRingBalls + 32;
        if(val_28 != 0)
        {
            goto label_29;
        }
        
        label_22:
        val_32 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_32;
        return (bool)val_32;
        label_29:
        if(val_25 != null)
        {
                val_25.chooseBallColorTag();
        }
        else
        {
                0.chooseBallColorTag();
        }
        
        UnityEngine.UI.Image val_10 = this.<>4__this.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_25 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_12 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_25);
        if(val_12 != null)
        {
                val_25 = (null == null) ? (val_12) : 0;
        }
        else
        {
                val_33 = 0;
        }
        
        val_10.sprite = val_33;
        val_10.gameObject.tag = this.<>4__this.ballTag;
        val_25.chooseBallColorTag();
        UnityEngine.UI.Image val_15 = this.<>4__this.ballTag.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_26 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_17 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_26);
        if(val_17 != null)
        {
                val_26 = (null == null) ? (val_17) : 0;
        }
        else
        {
                val_34 = 0;
        }
        
        val_15.sprite = val_34;
        val_28 = val_15.gameObject;
        val_28.tag = this.<>4__this.ballTag;
        UnityEngine.Color val_21 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.ballTag.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_21.r, g = val_21.g, b = val_21.b, a = val_21.a};
        val_25 = val_25.gameObject.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_24 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_26 = val_24.r;
        val_27 = val_24.b;
        val_25.color = new UnityEngine.Color() {r = val_26, g = val_24.g, b = val_27, a = val_24.a};
        label_3:
        val_32 = 0;
        return (bool)val_32;
        label_21:
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
