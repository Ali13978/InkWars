using UnityEngine;
private sealed class MVC_GameScene_Activator.<LoadNextScene_InitialiseScene>d__39 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MVC_GameScene_Activator <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVC_GameScene_Activator.<LoadNextScene_InitialiseScene>d__39(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.IEnumerator val_12;
        int val_14;
        val_12 = this;
        if((this.<>1__state) <= 4)
        {
                var val_12 = 40826464 + (this.<>1__state) << 2;
            val_12 = val_12 + 40826464;
        }
        else
        {
                val_14 = 0;
            return (bool)val_14;
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
