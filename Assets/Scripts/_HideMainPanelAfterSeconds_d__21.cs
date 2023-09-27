using UnityEngine;
private sealed class DynamicMessageUIController.<HideMainPanelAfterSeconds>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DynamicMessageUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DynamicMessageUIController.<HideMainPanelAfterSeconds>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_4;
        var val_5;
        val_3 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        DynamicMessageUIConstants val_1 = this.<>4__this.m_Constants;
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_1.TimeToFadeOut);
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_6;
        }
        
        val_5 = this.<>4__this;
        this.<>4__this.HideDynamicMessage(_data:  this.<>4__this.m_PlayerData, _tween:  true);
        goto label_7;
        label_2:
        val_4 = 0;
        return (bool)val_4;
        label_6:
        val_5 = 56;
        0.HideDynamicMessage(_data:  4194311, _tween:  true);
        label_7:
        val_4 = 0;
        mem[7599944634466343] = 0;
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
