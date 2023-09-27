using UnityEngine;
private sealed class MVCNetworkManager.<>c__DisplayClass47_0
{
    // Fields
    public InkWars.Model.MVCNetworkManager <>4__this;
    public string randomPin;
    
    // Methods
    public MVCNetworkManager.<>c__DisplayClass47_0()
    {
    
    }
    internal void <CreateNFPrivateRoom>b__0(NFClientUser.NFResponsCreateRoom createRoomResponse)
    {
        MVCNetworkManager.<>c__DisplayClass47_1 val_1 = new MVCNetworkManager.<>c__DisplayClass47_1();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .createRoomResponse = createRoomResponse;
        mem[1152921529311376584] = this;
        if(createRoomResponse != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        if(createRoomResponse.IsSuccess == false)
        {
            goto label_3;
        }
        
        if((createRoomResponse.poolID == 0) || (createRoomResponse.wager <= 0f))
        {
            goto label_9;
        }
        
        NFUser.current.mmocUser.JoinPool(poolId:  createRoomResponse.poolID, initGems:  createRoomResponse.wager, onJoinPoolDone:  new UnityEngine.Events.UnityAction<JoinedPoolData>(object:  val_1, method:  System.Void MVCNetworkManager.<>c__DisplayClass47_1::<CreateNFPrivateRoom>b__1(MMOCClientUser.JoinedPoolData res)));
        return;
        label_3:
        DialogPanel val_9 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  LanguageManager.GetText(key:  "LK.CreateRoomFail"), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onCancelCallback:  0);
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.ShutdownNetwork(forceAutoStart:  false, couldBeRageQuit:  false, reloadScene:  true, delay:  0f, notifyUser:  true);
        return;
        label_1:
        mem[24] = this;
        mem[16] = createRoomResponse;
        if(mem[16] != 0)
        {
            goto label_21;
        }
        
        goto label_22;
        label_9:
        this.<>4__this.AttachSocketStartListener();
        NFUser.current.clientUser.StartSocketIo();
        InkWars.Model.MVC_Multiplayer_Manager_Base.Instance.PrintState(state:  "LK.Lobby.StatusMsg9", showLog:  true);
        InkWars.Model.MVC_Multiplayer_Manager_Base val_14 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
        InkWars.Model.MVC_Multiplayer_Manager_Base val_15 = InkWars.Model.MVC_Multiplayer_Manager_Base.Instance;
        if(val_15.OnCreatePrivateRoomAction != null)
        {
                val_15.OnCreatePrivateRoomAction.Invoke(obj:  this.randomPin);
        }
        
        DialogManager.HideLoading();
    }

}
