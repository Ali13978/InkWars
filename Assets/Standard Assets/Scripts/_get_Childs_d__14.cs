using UnityEngine;
private sealed class JSONClass.<get_Childs>d__14 : IEnumerable<SimpleJSON.JSONNode>, IEnumerable, IEnumerator<SimpleJSON.JSONNode>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private SimpleJSON.JSONNode <>2__current;
    private int <>l__initialThreadId;
    public SimpleJSON.JSONClass <>4__this;
    private System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON.JSONNode> <>7__wrap1;
    
    // Properties
    private SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONClass.<get_Childs>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
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
        mem[1152921525927429152] = val_2;
        mem[1152921525927429136] = val_3;
        this.<>1__state = -3;
        this.<>7__wrap1 = val_4;
        label_3:
        if((val_7 & 1) != 0)
        {
                UnityEngine.Playables.PlayableHandle val_5 = val_7.GetHandle();
            this.<>2__current = val_5.m_Handle;
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
    private SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current()
    {
        return (SimpleJSON.JSONNode)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }
    private System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
    {
        if((this.<>1__state) == 2)
        {
                if((this.<>l__initialThreadId) == System.Environment.CurrentManagedThreadId)
        {
                this.<>1__state = 0;
            return (System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>)this;
        }
        
        }
        
        .<>1__state = 0;
        .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
        .<>4__this = this.<>4__this;
        this = new JSONClass.<get_Childs>d__14();
        return (System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator();
    }

}
