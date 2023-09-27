using UnityEngine;
private sealed class BallSwipeVs.<BallSwap>d__48 : IEnumerator<object>, IEnumerator, IDisposable
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
    public BallSwipeVs.<BallSwap>d__48(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        int val_33;
        val_28 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.AudioSource val_2 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.ballSwipeClip, volume:  1f);
        val_29 = null;
        val_29 = null;
        val_30 = val_28;
        val_31 = 0;
        BallSwipeVs.flag = false;
        this.<startTime>5__2 = 0f;
        goto label_10;
        label_1:
        val_30 = val_28;
        this.<>1__state = 0;
        label_10:
        if((((this.<startTime>5__2) > 1.2f) ? 1 : 0) == 0)
        {
            goto label_14;
        }
        
        mem2[0] = static_value_03331020.gameObject;
        UnityEngine.GameObject val_5 = static_value_03331020 + 40.gameObject;
        mem2[0] = val_5;
        mem2[0] = val_5.gameObject;
        val_28 = 1152921505080807424;
        val_32 = null;
        val_32 = null;
        val_33 = 0;
        BallSwipeVs.flag = true;
        return (bool)val_33;
        label_2:
        val_33 = 0;
        return (bool)val_33;
        label_14:
        UnityEngine.Transform val_7 = static_value_03331020.transform;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        val_7.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Transform val_12 = val_7.transform;
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos2, b:  this.pos1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
        val_12.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        UnityEngine.Transform val_17 = val_12.transform;
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
        val_17.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size2, b:  this.size1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
        val_17.transform.localScale = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
        float val_28 = this.<startTime>5__2;
        val_28 = val_28 + 0.2f;
        this.<startTime>5__2 = val_28;
        val_33 = 1;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = val_33;
        return (bool)val_33;
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
