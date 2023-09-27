using UnityEngine;
private sealed class InteractiveTutorialManager.<DestroyBall>d__89 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InteractiveTutorialManager <>4__this;
    public bool isCPU;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InteractiveTutorialManager.<DestroyBall>d__89(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_18;
        var val_19;
        var val_20;
        int val_21;
        int val_22;
        var val_23;
        float val_24;
        int val_25;
        var val_26;
        UnityEngine.Rigidbody2D val_27;
        val_18 = this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        val_19 = null;
        val_19 = null;
        if((System.String.op_Equality(a:  DemoManager.currentSequence, b:  "TrashABubble")) == false)
        {
            goto label_7;
        }
        
        val_20 = null;
        val_20 = null;
        if(DemoManager.touchBoolForDemo == false)
        {
            goto label_7;
        }
        
        if((this.<>4__this.demoManager.GetComponent<DemoManager>()) == null)
        {
            goto label_10;
        }
        
        val_21 = val_3.counterForTrash;
        val_22 = val_3.counterForTrash;
        goto label_11;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_12;
        }
        
        this.<>1__state = 0;
        val_23 = null;
        val_23 = null;
        val_24 = InstanceAnimator.UniversalX;
        if(val_24 != 4.46f)
        {
            goto label_15;
        }
        
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        val_25 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = val_25;
        return (bool)val_25;
        label_7:
        if((this.<>4__this) == null)
        {
            goto label_17;
        }
        
        val_26 = 0;
        if(this.isCPU == false)
        {
            goto label_21;
        }
        
        label_23:
        val_27 = this.<>4__this.cpuBall;
        goto label_19;
        label_17:
        val_26 = 1;
        if(this.isCPU == true)
        {
            goto label_23;
        }
        
        goto label_21;
        label_15:
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.22f);
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = 2;
        val_25 = 1;
        return (bool)val_25;
        label_10:
        val_22 = 312;
        val_21 = 48980544;
        label_11:
        mem[312] = 48980545;
        val_26 = 0;
        if(this.isCPU == true)
        {
            goto label_23;
        }
        
        label_21:
        val_27 = this.<>4__this.playerBall;
        label_19:
        TutorialDataManager val_8 = TutorialDataManager.Instance;
        UnityEngine.AudioSource val_9 = GameAudio.sound.PlayOneShot(clip:  val_8.PopClip[5], volume:  1f);
        if(this.isCPU == false)
        {
            goto label_30;
        }
        
        if(val_26 == 0)
        {
            goto label_43;
        }
        
        label_42:
        label_43:
        val_18 = this.<>4__this.popAnimationPlayer;
        UnityEngine.Vector3 val_12 = val_27.gameObject.transform.position;
        val_24 = val_12.x;
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_14 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_18, position:  new UnityEngine.Vector3() {x = val_24, y = val_12.y, z = val_12.z}, rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w});
        UnityEngine.Object.Destroy(obj:  val_27.gameObject);
        label_12:
        val_25 = 0;
        return (bool)val_25;
        label_30:
        InteractiveTutorialManager.popTagPlayer = val_27.gameObject.tag;
        if(val_26 != 0)
        {
            goto label_42;
        }
        
        goto label_43;
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
