using UnityEngine;
private sealed class SetWager.<>c__DisplayClass7_0
{
    // Fields
    public SetWager <>4__this;
    public decimal wagerFloat;
    public UnityEngine.Events.UnityAction<bool, string> <>9__1;
    
    // Methods
    public SetWager.<>c__DisplayClass7_0()
    {
    
    }
    internal void <SetWagerDone>b__0(MMOCClientUser.MMOCUserProfile profile)
    {
        DialogManager.HideLoading();
        if(profile != null)
        {
                this.<>4__this.Checkwagers(wager:  new System.Decimal() {flags = profile.gems, hi = profile.gems, lo = profile, mid = profile}, enteredAmount:  new System.Decimal() {flags = this.wagerFloat, hi = this.wagerFloat, lo = -1290513840, mid = 268435461});
            return;
        }
        
        MMOCClientUser val_1 = MMOCUser.current;
        if((this.<>9__1) == null)
        {
            goto label_3;
        }
        
        label_6:
        val_1.GetAuthCode(onLoginDone:  this.<>9__1);
        return;
        label_3:
        this.<>9__1 = new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  this, method:  System.Void SetWager.<>c__DisplayClass7_0::<SetWagerDone>b__1(bool success, string info));
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_6;
    }
    internal void <SetWagerDone>b__1(bool success, string info)
    {
        UnityEngine.Events.UnityAction<System.Boolean, System.String> val_9;
        object val_10;
        val_9 = success;
        SetWager.<>c__DisplayClass7_1 val_1 = null;
        val_10 = val_1;
        val_1 = new SetWager.<>c__DisplayClass7_1();
        if(val_10 != null)
        {
                .CS$<>8__locals1 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .info = info;
        if(val_9 != false)
        {
                DialogManager.ShowLoading();
            UnityEngine.Events.UnityAction<System.Boolean, System.String> val_3 = null;
            val_9 = val_3;
            val_3 = new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  val_1, method:  System.Void SetWager.<>c__DisplayClass7_1::<SetWagerDone>b__2(bool success2, string info2));
            MMOCUser.current.GetToken(onDone:  val_3);
        }
        else
        {
                if((System.String.IsNullOrEmpty(value:  info)) != true)
        {
                UnityEngine.Debug.LogError(message:  "Login MMOC Fail: "("Login MMOC Fail: ") + (SetWager.<>c__DisplayClass7_1)[1152921529086343376].info((SetWager.<>c__DisplayClass7_1)[1152921529086343376].info));
            val_10 = LanguageManager.GetText(key:  "LK.Error");
            DialogPanel val_8 = DialogManager.Show(title:  val_10, message:  LanguageManager.GetText(key:  "LK.LoginMMOCFailUnKnown"), cancelButtonTitle:  0, onCancelCallback:  0);
        }
        
        }
        
        DialogManager.HideLoading();
    }

}
