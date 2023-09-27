using UnityEngine;
private sealed class MVCNetworkManager.<>c__DisplayClass46_0
{
    // Fields
    public NFClientUser.NFResponsCreateRoom createRoomResponse;
    public InkWars.Model.MVCNetworkManager <>4__this;
    
    // Methods
    public MVCNetworkManager.<>c__DisplayClass46_0()
    {
    
    }
    internal void <CreatePublicRoom>b__1(MMOCClientUser.JoinedPoolData res)
    {
        string val_12;
        if(res.IsSuccess != false)
        {
                this.<>4__this.AttachSocketStartListener();
            NFUser.current.clientUser.StartSocketIo();
            InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.PrintState(state:  "LK.Lobby.StatusMsg9", showLog:  true);
            DialogManager.HideLoading();
            return;
        }
        
        if(this.createRoomResponse != null)
        {
            
        }
        else
        {
                val_12 = 0;
        }
        
        string val_7 = LanguageManager.GetText(key:  "LK.JoinRoomFail")(LanguageManager.GetText(key:  "LK.JoinRoomFail")) + "\n" + val_12;
        DialogPanel val_9 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  val_7, cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
        UnityEngine.Debug.LogError(message:  "Create room fail: "("Create room fail: ") + val_7);
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
    }

}
