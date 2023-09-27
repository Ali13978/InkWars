using UnityEngine;
private sealed class InteractiveTutorialManager.<BallSwap>d__94 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool isCPU;
    public InteractiveTutorialManager <>4__this;
    public UnityEngine.Vector2 pos1;
    public UnityEngine.Vector2 pos2;
    public UnityEngine.Vector2 size1;
    public UnityEngine.Vector2 size2;
    private UnityEngine.GameObject[] <swipeArray>5__2;
    private float <startTime>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InteractiveTutorialManager.<BallSwap>d__94(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject[] val_26;
        float val_27;
        int val_28;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_26 = this;
        this.<swipeArray>5__2 = (this.isCPU == true) ? this.<>4__this.cpuBallsSwipe : this.<>4__this.playerBallsSwipe;
        if(this.isCPU != true)
        {
                this.<>4__this.flagSwipeBall = false;
        }
        
        this.<startTime>5__3 = 0f;
        val_27 = 0f;
        goto label_5;
        label_1:
        val_27 = this.<startTime>5__3;
        val_26 = this.<swipeArray>5__2;
        this.<>1__state = 0;
        label_5:
        if(val_27 <= 1.2f)
        {
            goto label_9;
        }
        
        mem2[0] = mem[this.<swipeArray>5__2] + 40.gameObject;
        mem2[0] = mem[this.<swipeArray>5__2] + 32.gameObject.gameObject;
        if(this.isCPU == false)
        {
            goto label_21;
        }
        
        label_2:
        val_28 = 0;
        return (bool)val_28;
        label_9:
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__3), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__3));
        UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
        mem[this.<swipeArray>5__2] + 32.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos2, b:  this.pos1, t:  this.<startTime>5__3), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos1, t:  this.<startTime>5__3));
        UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        mem[this.<swipeArray>5__2] + 40.transform.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__3), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__3));
        UnityEngine.Vector3 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
        mem[this.<swipeArray>5__2] + 32.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size2, b:  this.size1, t:  this.<startTime>5__3), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size1, t:  this.<startTime>5__3));
        UnityEngine.Vector3 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
        val_27 = val_24.x;
        mem[this.<swipeArray>5__2] + 40.transform.localScale = new UnityEngine.Vector3() {x = val_27, y = val_24.y, z = val_24.z};
        float val_26 = this.<startTime>5__3;
        val_26 = val_26 + 0.2f;
        this.<startTime>5__3 = val_26;
        val_28 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_28;
        return (bool)val_28;
        label_21:
        val_28 = 0;
        this.<>4__this.flagSwipeBall = true;
        return (bool)val_28;
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
