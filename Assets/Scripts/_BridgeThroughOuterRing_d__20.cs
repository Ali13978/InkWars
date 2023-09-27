using UnityEngine;
private sealed class TargetBallCPU.<BridgeThroughOuterRing>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TargetBallCPU <>4__this;
    public UnityEngine.GameObject[] outerRingBalls;
    private bool <upperFlag>5__2;
    private bool <lowerFlag>5__3;
    private int <j>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TargetBallCPU.<BridgeThroughOuterRing>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_45;
        int val_46;
        var val_47;
        float val_48;
        float val_50;
        int val_51;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_45 = null;
        val_45 = null;
        int val_44 = LineController.BridgeStunP1;
        val_44 = val_44 + 1;
        LineController.BridgeStunP1 = val_44;
        this.<upperFlag>5__2 = true;
        this.<lowerFlag>5__3 = true;
        val_46 = 8;
        val_47 = this;
        this.<>4__this.isOuterBridgeRunning = true;
        this.<j>5__4 = val_46;
        goto label_6;
        label_1:
        val_47 = this;
        val_46 = (this.<j>5__4) - 1;
        this.<>1__state = 0;
        this.<j>5__4 = val_46;
        if((val_46 & 2147483648) != 0)
        {
            goto label_34;
        }
        
        label_6:
        if((this.<upperFlag>5__2) != true)
        {
                if((this.<lowerFlag>5__3) == false)
        {
            goto label_34;
        }
        
        }
        
        val_46 = this.outerRingBalls[(long)val_46];
        if(val_46 == 0)
        {
            goto label_14;
        }
        
        val_46 = this.outerRingBalls[this.<j>5__4].gameObject;
        if((val_46.CompareTag(tag:  this.<>4__this.gameObject.tag)) == true)
        {
            goto label_21;
        }
        
        label_14:
        if((this.<j>5__4) == 0)
        {
            goto label_34;
        }
        
        val_46 = this.outerRingBalls[(long)17 - (this.<j>5__4)];
        if(val_46 == 0)
        {
            goto label_34;
        }
        
        val_46 = this.outerRingBalls[(long)17 - (this.<j>5__4)].gameObject;
        if((val_46.CompareTag(tag:  this.<>4__this.gameObject.tag)) == false)
        {
            goto label_34;
        }
        
        label_21:
        val_46 = this.outerRingBalls[this.<j>5__4];
        if(val_46 == 0)
        {
            goto label_47;
        }
        
        val_46 = this.outerRingBalls[this.<j>5__4].gameObject;
        if(((val_46.CompareTag(tag:  this.<>4__this.gameObject.tag)) == false) || ((this.<upperFlag>5__2) == false))
        {
            goto label_47;
        }
        
        UnityEngine.AudioSource val_19 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip, volume:  1f);
        UnityEngine.Vector3 val_22 = this.outerRingBalls[this.<j>5__4].gameObject.transform.position;
        val_48 = val_22.z;
        UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.identity;
        val_50 = val_23.y;
        UnityEngine.GameObject val_24 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimation, position:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_48}, rotation:  new UnityEngine.Quaternion() {x = val_23.x, y = val_50, z = val_23.z, w = val_23.w});
        val_46 = this.outerRingBalls[this.<j>5__4];
        UnityEngine.Object.Destroy(obj:  val_46.gameObject);
        int val_49 = this.<>4__this.currentPops;
        val_49 = val_49 + 1;
        this.<>4__this.currentPops = val_49;
        goto label_64;
        label_34:
        val_51 = 0;
        this.<>4__this.isOuterBridgeRunning = false;
        return (bool)val_51;
        label_2:
        val_51 = 0;
        return (bool)val_51;
        label_47:
        this.<upperFlag>5__2 = false;
        label_64:
        if((this.<j>5__4) == 0)
        {
            goto label_81;
        }
        
        val_46 = this.outerRingBalls[(long)17 - (this.<j>5__4)];
        if(val_46 == 0)
        {
            goto label_81;
        }
        
        val_46 = this.outerRingBalls[(long)17 - (this.<j>5__4)].gameObject;
        if(((val_46.CompareTag(tag:  this.<>4__this.gameObject.tag)) == false) || ((this.<lowerFlag>5__3) == false))
        {
            goto label_81;
        }
        
        UnityEngine.AudioSource val_34 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip, volume:  1f);
        UnityEngine.Vector3 val_38 = this.outerRingBalls[(long)17 - (this.<j>5__4)].gameObject.transform.position;
        val_48 = val_38.z;
        UnityEngine.Quaternion val_39 = UnityEngine.Quaternion.identity;
        val_50 = val_39.y;
        UnityEngine.GameObject val_40 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.<>4__this.popAnimation, position:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_48}, rotation:  new UnityEngine.Quaternion() {x = val_39.x, y = val_50, z = val_39.z, w = val_39.w});
        val_46 = this.outerRingBalls[(long)17 - (this.<j>5__4)];
        UnityEngine.Object.Destroy(obj:  val_46.gameObject);
        int val_52 = this.<>4__this.currentPops;
        val_52 = val_52 + 1;
        this.<>4__this.currentPops = val_52;
        goto label_99;
        label_81:
        this.<lowerFlag>5__3 = false;
        label_99:
        val_51 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.destroyLag);
        this.<>1__state = val_51;
        return (bool)val_51;
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
