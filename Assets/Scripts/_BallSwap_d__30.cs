using UnityEngine;
private sealed class BallSwipeCPU.<BallSwap>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BallSwipeCPU <>4__this;
    public UnityEngine.Vector2 pos1;
    public UnityEngine.Vector2 pos2;
    public UnityEngine.Vector2 size1;
    public UnityEngine.Vector2 size2;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BallSwipeCPU.<BallSwap>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_28;
        var val_29;
        var val_30;
        int val_31;
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
        val_29 = val_28;
        val_30 = 0;
        BallSwipeCPU.flag = false;
        this.<startTime>5__2 = 0f;
        goto label_8;
        label_1:
        val_29 = val_28;
        this.<>1__state = 0;
        var val_3 = ((this.<startTime>5__2) > 1.2f) ? 1 : 0;
        label_8:
        UnityEngine.GameObject val_28 = this.<>4__this.playerBalls[0];
        if(val_28 == null)
        {
            goto label_11;
        }
        
        if(val_3 == 0)
        {
            goto label_12;
        }
        
        label_26:
        this.<>4__this.swiper = val_28.gameObject;
        this.<>4__this.playerBalls[0] = this.<>4__this.playerBalls[1].gameObject;
        val_28 = this.<>4__this.swiper.gameObject;
        this.<>4__this.playerBalls[1] = val_28;
        val_31 = 0;
        BallSwipeCPU.flag = true;
        return (bool)val_31;
        label_2:
        val_31 = 0;
        return (bool)val_31;
        label_11:
        if(val_3 != 0)
        {
            goto label_26;
        }
        
        label_12:
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        val_28.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos2, b:  this.pos1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
        this.<>4__this.playerBalls[1].transform.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
        this.<>4__this.playerBalls[0].transform.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size2, b:  this.size1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
        this.<>4__this.playerBalls[1].transform.localScale = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
        float val_33 = this.<startTime>5__2;
        val_33 = val_33 + 0.2f;
        this.<startTime>5__2 = val_33;
        val_31 = 1;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = val_31;
        return (bool)val_31;
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
