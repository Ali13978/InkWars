using UnityEngine;
private sealed class MVCTutorialManager.<DoTutorial>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MVCTutorialStage[] tutorial;
    public MVCTutorialManager <>4__this;
    private MVCTutorialStage[] <>7__wrap1;
    private int <>7__wrap2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVCTutorialManager.<DoTutorial>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.IEnumerator val_5;
        MVCTutorialStage[] val_6;
        int val_7;
        var val_8;
        int val_9;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_1;
        }
        
        val_5 = this;
        this.<>7__wrap2 = 0;
        val_6 = this.tutorial;
        val_7 = 0;
        this.<>1__state = 0;
        val_8 = 1152921528283620416;
        mem[1152921528283620416] = val_6;
        if(val_6 != null)
        {
            goto label_4;
        }
        
        goto label_3;
        label_0:
        val_5 = this;
        val_7 = (this.<>7__wrap2) + 1;
        this.<>1__state = 0;
        this.<>7__wrap2 = val_7;
        val_8 = 1152921528283620424;
        val_6 = mem[1152921528283620416];
        if(val_6 != 0)
        {
            goto label_4;
        }
        
        label_3:
        label_4:
        if(val_7 >= (this.tutorial + 24))
        {
            goto label_5;
        }
        
        MVCTutorialStage[] val_1 = mem[1152921528283620416] + (((this.<>7__wrap2 + 1)) << 3);
        val_5 = (this.tutorial + ((this.<>7__wrap2 + 1)) << 3) + 32.PlayStage();
        this.<>2__current = this.<>4__this.StartCoroutine(routine:  val_5);
        val_9 = 1;
        this.<>1__state = val_9;
        return (bool)val_9;
        label_1:
        val_9 = 0;
        return (bool)val_9;
        label_5:
        val_9 = 0;
        mem[1152921528283620416] = 0;
        return (bool)val_9;
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
