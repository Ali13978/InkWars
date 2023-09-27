using UnityEngine;
private sealed class MVC_GameScene_Activator.<LoadNextScene_AnimateGates>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MVC_GameScene_Activator <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVC_GameScene_Activator.<LoadNextScene_AnimateGates>d__37(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.IEnumerator val_51;
        int val_52;
        val_51 = this;
        if((this.<>1__state) <= 9)
        {
                var val_51 = 40826424 + (this.<>1__state) << 2;
            val_51 = val_51 + 40826424;
        }
        else
        {
                val_52 = 0;
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
