using UnityEngine;
private sealed class NetworkLobbySuponic.<>c__DisplayClass15_0
{
    // Fields
    public string info;
    public NetworkLobbySuponic <>4__this;
    public UnityEngine.Events.UnityAction<MMOCClientUser.MMOCUserProfile> <>9__3;
    
    // Methods
    public NetworkLobbySuponic.<>c__DisplayClass15_0()
    {
    
    }
    internal void <GGModePublicClicked>b__2(bool success2, string info2)
    {
        if(success2 == false)
        {
            goto label_1;
        }
        
        MMOCClientUser val_1 = MMOCUser.current;
        if((this.<>9__3) == null)
        {
            goto label_2;
        }
        
        label_7:
        val_1.GetUserProfile(onGetUserProfileDone:  this.<>9__3);
        return;
        label_1:
        UnityEngine.Debug.LogError(message:  "Login MMOC Fail: Cannot Get User");
        return;
        label_2:
        this.<>9__3 = new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  this, method:  System.Void NetworkLobbySuponic.<>c__DisplayClass15_0::<GGModePublicClicked>b__3(MMOCClientUser.MMOCUserProfile profile_2nd));
        if(val_1 != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    internal void <GGModePublicClicked>b__3(MMOCClientUser.MMOCUserProfile profile_2nd)
    {
        DialogManager.HideLoading();
        if(profile_2nd != null)
        {
                this.<>4__this.OnLoginMMOCDone();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Login MMOC Fail: Cannot Get User");
        DialogPanel val_4 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  LanguageManager.GetText(key:  "LK.LoginMMOCFailKnown")(LanguageManager.GetText(key:  "LK.LoginMMOCFailKnown")) + " " + this.info, cancelButtonTitle:  0, onCancelCallback:  0);
    }

}
