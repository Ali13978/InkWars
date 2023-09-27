using UnityEngine;
private sealed class OfflineTitleScreenBar.<checkInternetConnection>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<bool> action;
    public OfflineTitleScreenBar <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OfflineTitleScreenBar.<checkInternetConnection>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) > 1)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if(UnityEngine.Application.internetReachability == 0)
        {
            goto label_2;
        }
        
        0.FetchRemote(action:  this.action);
        if((this.<>4__this) != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        val_3 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.interval);
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_2:
        UnityEngine.Debug.Log(message:  "Error. Check internet connection!");
        this.action.Invoke(obj:  false);
        if((this.<>4__this) != null)
        {
            goto label_9;
        }
        
        goto label_10;
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
