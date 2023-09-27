using UnityEngine;
private sealed class LineController.<TimeUpWinSequence>d__205 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<TimeUpWinSequence>d__205(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_30;
        int val_31;
        var val_32;
        System.Collections.IEnumerator val_33;
        System.Collections.IEnumerator val_34;
        System.Collections.IEnumerator val_35;
        System.Collections.IEnumerator val_36;
        System.Collections.IEnumerator val_37;
        var val_38;
        val_30 = this;
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
        val_31 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_31;
        return (bool)val_31;
        label_1:
        this.<>1__state = 0;
        val_30 = this.<>4__this.YouWin;
        val_30.SetActive(value:  false);
        UnityEngine.Coroutine val_3 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.TimeUpCommonWinPanelSequence(gameResult:  0));
        label_3:
        val_31 = 0;
        return (bool)val_31;
        label_2:
        this.<>1__state = 0;
        val_32 = null;
        val_32 = null;
        if((this.<>4__this) != null)
        {
                val_33 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.outerRingBalls, length:  17, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_33 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.outerRingBalls, length:  17, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_6 = this.<>4__this.StartCoroutine(routine:  val_33);
        if((this.<>4__this) != null)
        {
                val_34 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.middleRingBalls, length:  13, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_34 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.middleRingBalls, length:  13, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_9 = this.<>4__this.StartCoroutine(routine:  val_34);
        if((this.<>4__this) != null)
        {
                val_35 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.innerRingBalls, length:  9, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_35 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.innerRingBalls, length:  9, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_12 = this.<>4__this.StartCoroutine(routine:  val_35);
        if((this.<>4__this) != null)
        {
                val_36 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerOuterRingBalls, length:  17, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_36 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerOuterRingBalls, length:  17, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_15 = this.<>4__this.StartCoroutine(routine:  val_36);
        if((this.<>4__this) != null)
        {
                val_37 = this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerMiddleRingBalls, length:  13, ifWin:  false, isForTimeOver:  true);
        }
        else
        {
                val_37 = 0.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerMiddleRingBalls, length:  13, ifWin:  false, isForTimeOver:  true);
        }
        
        UnityEngine.Coroutine val_18 = this.<>4__this.StartCoroutine(routine:  val_37);
        if((this.<>4__this) != null)
        {
                UnityEngine.Coroutine val_20 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerInnerRingBalls, length:  9, ifWin:  false, isForTimeOver:  true));
        }
        else
        {
                UnityEngine.Coroutine val_22 = this.<>4__this.StartCoroutine(routine:  0.DestroyPlayerBalls(ringArray:  InstanceAnimator.playerInnerRingBalls, length:  9, ifWin:  false, isForTimeOver:  true));
        }
        
        GameAudio.SwitchMusicOneShot(clip:  this.<>4__this.winClip, forcePlay:  false);
        this.<>4__this.YouWin.SetActive(value:  true);
        val_38 = null;
        val_38 = null;
        VoiceManager.instance.PlayAttackSound(Left:  1, SoundType:  2, modifiers:  0);
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  3, modifiers:  0);
        this.<>4__this.animController.PlayAnimation(newAnimName:  15, forceOverride:  false);
        LineControllerP2 val_23 = this.<>4__this.GetComponent<LineControllerP2>();
        val_23.animController.PlayAnimation(newAnimName:  9, forceOverride:  false);
        this.<>4__this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        LineControllerP2 val_26 = this.<>4__this.GetComponent<LineControllerP2>();
        val_26.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  4f);
        this.<>1__state = 2;
        val_31 = 1;
        return (bool)val_31;
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
