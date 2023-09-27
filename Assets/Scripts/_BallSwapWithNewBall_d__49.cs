using UnityEngine;
private sealed class BallSwipeVs.<BallSwapWithNewBall>d__49 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BallSwipeVs <>4__this;
    public int networkTag;
    public UnityEngine.Vector2 pos1;
    public UnityEngine.Vector2 pos2;
    public UnityEngine.Vector2 size1;
    public UnityEngine.Vector2 size2;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BallSwipeVs.<BallSwapWithNewBall>d__49(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BallSwipeVs val_52;
        var val_53;
        var val_54;
        var val_55;
        int val_56;
        float val_57;
        UnityEngine.Sprite val_58;
        UnityEngine.Sprite val_59;
        var val_60;
        val_52 = this.<>4__this;
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
        val_53 = null;
        val_53 = null;
        BallSwipeVs.flag = false;
        this.<>4__this.rainbowCounter = UnityEngine.Random.Range(min:  1, max:  21);
        if(NetworkManager_Custom.IsNetwork != false)
        {
                if(this.networkTag == 0)
        {
            goto label_13;
        }
        
        }
        
        if((NetworkManager_Custom.IsNetwork == true) || ((this.<>4__this.rainbowCounter) > (this.<>4__this.rainbowFrequency)))
        {
            goto label_10;
        }
        
        val_54 = null;
        val_54 = null;
        if(Character_GlobalInfo.gameMode != 3)
        {
            goto label_13;
        }
        
        label_10:
        val_55 = gameObject.GetComponent<UnityEngine.Animator>();
        val_55.enabled = false;
        if(NetworkManager_Custom.IsNetwork != true)
        {
                val_52.chooseBallColorTag();
        }
        
        UnityEngine.WaitForSeconds val_7 = null;
        val_52 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  0f);
        val_56 = 1;
        this.<>2__current = val_52;
        this.<>1__state = val_56;
        return (bool)val_56;
        label_1:
        val_57 = this.<startTime>5__2;
        this.<>1__state = 0;
        if(val_52 != null)
        {
            goto label_23;
        }
        
        goto label_22;
        label_2:
        this.<startTime>5__2 = 0f;
        this.<>1__state = 0;
        val_57 = 0f;
        if(val_52 != null)
        {
            goto label_23;
        }
        
        label_22:
        label_23:
        if(val_57 <= 1.2f)
        {
            goto label_27;
        }
        
        mem2[0] = X21 + 32.gameObject;
        UnityEngine.GameObject val_9 = X22 + 40.gameObject;
        mem2[0] = val_9;
        mem2[0] = val_9.gameObject;
        if(NetworkManager_Custom.IsNetwork != false)
        {
                val_52.receiveTag(tag:  this.networkTag);
        }
        
        UnityEngine.UI.Image val_13 = this.networkTag.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_52 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_15 = UnityEngine.Resources.Load(path:  this.<>4__this.ballTagColor, systemTypeInstance:  val_52);
        if(val_13 == null)
        {
            goto label_46;
        }
        
        if(val_15 == null)
        {
            goto label_47;
        }
        
        label_68:
        val_52 = (null == null) ? (val_15) : 0;
        goto label_48;
        label_3:
        val_56 = 0;
        return (bool)val_56;
        label_27:
        UnityEngine.Transform val_16 = X21 + 32.transform;
        UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos1, b:  this.pos2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
        val_16.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Transform val_21 = val_16.transform;
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.pos2, b:  this.pos1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.pos1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
        val_21.position = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        val_55 = val_21.transform;
        UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size1, b:  this.size2, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size2, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
        val_55.localScale = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
        UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.size2, b:  this.size1, t:  this.<startTime>5__2), y:  UnityEngine.Mathf.Lerp(a:  V3.16B, b:  this.size1, t:  this.<startTime>5__2));
        UnityEngine.Vector3 val_35 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_34.x, y = val_34.y});
        val_57 = val_35.x;
        val_52.transform.localScale = new UnityEngine.Vector3() {x = val_57, y = val_35.y, z = val_35.z};
        float val_53 = this.<startTime>5__2;
        val_53 = val_53 + 0.2f;
        this.<startTime>5__2 = val_53;
        UnityEngine.WaitForFixedUpdate val_36 = null;
        val_52 = val_36;
        val_36 = new UnityEngine.WaitForFixedUpdate();
        this.<>2__current = val_52;
        this.<>1__state = 2;
        val_56 = 1;
        return (bool)val_56;
        label_46:
        if(val_15 != null)
        {
            goto label_68;
        }
        
        label_47:
        val_58 = 0;
        label_48:
        val_13.sprite = val_58;
        val_55 = val_13.gameObject;
        val_55.tag = this.<>4__this.ballTag;
        val_52.gameObject.GetComponent<UnityEngine.Animator>().enabled = false;
        goto label_78;
        label_13:
        UnityEngine.UI.Image val_41 = this.<>4__this.gameObject.GetComponent<UnityEngine.UI.Image>();
        System.Type val_54 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_43 = UnityEngine.Resources.Load(path:  "Rainbow_Bubble", systemTypeInstance:  val_54);
        if(val_43 != null)
        {
                val_54 = (null == null) ? (val_43) : 0;
        }
        else
        {
                val_59 = 0;
        }
        
        val_41.sprite = val_59;
        UnityEngine.GameObject val_44 = val_41.gameObject;
        val_44.tag = "Rainbow_Bubble";
        val_55 = 1152921526109146016;
        UnityEngine.Animator val_46 = val_44.gameObject.GetComponent<UnityEngine.Animator>();
        val_46.enabled = true;
        UnityEngine.GameObject val_47 = val_46.gameObject;
        val_47.GetComponent<UnityEngine.Animator>().Play(stateName:  val_47.gameObject.tag + "_Anim");
        label_78:
        val_52 = 1152921505080807424;
        val_60 = null;
        val_60 = null;
        val_56 = 0;
        BallSwipeVs.flag = true;
        return (bool)val_56;
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
