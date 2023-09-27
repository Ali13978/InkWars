using UnityEngine;
private sealed class JSONNode.<get_DeepChilds>d__19 : IEnumerable<SimpleJSON.JSONNode>, IEnumerable, IEnumerator<SimpleJSON.JSONNode>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private SimpleJSON.JSONNode <>2__current;
    private int <>l__initialThreadId;
    public SimpleJSON.JSONNode <>4__this;
    private System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> <>7__wrap1;
    private System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> <>7__wrap2;
    
    // Properties
    private SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONNode.<get_DeepChilds>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
        var val_10 = this;
        if(((this.<>1__state) & 4294967294) != 4)
        {
            goto label_0;
        }
        
        if(((this.<>1__state) == 4) || ((this.<>1__state) == 1))
        {
            goto label_2;
        }
        
        goto label_3;
        label_0:
        if((this.<>1__state) != 1)
        {
                return;
        }
        
        label_2:
        this.<>m__Finally2();
        label_3:
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> val_9;
        var val_10;
        var val_14;
        int val_15;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_52;
        }
        
        goto label_44;
        label_1:
        this.<>1__state = 0;
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_9 = this.<>4__this.GetEnumerator();
        val_10 = this;
        this.<>7__wrap1 = val_9;
        this.<>1__state = -3;
        if(val_9 != null)
        {
            goto label_25;
        }
        
        goto label_11;
        label_44:
        this.<>1__state = -4;
        var val_14 = 0;
        val_14 = val_14 + 1;
        if((this.<>7__wrap2.MoveNext()) == false)
        {
            goto label_19;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        goto label_24;
        label_19:
        this.<>m__Finally2();
        val_10 = this;
        val_9 = this.<>7__wrap1;
        this.<>7__wrap2 = 0;
        if(val_9 != null)
        {
            goto label_25;
        }
        
        label_11:
        label_25:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_30;
        }
        
        var val_19 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_35;
        }
        
        var val_17 = mem[val_2] + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_34:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_33;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (mem[val_2] + 286))
        {
            goto label_34;
        }
        
        goto label_35;
        label_30:
        this.<>m__Finally1();
        val_15 = 0;
        this.<>7__wrap1 = 0;
        return (bool)val_15;
        label_24:
        this.<>2__current = this.<>7__wrap2.Current;
        val_15 = 1;
        this.<>1__state = val_15;
        return (bool)val_15;
        label_33:
        val_19 = val_19 + (((mem[val_2] + 176 + 8)) << 4);
        val_14 = val_19 + 296;
        label_35:
        var val_20 = 0;
        val_20 = val_20 + 1;
        this.<>7__wrap2 = this.<>7__wrap1.Current.DeepChilds.GetEnumerator();
        goto label_44;
        label_52:
        val_15 = 0;
        return (bool)val_15;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<>7__wrap1) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.<>7__wrap1.Dispose();
    }
    private void <>m__Finally2()
    {
        this.<>1__state = -3;
        if((this.<>7__wrap2) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.<>7__wrap2.Dispose();
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
        this = new JSONNode.<get_DeepChilds>d__19();
        return (System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator();
    }

}
