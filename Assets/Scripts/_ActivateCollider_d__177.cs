using UnityEngine;
private sealed class LineController.<ActivateCollider>d__177 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<ActivateCollider>d__177(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        object val_6;
        int val_7;
        val_5 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_6 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  0.16f);
        val_7 = 1;
        goto label_4;
        label_1:
        val_7 = 0;
        goto label_5;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this.playerBall) != 0)
        {
                this.<>4__this.playerBall.gameObject.GetComponent<UnityEngine.CircleCollider2D>().enabled = true;
        }
        
        val_6 = 0;
        val_7 = 2;
        label_4:
        val_5 = 1;
        this.<>2__current = val_6;
        label_5:
        this.<>1__state = val_7;
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
