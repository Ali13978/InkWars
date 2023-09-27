using UnityEngine;
private sealed class StoryMovieCtrl.<SwitchOPSound>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public StoryMovieCtrl <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StoryMovieCtrl.<SwitchOPSound>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AudioClip val_2;
        int val_3;
        val_2 = this;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.player.time) < 0)
        {
            goto label_4;
        }
        
        this.<>4__this.audioSource.mute = true;
        val_2 = this.<>4__this.OPBGM2;
        GameAudio.SwitchMusic(clip:  val_2, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_4:
        val_3 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_3;
        return (bool)val_3;
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
