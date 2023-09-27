using UnityEngine;
private sealed class BallSwipeCPU.<BallSwapWithNewBall>d__31 : IEnumerator<object>, IEnumerator, IDisposable
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
    public BallSwipeCPU.<BallSwapWithNewBall>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BallSwipeCPU val_56;
        int val_57;
        var val_58;
        var val_59;
        int val_60;
        var val_61;
        GameMode val_62;
        var val_63;
        UnityEngine.Sprite val_64;
        UnityEngine.Sprite val_65;
        val_56 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        BallSwipeCPU.flag = false;
        val_57 = UnityEngine.Random.Range(min:  1, max:  21);
        if(val_56 == null)
        {
            goto label_3;
        }
        
        this.<>4__this.rainbowCounter = val_57;
        goto label_4;
        label_1:
        val_58 = this;
        this.<>1__state = 0;
        var val_2 = ((this.<startTime>5__2) > 1.2f) ? 1 : 0;
        if(val_56 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_2:
        val_60 = 0;
        return (bool)val_60;
        label_3:
        mem[72] = val_57;
        val_57 = mem[72];
        label_4:
        if(val_57 > (this.<>4__this.rainbowFrequency))
        {
            goto label_8;
        }
        
        val_61 = null;
        val_61 = null;
        val_62 = Character_GlobalInfo.gameMode;
        if(val_62 != 3)
        {
            goto label_11;
        }
        
        label_8:
        this.<>4__this.playerBalls[0].gameObject.GetComponent<UnityEngine.Animator>().enabled = false;
        val_58 = this;
        val_59 = 0;
        this.<startTime>5__2 = 0f;
        label_6:
        UnityEngine.GameObject val_57 = this.<>4__this.playerBalls[0];
        if(val_57 == null)
        {
            goto label_19;
        }
        
        if(val_59 == 0)
        {
            goto label_20;
        }
        
        label_41:
        this.<>4__this.swiper = val_57.gameObject;
        this.<>4__this.playerBalls[0] = this.<>4__this.playerBalls[1].gameObject;
        this.<>4__this.playerBalls[1] = this.<>4__this.swiper.gameObject;
        val_56.chooseBallColorTag();
        UnityEngine.UI.Image val_9 = this.<>4__this.playerBalls[1].gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_60 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_63 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_60);
        if(val_9 == null)
        {
            goto label_38;
        }
        
        if(val_63 == null)
        {
            goto label_39;
        }
        
        label_60:
        val_60 = (null == null) ? (val_63) : 0;
        goto label_40;
        label_19:
        if(val_59 != 0)
        {
            goto label_41;
        }
        
        label_20:
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
        val_57.transform.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos2, b:  this.pos1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
        this.<>4__this.playerBalls[1].transform.position = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        val_63 = this.<>4__this.playerBalls[0].transform;
        UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
        val_63.localScale = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
        UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size2, b:  this.size1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_31 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y});
        this.<>4__this.playerBalls[1].transform.localScale = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
        float val_64 = this.<startTime>5__2;
        val_64 = val_64 + 0.2f;
        this.<startTime>5__2 = val_64;
        UnityEngine.WaitForFixedUpdate val_32 = null;
        val_56 = val_32;
        val_32 = new UnityEngine.WaitForFixedUpdate();
        val_60 = 1;
        this.<>2__current = val_56;
        this.<>1__state = val_60;
        return (bool)val_60;
        label_38:
        if(val_63 != null)
        {
            goto label_60;
        }
        
        label_39:
        val_64 = 0;
        label_40:
        val_9.sprite = val_64;
        val_56 = this.<>4__this.ballTag;
        this.<>4__this.playerBalls[1].gameObject.tag = val_56;
        label_105:
        val_60 = 0;
        BallSwipeCPU.flag = true;
        return (bool)val_60;
        label_11:
        if((this.<>4__this.specialBallFlag) == false)
        {
            goto label_68;
        }
        
        val_62 = Character_GlobalInfo.gameMode;
        if(val_62 != 4)
        {
            goto label_68;
        }
        
        int val_34 = UnityEngine.Random.Range(min:  1, max:  3);
        if(val_34 == 2)
        {
            goto label_69;
        }
        
        if(val_34 == 1)
        {
            goto label_70;
        }
        
        label_68:
        label_119:
        System.Type val_67 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_38 = UnityEngine.Resources.Load(path:  "Rainbow_Bubble", systemTypeInstance:  val_67);
        if(val_38 != null)
        {
                val_67 = (null == null) ? (val_38) : 0;
        }
        else
        {
                val_65 = 0;
        }
        
        this.<>4__this.playerBalls[0].gameObject.GetComponent<UnityEngine.UI.Image>().sprite = val_65;
        this.<>4__this + 24 + 32.gameObject.tag = "Rainbow_Bubble";
        bool val_42 = System.String.op_Inequality(a:  this.<>4__this + 24 + 32.gameObject.tag, b:  "Iron_Ball");
        UnityEngine.Animator val_44 = this.<>4__this + 24 + 32.gameObject.GetComponent<UnityEngine.Animator>();
        if(val_44 == null)
        {
            goto label_92;
        }
        
        if(val_42 == false)
        {
            goto label_93;
        }
        
        label_104:
        val_44.enabled = true;
        this.<>4__this + 24 + 32.gameObject.GetComponent<UnityEngine.Animator>().Play(stateName:  this.<>4__this + 24 + 32.gameObject.tag(this.<>4__this + 24 + 32.gameObject.tag) + "_Anim");
        goto label_105;
        label_92:
        if(val_42 == true)
        {
            goto label_104;
        }
        
        label_93:
        val_44.enabled = false;
        goto label_105;
        label_69:
        UnityEngine.UI.Image val_51 = this.<>4__this.playerBalls[0].gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_52 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        goto label_119;
        label_70:
        UnityEngine.UI.Image val_54 = this.<>4__this.playerBalls[0].gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_55 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        goto label_119;
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
