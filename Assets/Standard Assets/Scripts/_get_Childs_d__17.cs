using UnityEngine;
private sealed class JSONNode.<get_Childs>d__17 : IEnumerable<SimpleJSON.JSONNode>, IEnumerable, IEnumerator<SimpleJSON.JSONNode>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private SimpleJSON.JSONNode <>2__current;
    private int <>l__initialThreadId;
    
    // Properties
    private SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONNode.<get_Childs>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        return false;
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
        
        JSONNode.<get_Childs>d__17 val_2 = null;
        this = val_2;
        val_2 = new JSONNode.<get_Childs>d__17();
        .<>1__state = 0;
        .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
        return (System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator();
    }

}
