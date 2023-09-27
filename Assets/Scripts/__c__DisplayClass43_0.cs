using UnityEngine;
private sealed class MVCNetworkManager.<>c__DisplayClass43_0
{
    // Fields
    public NFClientUser.NFResponseRoom joinRoomResponse;
    public InkWars.Model.MVCNetworkManager <>4__this;
    
    // Methods
    public MVCNetworkManager.<>c__DisplayClass43_0()
    {
    
    }
    internal void <JoinNFRoom>b__1(MMOCClientUser.JoinedPoolData res)
    {
        string val_10;
        if(res.IsSuccess != false)
        {
                this.<>4__this.privateWager = this.joinRoomResponse.wager;
            this.<>4__this.AttachSocketStartListener();
            NFUser.current.clientUser.StartSocketIo();
            return;
        }
        
        this.<>4__this._isTryingToJoin = false;
        this.<>4__this.keepCheckingRoomStatus = false;
        if((this.<>4__this.checkRoomStatusCoroutine) != null)
        {
                this.<>4__this.StopCoroutine(routine:  this.<>4__this.checkRoomStatusCoroutine);
        }
        
        if(this.joinRoomResponse != null)
        {
            
        }
        else
        {
                val_10 = 0;
        }
        
        string val_6 = LanguageManager.GetText(key:  "LK.JoinRoomFail")(LanguageManager.GetText(key:  "LK.JoinRoomFail")) + "\n" + val_10;
        DialogPanel val_8 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  val_6, cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
        UnityEngine.Debug.LogError(message:  "Join room fail: "("Join room fail: ") + val_6);
    }

}
