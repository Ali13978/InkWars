using UnityEngine;
private sealed class View_Core.<Activate_AnimText_MatchConclusion_PartOne>d__90 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_Core <>4__this;
    private float <TimeRemaining_Anim_MatchConclusion>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_Core.<Activate_AnimText_MatchConclusion_PartOne>d__90(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_22;
        bool val_23;
        InkWars.Model.Player val_24;
        var val_25;
        View_CameraShake val_26;
        int val_27;
        var val_28;
        System.Collections.IEnumerator val_29;
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
        InkWars.Model.GameResult val_2 = View_Core.Model.GameResult;
        if((val_2 - 4) >= 3)
        {
            goto label_5;
        }
        
        this.<>4__this.animText_MatchConclusionPartOne.GetComponent<UnityEngine.SpriteRenderer>().sprite = this.<>4__this.AnimTextSprite_TimesUp;
        goto label_24;
        label_1:
        val_22 = this.<TimeRemaining_Anim_MatchConclusion>5__2;
        this.<>1__state = 0;
        goto label_10;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_5:
        if(val_2 == 2)
        {
            goto label_13;
        }
        
        if(val_2 != 3)
        {
            goto label_14;
        }
        
        this.<>4__this.animText_MatchConclusionPartOne.GetComponent<UnityEngine.SpriteRenderer>().sprite = this.<>4__this.AnimTextSprite_DoubleKO;
        View_Objects val_6 = this.<>4__this.GetPlayer(playerID:  0);
        val_23 = true;
        val_24 = 1;
        val_6.AnimTrigger_Lose = val_23;
        goto label_19;
        label_13:
        this.<>4__this.animText_MatchConclusionPartOne.GetComponent<UnityEngine.SpriteRenderer>().sprite = this.<>4__this.AnimTextSprite_KO;
        View_Objects val_8 = this.<>4__this.GetPlayer(playerID:  0);
        val_8.AnimTrigger_Lose = true;
        goto label_24;
        label_14:
        this.<>4__this.animText_MatchConclusionPartOne.GetComponent<UnityEngine.SpriteRenderer>().sprite = this.<>4__this.AnimTextSprite_KO;
        val_24 = 1;
        val_23 = true;
        label_19:
        View_Objects val_10 = this.<>4__this.GetPlayer(playerID:  val_24);
        val_10.AnimTrigger_Lose = val_23;
        label_24:
        this.<>4__this.LeftPlayer.EnableSwitcherBubbles(enable:  false);
        this.<>4__this.RightPlayer.EnableSwitcherBubbles(enable:  false);
        this.<>4__this.CancelInvoke(methodName:  "BlinkTimer");
        this.<>4__this.CountdownTime.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_25 = null;
        val_25 = null;
        val_22 = InkWars.Model.Model_Constants.CameraShakeIntensity_KO;
        this.<>4__this.CameraShake.CameraShake_Set(intensity:  val_22, time:  InkWars.Model.Model_Constants.CameraShakeTime_KO);
        UnityEngine.AudioSource val_12 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.audio_MatchEnd, volume:  1f);
        label_12:
        val_26 = this.<>4__this.CameraShake;
        if((this.<>4__this.CameraShake.shakeActive) != false)
        {
                val_27 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_27;
            return (bool)val_27;
        }
        
        val_28 = null;
        val_28 = null;
        GameMode val_22 = Character_GlobalInfo.gameMode;
        if((val_22 - 1) >= 2)
        {
                if(val_22 > 10)
        {
            goto label_57;
        }
        
            val_22 = 1 << val_22;
            val_22 = val_22 & 1120;
            if(val_22 == 0)
        {
            goto label_57;
        }
        
        }
        
        this.<>4__this.animText_MatchConclusionPartOne.SetActive(value:  true);
        label_57:
        val_26 = mem[this.<>4__this.animText_MatchConclusionPartOne].GetComponent<UnityEngine.Animator>().runtimeAnimatorController.animationClips[0];
        val_22 = val_26.length;
        this.<TimeRemaining_Anim_MatchConclusion>5__2 = val_22;
        label_10:
        if(val_22 > 0f)
        {
            goto label_53;
        }
        
        if((this.<>4__this) == null)
        {
            goto label_54;
        }
        
        val_29 = this.<>4__this.MatchConclusion_Finish();
        goto label_55;
        label_53:
        float val_19 = UnityEngine.Time.deltaTime;
        val_19 = val_22 - val_19;
        this.<>2__current = 0;
        this.<TimeRemaining_Anim_MatchConclusion>5__2 = val_19;
        this.<>1__state = 2;
        val_27 = 1;
        return (bool)val_27;
        label_54:
        val_29 = 0.MatchConclusion_Finish();
        label_55:
        UnityEngine.Coroutine val_21 = this.<>4__this.StartCoroutine(routine:  val_29);
        label_3:
        val_27 = 0;
        return (bool)val_27;
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
