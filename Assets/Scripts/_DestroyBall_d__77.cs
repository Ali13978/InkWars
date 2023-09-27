using UnityEngine;
private sealed class LineControllerAI.<DestroyBall>d__77 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerAI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerAI.<DestroyBall>d__77(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_12;
        var val_13;
        float val_14;
        var val_15;
        var val_16;
        int val_17;
        val_12 = this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        UnityEngine.AudioSource val_3 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[2], volume:  1f);
        val_13 = static_value_032DD328;
        val_13 = static_value_032DD328;
        UnityEngine.Vector3 val_6 = static_value_032DD328 + 184.gameObject.transform.position;
        val_14 = val_6.x;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimationCPU, position:  new UnityEngine.Vector3() {x = val_14, y = val_6.y, z = val_6.z}, rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
        val_12 = mem[static_value_032DD328 + 184];
        val_12 = static_value_032DD328 + 184;
        UnityEngine.Object.Destroy(obj:  val_12.gameObject);
        goto label_19;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_19;
        }
        
        this.<>1__state = 0;
        val_15 = static_value_032DD328;
        val_15 = static_value_032DD328;
        mem2[0] = "TrashPop";
        val_16 = null;
        val_16 = null;
        val_14 = InstanceAnimator.UniversalX;
        if(val_14 != 4.46f)
        {
            goto label_24;
        }
        
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        val_17 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = val_17;
        return (bool)val_17;
        label_19:
        val_17 = 0;
        return (bool)val_17;
        label_24:
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.22f);
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = 2;
        return (bool)val_17;
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
