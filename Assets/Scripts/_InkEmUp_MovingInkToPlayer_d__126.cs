using UnityEngine;
private sealed class View_Core.<InkEmUp_MovingInkToPlayer>d__126 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_Core <>4__this;
    private bool <readyToShoot>5__2;
    private float <timeout>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_Core.<InkEmUp_MovingInkToPlayer>d__126(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_10;
        View_Core val_11;
        var val_12;
        int val_13;
        var val_14;
        val_10 = this;
        val_11 = this.<>4__this;
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
        ViewPrefab_Background val_1 = ViewPrefab_Background.Instance;
        val_1.BackgroundController.EnableInkSequenceDark(enable:  true);
        this.<>4__this.InkEmUp_AnimText_NotOverYet.SetActive(value:  false);
        this.<>4__this.InkEmUp_AnimText_InkEmUp.SetActive(value:  true);
        this.<>4__this.InkEmUp_Timer.SetActive(value:  true);
        val_12 = val_10;
        this.<readyToShoot>5__2 = false;
        mem[1152921528356468140] = 1077936128;
        goto label_11;
        label_2:
        val_12 = val_10;
        this.<>1__state = 0;
        if((this.<readyToShoot>5__2) != false)
        {
                this.<>4__this.InkEmUp_AnimText_InkEmUp.SetActive(value:  false);
            this.<>4__this.InkEmUp_AnimText_Go.SetActive(value:  true);
            GameAudio.SwitchMusicOneShot(clip:  this.<>4__this.InkEmUp_Audio_BGMusic, forcePlay:  false);
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.InkEmUp_AnimText_Go.GetComponent<UnityEngine.Animator>().runtimeAnimatorController.animationClips[0].length);
            this.<>1__state = 2;
            val_13 = 1;
            return (bool)val_13;
        }
        
        label_11:
        float val_7 = UnityEngine.Time.deltaTime;
        val_7 = (this.<timeout>5__3) - val_7;
        this.<timeout>5__3 = val_7;
        if(val_7 <= 0f)
        {
                UnityEngine.Debug.LogWarning(message:  "Ink bubble sequence timeout");
        }
        
        this.<readyToShoot>5__2 = true;
        val_11 = this.<>4__this.InkEmUp_InkBubbles;
        val_14 = 0;
        goto label_28;
        label_40:
        if((this.<timeout>5__3) <= 0f)
        {
            goto label_30;
        }
        
        if(val_11[0] != null)
        {
            goto label_32;
        }
        
        goto label_32;
        label_30:
        this.<>4__this.InkEmUp_InkBubbles[0x0][0].InkEmUp_InkState = 3;
        label_32:
        if(((this.<>4__this.InkEmUp_InkBubbles[0x0][0].InkEmUp_InkState) - 1) <= 1)
        {
            goto label_34;
        }
        
        if((this.<>4__this.InkEmUp_InkBubbles[0x0][0].InkEmUp_InkState) == 3)
        {
            goto label_38;
        }
        
        UnityEngine.Debug.LogWarning(message:  static_value_0332F128 + this.<>4__this.InkEmUp_InkBubbles[0x0][0].InkEmUp_InkState(this.<>4__this.InkEmUp_InkBubbles[0x0][0].InkEmUp_InkState));
        this.<>4__this.InkEmUp_InkBubbles[0x0][0].InkEmUp_InkState = true;
        goto label_38;
        label_34:
        this.<readyToShoot>5__2 = false;
        label_38:
        val_14 = 1;
        label_28:
        if(val_14 < (this.<>4__this.InkEmUp_InkBubbles.Length))
        {
            goto label_40;
        }
        
        goto label_41;
        label_1:
        this.<>1__state = 0;
        val_10 = this.<>4__this.InkEmUp_AnimText_Go;
        val_10.SetActive(value:  false);
        val_13 = 0;
        this.<>4__this.InkEmUp_ModelTrigger_ReadyToShoot = true;
        return (bool)val_13;
        label_3:
        val_13 = 0;
        return (bool)val_13;
        label_41:
        val_13 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_13;
        return (bool)val_13;
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
