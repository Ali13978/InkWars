using UnityEngine;
private sealed class LineControllerP2.<PopSequenceStun>d__104 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerP2 <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<PopSequenceStun>d__104(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_19;
        UnityEngine.Vector3 val_20;
        float val_21;
        float val_22;
        int val_23;
        var val_25;
        int val_1 = (this.<>1__state) - 1;
        if(val_1 >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_2;
        }
        
        val_19 = this.<>4__this.stuntime;
        if((this.<>4__this.stuntime) > 0f)
        {
            goto label_3;
        }
        
        label_21:
        mem2[0] = 0;
        this.<>4__this.animController.pause = false;
        this.<>4__this.animController.PlayAnimation(newAnimName:  12, forceOverride:  false);
        this.<>4__this.animController.receiveDamageAnimEnded = false;
        UnityEngine.Color val_4 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        this.<>4__this.forceFlag = true;
        this.<>4__this.stunSequenceFlag = false;
        this.<>4__this.stunCounter.gameObject.SetActive(value:  false);
        this.<>4__this.CancelInvoke(methodName:  "ShakeSequenceAnimationPlayer");
        val_20 = this.<>4__this.originalPos;
        this.<>4__this.playerChar.transform.position = new UnityEngine.Vector3() {x = val_20, y = val_4.g, z = val_4.b};
        this.<>4__this.shakeAmount = 0.1f;
        this.<>4__this.iconPlayerActive.SetActive(value:  true);
        goto label_17;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_17;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_18;
        }
        
        val_22 = (this.<>4__this.cpuStunVariable) + (-0.1f);
        this.<>4__this.shakeAmount = val_22;
        goto label_19;
        label_17:
        val_23 = 0;
        return (bool)val_23;
        label_2:
        val_19 = 512;
        if((5.885454E-43f) <= 0f)
        {
            goto label_21;
        }
        
        label_3:
        if((this.<>4__this.animController.receiveDamageAnimEnded) != false)
        {
                this.<>4__this.animController.pause = true;
        }
        
        string val_7 = val_19.ToString(format:  "F2");
        val_20 = 5.885454E-43f;
        float val_8 = UnityEngine.Time.deltaTime;
        val_8 = val_20 - val_8;
        mem[512] = val_8;
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_23 = 1;
        return (bool)val_23;
        label_18:
        val_20 = 1.892007E-37f;
        val_22 = val_20 + (-0.1f);
        mem[316] = val_22;
        label_19:
        this.<>4__this.lineRenderer.GetComponent<UnityEngine.Animator>().Play(stateName:  "Red");
        mem2[0] = this.<>4__this.characterPos;
        mem2[0] = val_1;
        string val_10 = this.<>4__this.playerStunTime.ToString(format:  "F2");
        this.<>4__this.stunCounter.gameObject.SetActive(value:  true);
        this.<>4__this.stunSequenceFlag = true;
        this.<>4__this.forceFlag = false;
        this.<>4__this.stuntime = this.<>4__this.playerStunTime;
        if((this.<>4__this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount) == 1f)
        {
                UnityEngine.Color val_17 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_20 = val_17.r;
            val_21 = val_17.b;
            this.<>4__this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_20, g = val_17.g, b = val_21, a = val_17.a};
        }
        
        this.<>4__this.animController.PlayAnimation(newAnimName:  13, forceOverride:  false);
        this.<>4__this.shake = this.<>4__this.playerStunTime;
        this.<>4__this.InvokeRepeating(methodName:  "ShakeSequenceAnimationPlayer", time:  0f, repeatRate:  0.02f);
        val_25 = null;
        val_25 = null;
        val_23 = 1;
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  1, modifiers:  0);
        UnityEngine.WaitForEndOfFrame val_18 = null;
        val_19 = val_18;
        val_18 = new UnityEngine.WaitForEndOfFrame();
        this.<>2__current = val_19;
        this.<>1__state = val_23;
        return (bool)val_23;
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
