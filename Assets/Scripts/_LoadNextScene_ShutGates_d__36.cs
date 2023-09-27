using UnityEngine;
private sealed class MVC_GameScene_Activator.<LoadNextScene_ShutGates>d__36 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MVC_GameScene_Activator <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVC_GameScene_Activator.<LoadNextScene_ShutGates>d__36(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.IEnumerator val_11;
        var val_12;
        GameMode val_13;
        int val_14;
        val_11 = this;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.BattleGatesLoaded) == false)
        {
            goto label_3;
        }
        
        GameAudio.SwitchMusicOneShot(clip:  this.<>4__this.musicOnGatesClose, forcePlay:  false);
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.<>4__this.left.GetComponent<UnityEngine.RectTransform>(), endValue:  this.<>4__this.animPos_Gates, duration:  this.<>4__this.animTime_GateClose, snapping:  false), ease:  30);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.<>4__this.right.GetComponent<UnityEngine.RectTransform>(), endValue:  this.<>4__this.animPos_Gates, duration:  this.<>4__this.animTime_GateClose, snapping:  false), ease:  30);
        val_12 = null;
        val_12 = null;
        val_13 = Character_GlobalInfo.gameMode;
        if(val_13 == 6)
        {
            goto label_10;
        }
        
        val_12 = null;
        val_13 = Character_GlobalInfo.gameMode;
        if(val_13 != 10)
        {
            goto label_13;
        }
        
        label_10:
        this.<>4__this.SetupNetworkUserInfo();
        SetActive(value:  true);
        SetActive(value:  true);
        SetActive(value:  true);
        label_30:
        SetActive(value:  true);
        label_27:
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.animTime_GateClose);
        this.<>1__state = 2;
        val_14 = 1;
        return (bool)val_14;
        label_1:
        if((this.<>1__state) != 2)
        {
            goto label_19;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_20;
        }
        
        val_11 = this.<>4__this.LoadNextScene_AnimateGates();
        goto label_21;
        label_3:
        val_14 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_14;
        return (bool)val_14;
        label_20:
        val_11 = 0.LoadNextScene_AnimateGates();
        label_21:
        UnityEngine.Coroutine val_10 = this.<>4__this.StartCoroutine(routine:  val_11);
        label_19:
        val_14 = 0;
        return (bool)val_14;
        label_13:
        val_13 = Character_GlobalInfo.gameMode;
        SetActive(value:  true);
        SetActive(value:  true);
        if(val_13 != 5)
        {
            goto label_27;
        }
        
        SetActive(value:  false);
        if(null != 0)
        {
            goto label_30;
        }
        
        goto label_30;
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
