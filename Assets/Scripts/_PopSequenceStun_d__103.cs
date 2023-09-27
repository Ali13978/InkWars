using UnityEngine;
private sealed class InteractiveTutorialManager.<PopSequenceStun>d__103 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float stunTime;
    public TutorialDataManager.PlayerData targetPlayer;
    public bool isCPU;
    public InteractiveTutorialManager <>4__this;
    private CharAnimationController <animController>5__2;
    private UnityEngine.UI.Text <targetText>5__3;
    private UnityEngine.GameObject <targetHomeBase>5__4;
    private float <i>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InteractiveTutorialManager.<PopSequenceStun>d__103(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_14;
        bool val_15;
        CharAnimationController val_16;
        int val_17;
        float val_18;
        System.Collections.IEnumerator val_19;
        val_14 = this;
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
            goto label_4;
        }
        
        this.<>1__state = 0;
        if(this.stunTime == 0f)
        {
            goto label_4;
        }
        
        DemoManager val_1 = DemoManager.Instance;
        val_1.Trigger_Stunned_Start = true;
        this.targetPlayer.isStunned = true;
        val_15 = this.isCPU;
        if((this.<>4__this) == null)
        {
            goto label_9;
        }
        
        if(val_15 == false)
        {
            goto label_10;
        }
        
        label_34:
        val_16 = this.<>4__this.animController_CPU;
        goto label_11;
        label_4:
        val_17 = 0;
        return (bool)val_17;
        label_1:
        float val_14 = this.stunTime;
        val_15 = 1152921526150247272;
        this.<>1__state = 0;
        val_14 = val_14 / (-20f);
        val_18 = (this.<i>5__5) + val_14;
        this.<i>5__5 = val_18;
        goto label_13;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
                val_19 = this.<>4__this.ShakeSequence(player:  this.targetPlayer, shake:  this.stunTime);
        }
        else
        {
                val_19 = 0.ShakeSequence(player:  this.targetPlayer, shake:  this.stunTime);
        }
        
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  val_19);
        val_15 = val_14;
        this.<targetText>5__3 = (this.isCPU == true) ? this.<>4__this.stunCounterCPU : this.<>4__this.stunCounterPlayer;
        mem[1152921526150247280] = (val_15 == true) ? this.<>4__this.iconCPUActive : this.<>4__this.iconPlayerActive;
        if(this.targetPlayer.isReloading != true)
        {
                this.<targetHomeBase>5__4.SetActive(value:  false);
        }
        
        this.<targetText>5__3.gameObject.SetActive(value:  true);
        this.<i>5__5 = this.stunTime;
        val_18 = this.stunTime;
        label_13:
        if(val_18 < 0f)
        {
                this.<targetText>5__3.gameObject.SetActive(value:  false);
            this.<targetHomeBase>5__4.SetActive(value:  true);
            this.<animController>5__2.PlayAnimation(newAnimName:  12, forceOverride:  false);
            this.targetPlayer.isStunned = false;
            val_14 = DemoManager.Instance;
            val_17 = 0;
            val_9.Trigger_Stunned = true;
            return (bool)val_17;
        }
        
        val_15 = this.<i>5__5.ToString(format:  "F2");
        UnityEngine.WaitForSeconds val_11 = null;
        float val_15 = 20f;
        val_15 = this.stunTime / val_15;
        val_11 = new UnityEngine.WaitForSeconds(seconds:  val_15);
        this.<>2__current = val_11;
        this.<>1__state = 2;
        val_17 = 1;
        return (bool)val_17;
        label_9:
        if(val_15 == true)
        {
            goto label_34;
        }
        
        label_10:
        val_16 = this.<>4__this.animController_Player;
        label_11:
        this.<animController>5__2 = val_16;
        UnityEngine.WaitForEndOfFrame val_13 = val_16;
        val_13.PlayAnimation(newAnimName:  13, forceOverride:  false);
        val_13 = new UnityEngine.WaitForEndOfFrame();
        val_17 = 1;
        this.<>2__current = val_13;
        this.<>1__state = val_17;
        return (bool)val_17;
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
