using UnityEngine;
private sealed class MVCTutorialStage.<PlayStage>d__1 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MVCTutorialStage <>4__this;
    private MVCTutorialPart[] <>7__wrap1;
    private int <>7__wrap2;
    private MVCTutorialPart <part>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVCTutorialStage.<PlayStage>d__1(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        MVCTutorialPart[] val_7;
        System.Collections.IEnumerator val_8;
        var val_9;
        var val_10;
        int val_11;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_6 = 0;
        goto label_4;
        label_9:
        this.<>4__this.TutorialParts[0].gameObject.SetActive(value:  false);
        val_6 = 1;
        label_4:
        if(val_6 < (this.<>4__this.TutorialParts.Length))
        {
            goto label_9;
        }
        
        val_7 = this.<>4__this.TutorialParts;
        val_8 = this;
        val_9 = 0;
        this.<>7__wrap1 = val_7;
        val_10 = 1152921528286045096;
        mem[1152921528286045104] = 0;
        if(val_7 != null)
        {
            goto label_15;
        }
        
        goto label_12;
        label_1:
        this.<>1__state = 0;
        MVCTutorialPart.CurrentTutorialPart = 0;
        this.<part>5__4.gameObject.SetActive(value:  false);
        val_8 = this;
        val_7 = this.<>7__wrap1;
        this.<part>5__4 = 0;
        val_10 = 1152921528286045096;
        val_9 = 1;
        mem[1152921528286045104] = val_9;
        if(val_7 != null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        if(val_9 >= (this.<>7__wrap1.Length))
        {
            goto label_16;
        }
        
        this.<part>5__4 = this.<>4__this.TutorialParts.Length + 32;
        this.<>4__this.TutorialParts.Length + 32.gameObject.SetActive(value:  true);
        MVCTutorialPart.CurrentTutorialPart = this.<part>5__4;
        val_8 = this.<part>5__4.PlayPart();
        this.<>2__current = this.<>4__this.StartCoroutine(routine:  val_8);
        val_11 = 1;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_2:
        val_11 = 0;
        return (bool)val_11;
        label_16:
        val_11 = 0;
        this.<>7__wrap1 = 0;
        return (bool)val_11;
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
