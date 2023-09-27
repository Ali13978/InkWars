using UnityEngine;
private sealed class Client.<SendRequest>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.Networking.UnityWebRequest request;
    public System.Collections.Generic.SortedDictionary<string, string> parameters;
    public string method;
    public string requestURL;
    public Twitter.TwitterCallback callback;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Client.<SendRequest>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Twitter.TwitterCallback val_14;
        int val_15;
        string val_16;
        var val_17;
        val_14 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.request.SetRequestHeader(name:  "Authorization", value:  Twitter.Oauth.GenerateHeaderWithAccessToken(parameters:  this.parameters, requestMethod:  this.method, requestURL:  this.requestURL));
        this.<>2__current = this.request.Send();
        val_15 = 1;
        this.<>1__state = val_15;
        return (bool)val_15;
        label_1:
        this.<>1__state = 0;
        if(this.request.isNetworkError == false)
        {
            goto label_7;
        }
        
        val_14 = this.callback;
        label_23:
        val_16 = JsonHelper.ArrayToObject(arrayString:  this.request.error);
        val_17 = 0;
        goto label_10;
        label_7:
        if(this.request.responseCode != 200)
        {
                if(this.request.responseCode != 201)
        {
            goto label_14;
        }
        
        }
        
        val_14 = this.callback;
        val_16 = JsonHelper.ArrayToObject(arrayString:  this.request.downloadHandler.text);
        val_17 = 1;
        label_10:
        val_14.Invoke(success:  true, response:  val_16);
        label_2:
        val_15 = 0;
        return (bool)val_15;
        label_14:
        UnityEngine.Debug.Log(message:  this.request.responseCode);
        string val_13 = this.request.downloadHandler.text;
        goto label_23;
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
