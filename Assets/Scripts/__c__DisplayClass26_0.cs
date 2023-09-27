using UnityEngine;
private sealed class NFUser.<>c__DisplayClass26_0
{
    // Fields
    public System.Action OnRegisterDone;
    
    // Methods
    public NFUser.<>c__DisplayClass26_0()
    {
    
    }
    internal void <CreateAccount>b__0(IResponse registerResponse)
    {
        if(registerResponse.IsSuccess != false)
        {
                if(this.OnRegisterDone == null)
        {
                return;
        }
        
            this.OnRegisterDone.Invoke();
            return;
        }
        
        DialogManager.HideLoading();
        DialogPanel val_4 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Loginfail"), message:  registerResponse.msg, cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
    }

}
