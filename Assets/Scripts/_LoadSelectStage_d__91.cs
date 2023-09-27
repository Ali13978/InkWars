using UnityEngine;
private sealed class CharacterSelect.<LoadSelectStage>d__91 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharacterSelect <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterSelect.<LoadSelectStage>d__91(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterSelect.<LoadSelectStage>d__91 val_6;
        int val_7;
        val_6 = this;
        if((this.<>1__state) <= 3)
        {
                var val_6 = 40837528 + (this.<>1__state) << 2;
            val_6 = val_6 + 40837528;
        }
        else
        {
                val_7 = 0;
            return (bool);
        }
    
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
