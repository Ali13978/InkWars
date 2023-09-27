using UnityEngine;
private sealed class MMOCClientUser.<>c__DisplayClass52_0
{
    // Fields
    public MMOCClientUser <>4__this;
    public UnityEngine.Events.UnityAction<bool, string> onLoginDone;
    
    // Methods
    public MMOCClientUser.<>c__DisplayClass52_0()
    {
    
    }
    internal void <GetAuthCode>b__0(bool success, string url)
    {
        MMOCClientUser val_10;
        string val_11;
        this.<>4__this.authCode = AndroidDeepLink.GetValue(url:  url, key:  "code");
        if(success == false)
        {
            goto label_2;
        }
        
        val_10 = this.<>4__this;
        if((this.<>4__this) != null)
        {
            goto label_3;
        }
        
        val_10 = this.<>4__this;
        if(val_10 == null)
        {
            goto label_4;
        }
        
        label_3:
        val_11 = this.<>4__this._authCode;
        UnityEngine.Debug.Log(message:  "MMOC code " + this.<>4__this._authCode(this.<>4__this._authCode));
        goto label_8;
        label_2:
        val_11 = 0;
        if((System.String.IsNullOrEmpty(value:  url)) != true)
        {
                val_11 = System.String.Format(format:  "{0}: {1}", arg0:  AndroidDeepLink.GetValue(url:  url, key:  "error"), arg1:  AndroidDeepLink.GetValue(url:  url, key:  "error_description")).Replace(oldValue:  "%20", newValue:  " ");
            UnityEngine.Debug.LogError(message:  "MMOC Error " + val_11);
        }
        
        label_8:
        InAppBrowser.CloseBrowser();
        if(this.onLoginDone == null)
        {
                return;
        }
        
        this.onLoginDone.Invoke(arg0:  success, arg1:  val_11);
        return;
        label_4:
    }

}
