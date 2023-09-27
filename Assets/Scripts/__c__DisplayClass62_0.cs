using UnityEngine;
private sealed class MMOCClientUser.<>c__DisplayClass62_0
{
    // Fields
    public MMOCClientUser <>4__this;
    public UnityEngine.Events.UnityAction<bool, string> onDone;
    
    // Methods
    public MMOCClientUser.<>c__DisplayClass62_0()
    {
    
    }
    internal void <RefreshToken>b__0(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse res)
    {
        UnityEngine.Events.UnityAction<System.Boolean, System.String> val_8;
        string val_9;
        string val_10;
        string val_11;
        val_8 = this;
        if(res != null)
        {
                if(res.StatusCode == 200)
        {
                this.<>4__this.authResult = UnityEngine.JsonUtility.FromJson<MMOCLoginResponseData>(json:  res.DataAsText);
            this.<>4__this.SetToken(aNewToken:  this.<>4__this.authResult.access_token, aNewTokenType:  this.<>4__this.authResult.token_type);
            NFUser val_4 = NFUser.current;
            val_9 = this.<>4__this.authResult.refresh_token;
            val_4.loginUserInfo.refreshCode = val_9;
            if(this.onDone == null)
        {
                return;
        }
        
            val_9 = this.<>4__this.authResult;
            this.onDone.Invoke(arg0:  true, arg1:  this.<>4__this.authResult.access_token);
            return;
        }
        
        }
        
        val_9 = this.<>4__this;
        this.<>4__this.authResult = 0;
        val_8 = this.onDone;
        if(val_8 == null)
        {
                return;
        }
        
        if(res != null)
        {
                val_10 = res.Message;
            val_11 = res.DataAsText;
        }
        else
        {
                val_10 = 0;
            val_11 = 0;
        }
        
        val_8.Invoke(arg0:  false, arg1:  "Please check your network connection <br>[Error in ggp jwt refresh: "("Please check your network connection <br>[Error in ggp jwt refresh: ") + val_10 + val_11 + "]");
    }

}
