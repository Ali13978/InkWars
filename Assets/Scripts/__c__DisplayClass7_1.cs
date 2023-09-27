using UnityEngine;
private sealed class SetWager.<>c__DisplayClass7_1
{
    // Fields
    public string info;
    public SetWager.<>c__DisplayClass7_0 CS$<>8__locals1;
    public UnityEngine.Events.UnityAction<MMOCClientUser.MMOCUserProfile> <>9__3;
    
    // Methods
    public SetWager.<>c__DisplayClass7_1()
    {
    
    }
    internal void <SetWagerDone>b__2(bool success2, string info2)
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
        this.<>9__3 = new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  this, method:  System.Void SetWager.<>c__DisplayClass7_1::<SetWagerDone>b__3(MMOCClientUser.MMOCUserProfile profile_2nd));
        if(val_1 != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    internal void <SetWagerDone>b__3(MMOCClientUser.MMOCUserProfile profile_2nd)
    {
        SetWager.<>c__DisplayClass7_0 val_5;
        DialogManager.HideLoading();
        if(profile_2nd != null)
        {
                val_5 = this.CS$<>8__locals1;
            if((this.CS$<>8__locals1) == null)
        {
                val_5 = this.CS$<>8__locals1;
        }
        
            this.CS$<>8__locals1.<>4__this.Checkwagers(wager:  new System.Decimal() {flags = profile_2nd.gems, hi = profile_2nd.gems, lo = profile_2nd, mid = profile_2nd}, enteredAmount:  new System.Decimal() {flags = this.CS$<>8__locals1.wagerFloat, hi = this.CS$<>8__locals1.wagerFloat, lo = val_5, mid = val_5});
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Login MMOC Fail: Cannot Get User");
        DialogPanel val_4 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  LanguageManager.GetText(key:  "LK.LoginMMOCFailKnown")(LanguageManager.GetText(key:  "LK.LoginMMOCFailKnown")) + " " + this.info, cancelButtonTitle:  0, onCancelCallback:  0);
    }

}
