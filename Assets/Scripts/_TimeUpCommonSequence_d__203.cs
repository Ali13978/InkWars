using UnityEngine;
private sealed class LineController.<TimeUpCommonSequence>d__203 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<TimeUpCommonSequence>d__203(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        LineController val_3;
        int val_4;
        string val_5;
        val_3 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.specialBallButton.interactable = false;
        this.<>4__this.specialBallButtonArrow.interactable = false;
        this.<>4__this.TimeUp.SetActive(value:  true);
        this.<>4__this.camera_Shake.SetActive(value:  true);
        GameAudio.PlayMusicOneShot(clip:  this.<>4__this.matchConclusion);
        this.<>4__this.entryIndicators.SetActive(value:  false);
        UnityEngine.WaitForSeconds val_1 = null;
        val_3 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  4f);
        val_4 = 1;
        this.<>2__current = val_3;
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.TimeUp.SetActive(value:  false);
        if((this.<>4__this.timeUpFlag) == 2)
        {
                val_5 = "TimeUpLoseSequence";
        }
        else
        {
                if((this.<>4__this.timeUpFlag) == 1)
        {
                val_5 = "TimeUpWinSequence";
        }
        else
        {
                val_5 = "TimeUpDrawSequence";
        }
        
        }
        
        UnityEngine.Coroutine val_2 = val_3.StartCoroutine(methodName:  val_5);
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
