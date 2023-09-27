using UnityEngine;
private sealed class LineController.<TimeUpLoseSequence>d__204 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<TimeUpLoseSequence>d__204(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_32;
        int val_33;
        var val_34;
        System.Collections.IEnumerator val_35;
        System.Collections.IEnumerator val_36;
        System.Collections.IEnumerator val_37;
        System.Collections.IEnumerator val_38;
        System.Collections.IEnumerator val_39;
        System.Collections.IEnumerator val_40;
        var val_41;
        var val_42;
        val_32 = this;
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
        val_33 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_33;
        return (bool)val_33;
        label_1:
        this.<>1__state = 0;
        val_32 = this.<>4__this.YouLose;
        val_32.SetActive(value:  false);
        this.<>4__this.LeaderboardUpdate(index:  1);
        UnityEngine.Coroutine val_3 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.TimeUpCommonWinPanelSequence(gameResult:  1));
        label_3:
        val_33 = 0;
        return (bool)val_33;
        label_2:
        this.<>1__state = 0;
        val_34 = null;
        val_34 = null;
        if((this.<>4__this) != null)
        {
                val_35 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.outerRingBalls, length:  17, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_35 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.outerRingBalls, length:  17, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_6 = this.<>4__this.StartCoroutine(routine:  val_35);
        if((this.<>4__this) != null)
        {
                val_36 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.middleRingBalls, length:  13, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_36 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.middleRingBalls, length:  13, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_9 = this.<>4__this.StartCoroutine(routine:  val_36);
        if((this.<>4__this) != null)
        {
                val_37 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.innerRingBalls, length:  9, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_37 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.innerRingBalls, length:  9, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_12 = this.<>4__this.StartCoroutine(routine:  val_37);
        if((this.<>4__this) != null)
        {
                val_38 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerOuterRingBalls, length:  17, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_38 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerOuterRingBalls, length:  17, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_15 = this.<>4__this.StartCoroutine(routine:  val_38);
        if((this.<>4__this) != null)
        {
                val_39 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerMiddleRingBalls, length:  13, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_39 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerMiddleRingBalls, length:  13, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_18 = this.<>4__this.StartCoroutine(routine:  val_39);
        if((this.<>4__this) != null)
        {
                val_40 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerInnerRingBalls, length:  9, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_40 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerInnerRingBalls, length:  9, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_21 = this.<>4__this.StartCoroutine(routine:  val_40);
        val_41 = null;
        val_41 = null;
        GameAudio.SwitchMusicOneShot(clip:  (Character_GlobalInfo.gameMode == 5) ? this.<>4__this.winClip : this.<>4__this.loseClip, forcePlay:  false);
        this.<>4__this.YouWin.SetActive(value:  (Character_GlobalInfo.gameMode == 5) ? 1 : 0);
        this.<>4__this.YouLose.SetActive(value:  (Character_GlobalInfo.gameMode != 5) ? 1 : 0);
        val_42 = null;
        val_42 = null;
        VoiceManager.instance.PlayAttackSound(Left:  1, SoundType:  3, modifiers:  0);
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  2, modifiers:  0);
        this.<>4__this.animController.PlayAnimation(newAnimName:  9, forceOverride:  false);
        LineControllerP2 val_25 = this.<>4__this.GetComponent<LineControllerP2>();
        val_25.animController.PlayAnimation(newAnimName:  15, forceOverride:  false);
        this.<>4__this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        LineControllerP2 val_28 = this.<>4__this.GetComponent<LineControllerP2>();
        val_28.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  4f);
        this.<>1__state = 2;
        val_33 = 1;
        return (bool)val_33;
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
