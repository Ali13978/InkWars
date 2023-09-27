using UnityEngine;
private sealed class MVC_Multiplayer_Manager_Base.<ShutdownNetworkCoroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InkWars.Model.MVC_Multiplayer_Manager_Base <>4__this;
    public bool notifyUser;
    public float delay;
    public bool couldBeRageQuit;
    public bool reloadScene;
    private UnityEngine.WWW <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVC_Multiplayer_Manager_Base.<ShutdownNetworkCoroutine>d__65(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        var val_16;
        val_15 = this;
        if((this.<>1__state) <= 4)
        {
                var val_15 = 40826724 + (this.<>1__state) << 2;
            val_15 = val_15 + 40826724;
        }
        else
        {
                val_16 = 0;
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
