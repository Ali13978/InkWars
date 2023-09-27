using UnityEngine;
private sealed class DemoManager.<HowToAimSequence>d__66 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DemoManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DemoManager.<HowToAimSequence>d__66(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        DemoCanvas val_5;
        var val_6;
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
                val_4 = this.<>4__this;
            val_5 = this.<>4__this.demoCanvas;
        }
        else
        {
                val_4 = 40;
            val_5 = 53212264;
        }
        
        UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
        if(val_5 == 0)
        {
                val_6 = 0;
        }
        
        bool val_2 = DeviceBasedData.playerAtLeftForQuickPlay;
        if(53212264 == 0)
        {
            goto label_5;
        }
        
        if(val_2 == false)
        {
            goto label_6;
        }
        
        label_9:
        if(41114636 != 0)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        this.<>4__this.skipButton = 41114636.gameObject;
        this.<>4__this.skipHowToAimSequence();
        return false;
        label_5:
        if(val_2 == true)
        {
            goto label_9;
        }
        
        label_6:
        if(41114620 != 0)
        {
            goto label_10;
        }
        
        goto label_11;
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
