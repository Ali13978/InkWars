using UnityEngine;
private sealed class LineController.<DestroyBall>d__211 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<DestroyBall>d__211(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Rigidbody2D val_13;
        float val_14;
        var val_15;
        var val_16;
        int val_17;
        val_13 = this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        UnityEngine.AudioSource val_3 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[5], volume:  1f);
        val_13 = this.<>4__this.playerBall;
        if((UnityEngine.Object.op_Implicit(exists:  val_13)) == false)
        {
            goto label_20;
        }
        
        UnityEngine.Vector3 val_7 = this.<>4__this.playerBall.gameObject.transform.position;
        val_14 = val_7.x;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimationPlayer, position:  new UnityEngine.Vector3() {x = val_14, y = val_7.y, z = val_7.z}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
        val_13 = this.<>4__this.playerBall;
        UnityEngine.Object.Destroy(obj:  val_13.gameObject);
        goto label_20;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_20;
        }
        
        this.<>1__state = 0;
        val_15 = null;
        val_15 = null;
        LineController.popTagPlayer = "TrashPop";
        val_16 = null;
        val_16 = null;
        val_14 = InstanceAnimator.UniversalX;
        if(val_14 != 4.46f)
        {
            goto label_25;
        }
        
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        val_17 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds();
        this.<>1__state = val_17;
        return (bool)val_17;
        label_20:
        val_17 = 0;
        return (bool)val_17;
        label_25:
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
