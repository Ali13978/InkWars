using UnityEngine;
private sealed class JSONArray.<GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SimpleJSON.JSONArray <>4__this;
    private System.Collections.Generic.List.Enumerator<SimpleJSON.JSONNode> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONArray.<GetEnumerator>d__14(int <>1__state)
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
        List.Enumerator<SimpleJSON.JSONNode> val_3;
        List.Enumerator<SimpleJSON.JSONNode> val_6;
        int val_7;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_16;
        }
        
        val_6 = this.<>7__wrap1;
        this.<>1__state = -3;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        List.Enumerator<T> val_1 = this.<>4__this.m_List.GetEnumerator();
        val_6 = this.<>7__wrap1;
        mem[1152921525924154968] = val_2;
        this.<>1__state = -3;
        this.<>7__wrap1 = val_3;
        label_3:
        if((val_6 & 1) != 0)
        {
                this.<>2__current = val_6.InitialType;
            val_7 = 1;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        this.<>m__Finally1();
        val_7 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_7;
        label_16:
        val_7 = 0;
        return (bool)val_7;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Add(driver:  public System.Void List.Enumerator<SimpleJSON.JSONNode>::Dispose(), rectTransform:  null, drivenProperties:  null);
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
