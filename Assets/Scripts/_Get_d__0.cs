using UnityEngine;
private sealed class Client.<Get>d__0 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string APIPath;
    public System.Collections.Generic.Dictionary<string, string> APIParams;
    public Twitter.TwitterCallback callback;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Client.<Get>d__0(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        int val_8;
        val_7 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            string val_1 = "https://api.twitter.com/1.1/"("https://api.twitter.com/1.1/") + this.APIPath + ".json";
            System.Collections.Generic.SortedDictionary<System.String, System.String> val_2 = Twitter.Helper.ConvertToSortedDictionary(APIParams:  this.APIParams);
            UnityEngine.Networking.UnityWebRequest val_5 = UnityEngine.Networking.UnityWebRequest.Get(uri:  val_1 + "?"("?") + Twitter.Helper.GenerateRequestparams(parameters:  val_2)(Twitter.Helper.GenerateRequestparams(parameters:  val_2)));
            val_5.SetRequestHeader(name:  "ContentType", value:  "application/x-www-form-urlencoded");
            this.<>2__current = Twitter.Client.SendRequest(request:  val_5, parameters:  val_2, method:  "GET", requestURL:  val_1, callback:  this.callback);
            val_8 = 1;
            val_7 = 1;
        }
        else
        {
                val_8 = 0;
        }
        
        this.<>1__state = val_8;
        return (bool)val_7;
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
