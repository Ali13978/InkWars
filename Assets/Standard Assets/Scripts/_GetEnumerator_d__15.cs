using UnityEngine;
private sealed class JSONClass.<GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SimpleJSON.JSONClass <>4__this;
    private System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON.JSONNode> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONClass.<GetEnumerator>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        var val_2;
        var val_3;
        Dictionary.Enumerator<System.String, SimpleJSON.JSONNode> val_4;
        Dictionary.Enumerator<System.String, SimpleJSON.JSONNode> val_7;
        int val_8;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_17;
        }
        
        val_7 = this.<>7__wrap1;
        this.<>1__state = -3;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.<>4__this.m_Dict.GetEnumerator();
        val_7 = this.<>7__wrap1;
        mem[1152921525928499608] = val_2;
        mem[1152921525928499592] = val_3;
        this.<>1__state = -3;
        this.<>7__wrap1 = val_4;
        label_3:
        if((val_7 & 1) != 0)
        {
                UnityEngine.Playables.PlayableHandle val_5 = val_7.GetHandle();
            val_4 = val_5.m_Handle;
            this.<>2__current = val_4;
            val_8 = 1;
            this.<>1__state = val_8;
            return (bool)val_8;
        }
        
        this.<>m__Finally1();
        val_8 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_8;
        label_17:
        val_8 = 0;
        return (bool)val_8;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Add(driver:  public System.Void Dictionary.Enumerator<System.String, SimpleJSON.JSONNode>::Dispose(), rectTransform:  null, drivenProperties:  null);
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
