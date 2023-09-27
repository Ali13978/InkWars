using UnityEngine;
private sealed class LineControllerAI.<PopSequenceStun>d__76 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerAI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerAI.<PopSequenceStun>d__76(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.UI.Text val_17;
        float val_18;
        UnityEngine.UI.Text val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        int val_24;
        var val_25;
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
        if((this.<>4__this) == null)
        {
            goto label_4;
        }
        
        val_17 = this.<>4__this.stunCounter;
        this.<>4__this.attackFlag = false;
        val_18 = (this.<>4__this.playerStunVariable) + (-0.1f);
        this.<>4__this.stunSequenceFlag = true;
        this.<>4__this.shakeAmount = val_18;
        val_19 = this.<>4__this.stunCounter;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_6;
        }
        
        label_17:
        val_20 = this.<>4__this.stuntime;
        val_21 = this.<>4__this.stuntime;
        if(val_20 > 0f)
        {
            goto label_18;
        }
        
        this.<>4__this.CancelInvoke(methodName:  "ShakeSequenceAnimationCPU");
        goto label_8;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_9;
        }
        
        this.<>4__this.shake = this.<>4__this.cpuStunTime;
        goto label_10;
        label_4:
        val_22 = 6.95044E-43f;
        val_18 = val_22 + (-0.1f);
        mem[160] = val_18;
        mem[153] = 1;
        mem[36] = 0;
        val_19 = 256;
        val_17 = 456;
        label_5:
        string val_1 = this.<>4__this.cpuStunTime.ToString(format:  "F2");
        val_19.gameObject.SetActive(value:  true);
        if((this.<>4__this) == null)
        {
            goto label_15;
        }
        
        this.<>4__this.stuntime = this.<>4__this.cpuStunTime;
        goto label_16;
        label_9:
        mem[156] = 0;
        label_10:
        val_20 = 0f;
        this.<>4__this.InvokeRepeating(methodName:  "ShakeSequenceAnimationCPU", time:  val_20, repeatRate:  0.02f);
        if((this.<>4__this) != null)
        {
            goto label_17;
        }
        
        label_6:
        val_21 = 328;
        if((2.129974E-43f) > 0f)
        {
            goto label_18;
        }
        
        0.CancelInvoke(methodName:  "ShakeSequenceAnimationCPU");
        val_21 = 328;
        label_8:
        mem[328] = 0;
        this.<>4__this.playerChar.transform.position = new UnityEngine.Vector3() {x = this.<>4__this.originalPos, y = V9.16B, z = V10.16B};
        this.<>4__this.animController.pause = false;
        this.<>4__this.animController.PlayAnimation(newAnimName:  12, forceOverride:  false);
        this.<>4__this.animController.receiveDamageAnimEnded = false;
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_22 = val_6.r;
        val_23 = val_6.b;
        this.<>4__this.iconCPUActive.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_22, g = val_6.g, b = val_23, a = val_6.a};
        this.<>4__this.attackFlag = true;
        this.<>4__this.stunSequenceFlag = false;
        this.<>4__this.stunCounter.gameObject.SetActive(value:  false);
        this.<>4__this.shakeAmount = 0.1f;
        this.<>4__this.iconCPUActive.SetActive(value:  true);
        label_3:
        val_24 = 0;
        return (bool)val_24;
        label_18:
        if((this.<>4__this.animController.receiveDamageAnimEnded) != false)
        {
                this.<>4__this.animController.pause = true;
        }
        
        string val_8 = val_21.ToString(format:  "F2");
        val_22 = mem[this.<>4__this.stuntime];
        val_22 = val_21;
        float val_9 = UnityEngine.Time.deltaTime;
        val_9 = val_22 - val_9;
        mem2[0] = val_9;
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_24 = 1;
        return (bool)val_24;
        label_15:
        mem[328] = this.<>4__this.cpuStunTime;
        label_16:
        if((this.<>4__this.iconCPUActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount) == 1f)
        {
                UnityEngine.Color val_15 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_22 = val_15.r;
            val_23 = val_15.b;
            this.<>4__this.iconCPUActive.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_22, g = val_15.g, b = val_23, a = val_15.a};
        }
        
        this.<>4__this.animController.PlayAnimation(newAnimName:  13, forceOverride:  false);
        val_25 = null;
        val_25 = null;
        val_24 = 1;
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  1, modifiers:  0);
        UnityEngine.WaitForEndOfFrame val_16 = null;
        val_21 = val_16;
        val_16 = new UnityEngine.WaitForEndOfFrame();
        this.<>2__current = val_21;
        this.<>1__state = val_24;
        return (bool)val_24;
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
