using UnityEngine;
private sealed class LineController.<TimeUpDrawSequence>d__206 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<TimeUpDrawSequence>d__206(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_12;
        int val_13;
        var val_14;
        val_12 = this;
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
        val_13 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_13;
        return (bool)val_13;
        label_1:
        this.<>1__state = 0;
        val_12 = this.<>4__this.GameDraw;
        val_12.SetActive(value:  false);
        UnityEngine.Coroutine val_3 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.TimeUpCommonWinPanelSequence(gameResult:  2));
        label_3:
        val_13 = 0;
        return (bool)val_13;
        label_2:
        this.<>1__state = 0;
        GameAudio.SwitchMusicOneShot(clip:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Sound/Draw"), forcePlay:  false);
        this.<>4__this.GameDraw.SetActive(value:  true);
        val_14 = null;
        val_14 = null;
        VoiceManager.instance.PlayAttackSound(Left:  1, SoundType:  4, modifiers:  0);
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  4, modifiers:  0);
        this.<>4__this.animController.PlayAnimation(newAnimName:  6, forceOverride:  false);
        LineControllerP2 val_5 = this.<>4__this.GetComponent<LineControllerP2>();
        val_5.animController.PlayAnimation(newAnimName:  6, forceOverride:  false);
        this.<>4__this.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        LineControllerP2 val_8 = this.<>4__this.GetComponent<LineControllerP2>();
        val_8.iconPlayerActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  4f);
        this.<>1__state = 2;
        val_13 = 1;
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
