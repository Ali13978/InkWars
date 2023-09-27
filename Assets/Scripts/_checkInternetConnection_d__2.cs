using UnityEngine;
private sealed class ConnectionTestExecuter.<checkInternetConnection>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<bool, string> action;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectionTestExecuter.<checkInternetConnection>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        string val_3;
        var val_4;
        var val_5;
        int val_6;
        val_2 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
        this.<>1__state = 0;
        if(UnityEngine.Application.internetReachability == 0)
        {
            goto label_3;
        }
        
        if(this.action == null)
        {
            goto label_9;
        }
        
        val_3 = "Connection available";
        val_4 = 1152921526435555328;
        val_5 = 1;
        goto label_5;
        label_1:
        val_6 = 0;
        goto label_6;
        label_3:
        UnityEngine.Debug.Log(message:  "Error. Check internet connection!");
        if(this.action == null)
        {
            goto label_9;
        }
        
        val_3 = "No internet connection";
        val_4 = 1152921526435555328;
        val_5 = 0;
        label_5:
        this.action.Invoke(arg1:  false, arg2:  val_3);
        label_9:
        val_6 = 1;
        val_2 = 1;
        this.<>2__current = 0;
        label_6:
        this.<>1__state = val_6;
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
