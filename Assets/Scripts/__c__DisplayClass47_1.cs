using UnityEngine;
private sealed class MVCNetworkManager.<>c__DisplayClass47_1
{
    // Fields
    public NFClientUser.NFResponsCreateRoom createRoomResponse;
    public InkWars.Model.MVCNetworkManager.<>c__DisplayClass47_0 CS$<>8__locals1;
    
    // Methods
    public MVCNetworkManager.<>c__DisplayClass47_1()
    {
    
    }
    internal void <CreateNFPrivateRoom>b__1(MMOCClientUser.JoinedPoolData res)
    {
        MVCNetworkManager.<>c__DisplayClass47_0 val_14;
        string val_15;
        val_14 = this;
        if(res.IsSuccess != false)
        {
                this.CS$<>8__locals1.<>4__this.AttachSocketStartListener();
            NFUser.current.clientUser.StartSocketIo();
            InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.PrintState(state:  "LK.Lobby.StatusMsg9", showLog:  true);
            InkWars.Model.MVC_Multiplayer_Manager_Base val_5 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            InkWars.Model.MVC_Multiplayer_Manager_Base val_6 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
            if(val_6.OnCreatePrivateRoomAction != null)
        {
                val_14 = this.CS$<>8__locals1;
            val_6.OnCreatePrivateRoomAction.Invoke(obj:  this.CS$<>8__locals1.randomPin);
        }
        
            DialogManager.HideLoading();
            return;
        }
        
        if(this.createRoomResponse != null)
        {
            
        }
        else
        {
                val_15 = 0;
        }
        
        string val_9 = LanguageManager.GetText(key:  "LK.JoinRoomFail")(LanguageManager.GetText(key:  "LK.JoinRoomFail")) + "\n" + val_15;
        DialogPanel val_11 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  val_9, cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
        UnityEngine.Debug.LogError(message:  "Create room fail: "("Create room fail: ") + val_9);
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
    }

}
