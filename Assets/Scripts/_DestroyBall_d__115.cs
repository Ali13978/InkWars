using UnityEngine;
private sealed class LineControllerP2.<DestroyBall>d__115 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerP2 <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<DestroyBall>d__115(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Rigidbody2D val_12;
        float val_13;
        var val_14;
        var val_15;
        int val_16;
        val_12 = this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        UnityEngine.AudioSource val_3 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[5], volume:  1f);
        UnityEngine.Vector3 val_6 = this.<>4__this.playerBall.gameObject.transform.position;
        val_13 = val_6.x;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_13, y = val_6.y, z = val_6.z}, rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
        val_12 = this.<>4__this.playerBall;
        UnityEngine.Object.Destroy(obj:  val_12.gameObject);
        goto label_17;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_17;
        }
        
        this.<>1__state = 0;
        val_14 = null;
        val_14 = null;
        LineControllerP2.popTagPlayer = "TrashPop";
        val_15 = null;
        val_15 = null;
        val_13 = InstanceAnimator.UniversalX;
        if(val_13 != 4.46f)
        {
            goto label_22;
        }
        
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        val_16 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = val_16;
        return (bool)val_16;
        label_17:
        val_16 = 0;
        return (bool)val_16;
        label_22:
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.22f);
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = 2;
        return (bool)val_16;
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
