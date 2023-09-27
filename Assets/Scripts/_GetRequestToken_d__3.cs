using UnityEngine;
private sealed class API.<GetRequestToken>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string consumerKey;
    public string consumerSecret;
    public Twitter.RequestTokenCallback callback;
    private UnityEngine.WWW <web>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public API.<GetRequestToken>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Twitter.RequestTokenCallback val_18;
        int val_19;
        string val_21;
        val_18 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.WWW val_1 = Twitter.API.WWWRequestToken(consumerKey:  this.consumerKey, consumerSecret:  this.consumerSecret);
        this.<web>5__2 = val_1;
        this.<>2__current = val_1;
        val_19 = 1;
        this.<>1__state = val_19;
        return (bool)val_19;
        label_1:
        this.<>1__state = 0;
        if((System.String.IsNullOrEmpty(value:  this.<web>5__2.error)) != false)
        {
                Twitter.RequestTokenResponse val_4 = new Twitter.RequestTokenResponse();
            .<Token>k__BackingField = System.Text.RegularExpressions.Regex.Match(input:  this.<web>5__2.text, pattern:  "oauth_token=([^&]+)").Item[1].Value;
            .<TokenSecret>k__BackingField = System.Text.RegularExpressions.Regex.Match(input:  this.<web>5__2.text, pattern:  "oauth_token_secret=([^&]+)").Item[1].Value;
            if((System.String.IsNullOrEmpty(value:  (Twitter.RequestTokenResponse)[1152921529156754784].<Token>k__BackingField)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  (Twitter.RequestTokenResponse)[1152921529156754784].<TokenSecret>k__BackingField)) == false)
        {
            goto label_20;
        }
        
        }
        
            string val_15 = this.<web>5__2.text;
            val_21 = "GetRequestToken - failed. response : {0}";
        }
        else
        {
                val_21 = "GetRequestToken - failed. error : {0}";
        }
        
        UnityEngine.Debug.Log(message:  System.String.Format(format:  val_21, arg0:  this.<web>5__2.error));
        val_18 = this.callback;
        label_28:
        val_18.Invoke(success:  false, response:  0);
        label_2:
        val_19 = 0;
        return (bool)val_19;
        label_20:
        if(this.callback != null)
        {
            goto label_28;
        }
        
        goto label_28;
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
