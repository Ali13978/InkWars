using UnityEngine;
private sealed class DemoManager.<DestroyPlayerBalls>d__106 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.GameObject[] ringArray;
    public int length;
    public DemoManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DemoManager.<DestroyPlayerBalls>d__106(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        int val_8;
        val_7 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        TargetBallScript.scoreCounter = 200;
        if(this.length >= 1)
        {
                var val_9 = 0;
            do
        {
            if(this.ringArray[0] != 0)
        {
                this.ringArray[0].gameObject.GetComponent<InkingSequenceBubbleAnim>().DestroyAnim(winnerScore:  "Score");
        }
        
            val_9 = val_9 + 1;
        }
        while(val_9 < this.length);
        
        }
        
        val_8 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        this.<>1__state = val_8;
        return (bool)val_8;
        label_1:
        this.<>1__state = 0;
        val_7 = GameAudio.sound;
        UnityEngine.AudioSource val_6 = val_7.PlayOneShot(clip:  this.<>4__this.popClip, volume:  1f);
        label_2:
        val_8 = 0;
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
