using UnityEngine;
private sealed class API.<GetAccessToken>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string consumerKey;
    public string consumerSecret;
    public string requestToken;
    public string pin;
    public Twitter.AccessTokenCallback callback;
    private UnityEngine.WWW <web>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public API.<GetAccessToken>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Twitter.AccessTokenCallback val_28;
        string val_29;
        int val_30;
        string val_32;
        val_28 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_29 = this.requestToken;
        UnityEngine.WWW val_1 = Twitter.API.WWWAccessToken(consumerKey:  this.consumerKey, consumerSecret:  this.consumerSecret, requestToken:  val_29, pin:  this.pin);
        this.<web>5__2 = val_1;
        this.<>2__current = val_1;
        val_30 = 1;
        this.<>1__state = val_30;
        return (bool)val_30;
        label_1:
        this.<>1__state = 0;
        if((System.String.IsNullOrEmpty(value:  this.<web>5__2.error)) != false)
        {
                Twitter.AccessTokenResponse val_4 = new Twitter.AccessTokenResponse();
            .<Token>k__BackingField = System.Text.RegularExpressions.Regex.Match(input:  this.<web>5__2.text, pattern:  "oauth_token=([^&]+)").Item[1].Value;
            .<TokenSecret>k__BackingField = System.Text.RegularExpressions.Regex.Match(input:  this.<web>5__2.text, pattern:  "oauth_token_secret=([^&]+)").Item[1].Value;
            .<UserId>k__BackingField = System.Text.RegularExpressions.Regex.Match(input:  this.<web>5__2.text, pattern:  "user_id=([^&]+)").Item[1].Value;
            val_29 = System.Text.RegularExpressions.Regex.Match(input:  this.<web>5__2.text, pattern:  "screen_name=([^&]+)").Item[1];
            .<ScreenName>k__BackingField = val_29.Value;
            if(((System.String.IsNullOrEmpty(value:  (Twitter.AccessTokenResponse)[1152921529157723248].<Token>k__BackingField)) != true) && ((System.String.IsNullOrEmpty(value:  (Twitter.AccessTokenResponse)[1152921529157723248].<TokenSecret>k__BackingField)) != true))
        {
                if((System.String.IsNullOrEmpty(value:  (Twitter.AccessTokenResponse)[1152921529157723248].<UserId>k__BackingField)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  (Twitter.AccessTokenResponse)[1152921529157723248].<ScreenName>k__BackingField)) == false)
        {
            goto label_30;
        }
        
        }
        
        }
        
            string val_25 = this.<web>5__2.text;
            val_32 = "GetAccessToken - failed. response : {0}";
        }
        else
        {
                val_32 = "GetAccessToken - failed. error : {0}";
        }
        
        UnityEngine.Debug.Log(message:  System.String.Format(format:  val_32, arg0:  this.<web>5__2.error));
        val_28 = this.callback;
        label_38:
        val_28.Invoke(success:  false, response:  0);
        label_2:
        val_30 = 0;
        return (bool)val_30;
        label_30:
        if(this.callback != null)
        {
            goto label_38;
        }
        
        goto label_38;
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
