using UnityEngine;
private sealed class GameOverPanelSummary.<PlayCountingSound>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameOverPanelSummary <>4__this;
    public float _delay;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameOverPanelSummary.<PlayCountingSound>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AudioSource val_4;
        int val_5;
        val_4 = this;
        if((this.<>1__state) < 2)
        {
                this.<>1__state = 0;
            if((this.<>4__this.m_IsAnimating) != false)
        {
                this.<>4__this.m_AudioSource = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.m_CountingClip, volume:  1f);
            UnityEngine.WaitForSeconds val_3 = null;
            float val_4 = -0.075f;
            val_4 = this._delay + val_4;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  val_4);
            val_5 = 1;
            this.<>2__current = val_3;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
            val_4 = this.<>4__this.m_AudioSource;
            val_4.Stop();
        }
        
        val_5 = 0;
        return (bool)val_5;
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
