using UnityEngine;
private sealed class MMOCClientUser.<>c__DisplayClass56_0
{
    // Fields
    public MMOCClientUser <>4__this;
    public UnityEngine.Events.UnityAction<bool, string> onLoginDone;
    
    // Methods
    public MMOCClientUser.<>c__DisplayClass56_0()
    {
    
    }
    internal void <Login>b__0(bool success, string url)
    {
        string val_13;
        string val_14;
        val_13 = url;
        this.<>4__this.accessToken = AndroidDeepLink.GetValue(url:  val_13, key:  "access_token");
        this.<>4__this.tokenType = AndroidDeepLink.GetValue(url:  val_13, key:  "token_type");
        if(success != false)
        {
                val_14 = this.<>4__this.accessToken;
            val_13 = "MMOC Token " + this.<>4__this.accessToken(this.<>4__this.accessToken);
            UnityEngine.Debug.Log(message:  val_13);
        }
        else
        {
                val_14 = 0;
            if((System.String.IsNullOrEmpty(value:  val_13)) != true)
        {
                val_14 = System.String.Format(format:  "{0}: {1}", arg0:  AndroidDeepLink.GetValue(url:  val_13, key:  "error"), arg1:  AndroidDeepLink.GetValue(url:  val_13, key:  "error_description")).Replace(oldValue:  "%20", newValue:  " ");
            val_13 = "MMOC Error " + val_14;
            UnityEngine.Debug.LogError(message:  val_13);
        }
        
        }
        
        if(this.onLoginDone == null)
        {
                return;
        }
        
        this.onLoginDone.Invoke(arg0:  success, arg1:  val_14);
    }

}
