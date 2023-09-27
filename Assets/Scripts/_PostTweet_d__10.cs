using UnityEngine;
private sealed class API.<PostTweet>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string text;
    public Twitter.PostTweetCallback callback;
    public string consumerKey;
    public string consumerSecret;
    public Twitter.AccessTokenResponse response;
    private UnityEngine.WWW <web>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public API.<PostTweet>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Twitter.PostTweetCallback val_23;
        UnityEngine.WWW val_24;
        var val_25;
        var val_26;
        val_23 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if(((System.String.IsNullOrEmpty(value:  this.text)) == true) || (this.text.Length >= 141))
        {
            goto label_5;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_3 == null)
        {
            goto label_6;
        }
        
        val_3.Add(key:  "screen_name", value:  "@inkwarsgame");
        goto label_7;
        label_1:
        this.<>1__state = 0;
        val_24 = System.String.IsNullOrEmpty(value:  this.<web>5__2.error);
        if((this.<web>5__2) == null)
        {
            goto label_9;
        }
        
        if(val_24 == false)
        {
            goto label_10;
        }
        
        label_23:
        string val_9 = System.Text.RegularExpressions.Regex.Match(input:  this.<web>5__2.text, pattern:  "<error>([^&]+)</error>").Item[1].Value;
        if((System.String.IsNullOrEmpty(value:  val_9)) == false)
        {
            goto label_16;
        }
        
        val_25 = 1;
        goto label_18;
        label_5:
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "PostTweet - text[{0}] is empty or too long.", arg0:  this.text));
        val_23 = this.callback;
        val_23.Invoke(success:  false);
        label_2:
        val_26 = 0;
        return (bool)val_26;
        label_9:
        if(val_24 == true)
        {
            goto label_23;
        }
        
        label_10:
        val_24 = this.<web>5__2;
        string val_14 = System.String.Format(format:  "PostTweet - failed. {0}\n{1}", arg0:  this.<web>5__2.error, arg1:  val_24.text);
        goto label_25;
        label_16:
        label_25:
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "PostTweet - failed. {0}", arg0:  val_9));
        val_25 = 0;
        label_18:
        this.callback.Invoke(success:  false);
        val_26 = 0;
        this.<web>5__2 = 0;
        return (bool)val_26;
        label_6:
        val_3.Add(key:  "screen_name", value:  "@inkwarsgame");
        label_7:
        val_3.Add(key:  "user_id", value:  "3270634327");
        val_3.Add(key:  "follow", value:  "true");
        new UnityEngine.WWWForm().AddField(fieldName:  "status", value:  this.text);
        System.Collections.Generic.Dictionary<System.String, System.String> val_17 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        string val_18 = Twitter.API.GetHeaderWithAccessToken(httpRequestType:  "GET", apiURL:  "https://api.twitter.com/1.1/friends/ids.json", consumerKey:  this.consumerKey, consumerSecret:  this.consumerSecret, response:  this.response, parameters:  val_3);
        if(val_17 != null)
        {
                val_17.Add(key:  "Authorization", value:  val_18);
        }
        else
        {
                val_17.Add(key:  "Authorization", value:  val_18);
        }
        
        UnityEngine.Debug.Log(message:  "Authorization " + val_17.Item["Authorization"]);
        UnityEngine.WWW val_22 = new UnityEngine.WWW(url:  "https://api.twitter.com/1.1/friends/ids.json", postData:  new byte[1], headers:  val_17);
        this.<web>5__2 = val_22;
        this.<>2__current = val_22;
        this.<>1__state = 1;
        return (bool)val_26;
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
