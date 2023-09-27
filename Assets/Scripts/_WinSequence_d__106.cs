using UnityEngine;
private sealed class LineControllerP2.<WinSequence>d__106 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerP2 <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<WinSequence>d__106(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        bool val_4;
        val_3 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_3;
        }
        
        this.<>4__this.StopCoroutine(methodName:  "IconMask");
        goto label_4;
        label_1:
        val_4 = 0;
        goto label_5;
        label_3:
        0.StopCoroutine(methodName:  "IconMask");
        label_4:
        this.<>4__this.iconPlayerActive.GetComponent<UnityEngine.UI.Image>().fillAmount = 1f;
        val_4 = true;
        this.<>4__this.GameWon = val_4;
        val_3 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        label_5:
        this.<>1__state = val_4;
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
