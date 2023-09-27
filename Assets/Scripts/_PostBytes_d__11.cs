using UnityEngine;
private sealed class ErrorHandler.<PostBytes>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ErrorHandler <>4__this;
    public byte[] data;
    private UnityEngine.Networking.UnityWebRequest <webRequest>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ErrorHandler.<PostBytes>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
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
        int val_8;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_50;
        }
        
        this.<>1__state = -3;
        if((this.<webRequest>5__2.responseCode) != 200)
        {
            goto label_4;
        }
        
        UnityEngine.Debug.Log(message:  "Successfully posted error report");
        goto label_7;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Networking.UnityWebRequest val_2 = UnityEngine.Networking.UnityWebRequest.Put(uri:  this.<>4__this.PostURL, bodyData:  this.data);
        this.<webRequest>5__2 = val_2;
        this.<>1__state = -3;
        val_2.method = "POST";
        this.<webRequest>5__2.SetRequestHeader(name:  "X-HTTP-Method-Override", value:  "POST");
        this.<webRequest>5__2.SetRequestHeader(name:  "Content-Type", value:  "application/json");
        this.<>2__current = this.<webRequest>5__2.SendWebRequest();
        val_8 = 1;
        this.<>1__state = val_8;
        return (bool)val_8;
        label_4:
        object[] val_4 = new object[4];
        val_4[0] = "Could not post error report: ";
        val_4[1] = this.<webRequest>5__2.responseCode;
        val_4[2] = " ";
        val_4[3] = this.<webRequest>5__2.error;
        UnityEngine.Debug.Log(message:  +val_4);
        label_7:
        this.<>m__Finally1();
        this.<webRequest>5__2 = 0;
        val_8 = 0;
        ErrorHandler.LogInProgress = false;
        return (bool)val_8;
        label_50:
        val_8 = 0;
        return (bool)val_8;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<webRequest>5__2) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.<webRequest>5__2.Dispose();
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
