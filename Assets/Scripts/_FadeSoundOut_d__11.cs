using UnityEngine;
private sealed class CharAudioController.<FadeSoundOut>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.AudioSource audio;
    public CharAudioController <>4__this;
    private float <startVol>5__2;
    private float <currentTime>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharAudioController.<FadeSoundOut>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        UnityEngine.AudioSource val_9;
        int val_10;
        float val_12;
        float val_13;
        val_8 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_9 = val_8;
        this.<>1__state = 0;
        this.<startVol>5__2 = this.audio.volume;
        this.<currentTime>5__3 = 0f;
        goto label_4;
        label_1:
        val_9 = this.audio;
        this.<>1__state = 0;
        label_4:
        if(mem[this.audio].volume > 0f)
        {
            goto label_6;
        }
        
        val_8 = mem[this.audio];
        val_8.Stop();
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_6:
        float val_8 = this.<currentTime>5__3;
        val_8 = val_8 + UnityEngine.Time.deltaTime;
        this.<currentTime>5__3 = val_8;
        float val_5 = UnityEngine.Mathf.Lerp(a:  this.<startVol>5__2, b:  0f, t:  val_8 / (this.<>4__this.fadeOutTime));
        if(mem[this.audio] != 0)
        {
                val_12 = this.<startVol>5__2;
            val_13 = mem[this.audio].volume;
        }
        else
        {
                val_12 = this.<startVol>5__2;
            val_13 = 0.volume;
        }
        
        float val_9 = -0.1f;
        val_9 = val_12 * val_9;
        val_9 = val_13 + val_9;
        mem[this.audio].volume = val_9;
        val_10 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_10;
        return (bool)val_10;
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
