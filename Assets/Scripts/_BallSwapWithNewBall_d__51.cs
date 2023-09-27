using UnityEngine;
private sealed class ballSwipeScript.<BallSwapWithNewBall>d__51 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ballSwipeScript <>4__this;
    public UnityEngine.Vector2 pos1;
    public UnityEngine.Vector2 pos2;
    public UnityEngine.Vector2 size1;
    public UnityEngine.Vector2 size2;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ballSwipeScript.<BallSwapWithNewBall>d__51(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ballSwipeScript val_51;
        var val_52;
        int val_53;
        float val_54;
        UnityEngine.Sprite val_55;
        int val_56;
        var val_57;
        var val_58;
        var val_59;
        UnityEngine.Sprite val_60;
        val_51 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        val_52 = null;
        val_52 = null;
        ballSwipeScript.flag = false;
        val_53 = UnityEngine.Random.Range(min:  1, max:  21);
        if(val_51 == null)
        {
            goto label_6;
        }
        
        this.<>4__this.rainbowCounter = val_53;
        goto label_7;
        label_1:
        val_54 = this.<startTime>5__2;
        this.<>1__state = 0;
        if(val_51 != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_2:
        this.<startTime>5__2 = 0f;
        this.<>1__state = 0;
        val_54 = 0f;
        if(val_51 != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        if(val_54 <= 1.2f)
        {
            goto label_14;
        }
        
        mem2[0] = X21 + 32.gameObject;
        UnityEngine.GameObject val_3 = X21 + 32 + 40.gameObject;
        mem2[0] = val_3;
        UnityEngine.GameObject val_4 = val_3.gameObject;
        mem2[0] = val_4;
        UnityEngine.UI.Image val_6 = val_4.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_51 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_8 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_51);
        if(val_6 == null)
        {
            goto label_32;
        }
        
        if(val_8 == null)
        {
            goto label_33;
        }
        
        label_54:
        val_51 = (null == null) ? (val_8) : 0;
        goto label_34;
        label_3:
        val_56 = 0;
        return (bool)val_56;
        label_14:
        UnityEngine.Transform val_9 = X21 + 32.transform;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        val_9.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        UnityEngine.Transform val_14 = val_9.transform;
        UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos2, b:  this.pos1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
        val_14.position = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        val_57 = val_14.transform;
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
        val_57.localScale = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
        UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size2, b:  this.size1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
        val_54 = val_28.x;
        val_51.transform.localScale = new UnityEngine.Vector3() {x = val_54, y = val_28.y, z = val_28.z};
        float val_52 = this.<startTime>5__2;
        val_52 = val_52 + 0.2f;
        this.<startTime>5__2 = val_52;
        UnityEngine.WaitForFixedUpdate val_29 = null;
        val_51 = val_29;
        val_29 = new UnityEngine.WaitForFixedUpdate();
        this.<>2__current = val_51;
        this.<>1__state = 2;
        val_56 = 1;
        return (bool)val_56;
        label_32:
        if(val_8 != null)
        {
            goto label_54;
        }
        
        label_33:
        val_55 = 0;
        label_34:
        val_6.sprite = val_55;
        val_57 = val_6.gameObject;
        val_57.tag = this.<>4__this.ballTag;
        this.<>4__this.ballTag.gameObject.GetComponent<UnityEngine.Animator>().enabled = false;
        bool val_33 = NetworkManager_Custom.IsNetwork;
        if(val_33 != false)
        {
                val_33.sendTag(ballTag:  this.<>4__this.ballTag);
        }
        
        label_106:
        val_51 = 1152921505080434688;
        val_58 = null;
        val_58 = null;
        val_56 = 0;
        ballSwipeScript.flag = true;
        return (bool)val_56;
        label_6:
        mem[128] = val_53;
        val_53 = mem[128];
        label_7:
        if(val_53 > (this.<>4__this.rainbowFrequency))
        {
            goto label_68;
        }
        
        val_59 = null;
        val_59 = null;
        if(Character_GlobalInfo.gameMode != 3)
        {
            goto label_71;
        }
        
        label_68:
        val_57 = gameObject.GetComponent<UnityEngine.Animator>();
        val_57.enabled = false;
        val_51.chooseBallColorTag();
        UnityEngine.WaitForSeconds val_36 = null;
        val_51 = val_36;
        val_36 = new UnityEngine.WaitForSeconds(seconds:  0f);
        val_56 = 1;
        this.<>2__current = val_51;
        this.<>1__state = val_56;
        return (bool)val_56;
        label_71:
        UnityEngine.UI.Image val_38 = this.<>4__this.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_53 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_40 = UnityEngine.Resources.Load(path:  "Rainbow_Bubble", systemTypeInstance:  val_53);
        if(val_40 != null)
        {
                val_53 = (null == null) ? (val_40) : 0;
        }
        else
        {
                val_60 = 0;
        }
        
        val_38.sprite = val_60;
        UnityEngine.GameObject val_41 = val_38.gameObject;
        val_41.tag = "Rainbow_Bubble";
        UnityEngine.Animator val_43 = val_41.gameObject.GetComponent<UnityEngine.Animator>();
        val_43.enabled = true;
        UnityEngine.GameObject val_44 = val_43.gameObject;
        val_44.GetComponent<UnityEngine.Animator>().Play(stateName:  val_44.gameObject.tag + "_Anim");
        if(NetworkManager_Custom.IsNetwork == false)
        {
            goto label_106;
        }
        
        NetworkBehaviour_PlayScene.syncMessageId.sendFunctionRPC(functionNumber:  2, intVariables:  new int[1], string1:  "");
        goto label_106;
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
