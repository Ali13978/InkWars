using UnityEngine;
private sealed class LineControllerAI.<PlayerLose>d__81 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerAI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerAI.<PlayerLose>d__81(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        VoiceManager val_7;
        int val_8;
        var val_9;
        val_7 = this;
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
        this.<>4__this.iconCPUActive.SetActive(value:  true);
        this.<>4__this.iconCPUActive.gameObject.GetComponent<UnityEngine.UI.Image>().fillAmount = 0f;
        val_8 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  6f);
        this.<>1__state = val_8;
        return (bool)val_8;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.animController.PlayAnimation(newAnimName:  15, forceOverride:  false);
        val_9 = null;
        val_9 = null;
        val_7 = VoiceManager.instance;
        val_7.PlayAttackSound(Left:  0, SoundType:  2, modifiers:  0);
        label_3:
        val_8 = 0;
        return (bool)val_8;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this.modeName) != 3)
        {
                UnityEngine.AudioSource val_5 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.popClip[2], volume:  1f);
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = 2;
        val_8 = 1;
        return (bool)val_8;
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
