using UnityEngine;
private sealed class PostMatchCommonPanel.<TryUpdateProfile>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PostMatchCommonPanel <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PostMatchCommonPanel.<TryUpdateProfile>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) <= 1)
        {
                this.<>1__state = 0;
            if((this.<>4__this.rounds) <= 20)
        {
                val_2 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  3f);
            this.<>1__state = val_2;
            return (bool)val_2;
        }
        
        }
        
        val_2 = 0;
        return (bool)val_2;
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
