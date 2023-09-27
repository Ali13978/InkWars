using UnityEngine;
public class NFMMOCExampleUI : MonoBehaviour
{
    // Fields
    private MMOCClientUser mmocUser;
    private NFClientUser gameUser;
    private UnityEngine.UI.Button loginMMOC_A;
    private UnityEngine.UI.Button loginMMOC_B;
    private UnityEngine.UI.Button refreshMMOCProfile;
    private UnityEngine.UI.Button joinPool;
    private UnityEngine.UI.Button postPoolUserId;
    private UnityEngine.UI.Button AddGems;
    private UnityEngine.UI.Text mmocProfileTxt;
    private UnityEngine.UI.InputField userName;
    private UnityEngine.UI.InputField password;
    private UnityEngine.UI.InputField serverIP;
    private UnityEngine.UI.Button setupIp;
    private UnityEngine.UI.Button createAccount;
    private UnityEngine.UI.Button login;
    private UnityEngine.UI.Button createRoom;
    private UnityEngine.UI.Button getList;
    private UnityEngine.UI.Button getRoomInfo;
    private UnityEngine.UI.Button joinRoom;
    private UnityEngine.UI.Button deleteRoom;
    private UnityEngine.UI.Button leaveRoom;
    private UnityEngine.UI.Button ILose;
    
    // Methods
    public void LoginEditor(string username, string password)
    {
        DialogPanel val_1 = DialogManager.Show(title:  "Login Fail", message:  "Editor required, unless you uncomment #if UNITY_EDITOR in various places", cancelButtonTitle:  0, onCancelCallback:  0);
    }
    private void Start()
    {
        var val_31;
        var val_33;
        if(this.loginMMOC_A != 0)
        {
                this.loginMMOC_A.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_0()));
        }
        
        if(this.loginMMOC_B != 0)
        {
                this.loginMMOC_B.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_1()));
        }
        
        this.AddGems.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_2()));
        this.refreshMMOCProfile.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_3()));
        this.joinPool.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_4()));
        this.createAccount.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_5()));
        this.login.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_6()));
        this.createRoom.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_7()));
        this.getList.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_8()));
        this.joinRoom.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_9()));
        ButtonClickedEvent val_23 = this.deleteRoom.onClick;
        val_31 = null;
        val_31 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_10) == null)
        {
            goto label_30;
        }
        
        label_44:
        val_23.AddListener(call:  NFMMOCExampleUI.<>c.<>9__23_10);
        this.leaveRoom.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_11()));
        if(this.ILose == null)
        {
            goto label_34;
        }
        
        ButtonClickedEvent val_26 = this.ILose.onClick;
        val_33 = null;
        val_33 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_12) == null)
        {
            goto label_37;
        }
        
        label_48:
        val_26.AddListener(call:  NFMMOCExampleUI.<>c.<>9__23_12);
        label_34:
        this.setupIp.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFMMOCExampleUI::<Start>b__23_13()));
        return;
        label_30:
        NFMMOCExampleUI.<>c.<>9__23_10 = new UnityEngine.Events.UnityAction(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_10());
        if(val_23 != null)
        {
            goto label_44;
        }
        
        goto label_44;
        label_37:
        NFMMOCExampleUI.<>c.<>9__23_12 = new UnityEngine.Events.UnityAction(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_12());
        if(val_26 != null)
        {
            goto label_48;
        }
        
        goto label_48;
    }
    private void OnEnable()
    {
        this.mmocUser.OnEvents.AddListener(call:  new UnityEngine.Events.UnityAction<MMOCEvents>(object:  this, method:  System.Void NFMMOCExampleUI::OnUserEvents(MMOCEvents mmocEvent)));
    }
    private void OnDisable()
    {
        this.mmocUser.OnEvents.RemoveListener(call:  new UnityEngine.Events.UnityAction<MMOCEvents>(object:  this, method:  System.Void NFMMOCExampleUI::OnUserEvents(MMOCEvents mmocEvent)));
    }
    private void OnUserEvents(MMOCEvents mmocEvent)
    {
        if(mmocEvent != 1)
        {
                return;
        }
        
        this.RefreshProfileText();
    }
    private void RefreshProfileText()
    {
        if(this.mmocUser.userProfile != null)
        {
                string val_3 = UnityEngine.JsonUtility.ToJson(obj:  this.mmocUser.userProfile);
            if(this.mmocProfileTxt == null)
        {
            
        }
        
        }
    
    }
    public NFMMOCExampleUI()
    {
        this.mmocUser = new MMOCClientUser();
        this.gameUser = new NFClientUser();
    }
    private void <Start>b__23_0()
    {
        this.LoginEditor(username:  null, password:  null);
    }
    private void <Start>b__23_1()
    {
        this.LoginEditor(username:  null, password:  null);
    }
    private void <Start>b__23_2()
    {
        var val_3;
        if(((this.gameUser.<additionalRoomInfo>k__BackingField) == null) || ((this.gameUser.<additionalRoomInfo>k__BackingField.poolid) == 0))
        {
            goto label_5;
        }
        
        val_3 = null;
        val_3 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_14) == null)
        {
            goto label_10;
        }
        
        label_15:
        this.mmocUser.AddGems(poolId:  this.gameUser.<additionalRoomInfo>k__BackingField.poolid, addedGems:  new System.Decimal(), onAddGemsDone:  NFMMOCExampleUI.<>c.<>9__23_14);
        return;
        label_5:
        DialogPanel val_1 = DialogManager.Show(title:  "error", message:  "No pool created for current room", cancelButtonTitle:  0, onCancelCallback:  0);
        return;
        label_10:
        NFMMOCExampleUI.<>c.<>9__23_14 = new UnityEngine.Events.UnityAction<JoinedPoolData>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_14(MMOCClientUser.JoinedPoolData info));
        if(this.mmocUser != null)
        {
            goto label_15;
        }
        
        goto label_15;
    }
    private void <Start>b__23_3()
    {
        var val_2 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_15) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.mmocUser.GetUserProfile(onGetUserProfileDone:  NFMMOCExampleUI.<>c.<>9__23_15);
        return;
        label_3:
        NFMMOCExampleUI.<>c.<>9__23_15 = new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_15(MMOCClientUser.MMOCUserProfile profile));
        if(this.mmocUser != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void <Start>b__23_4()
    {
        var val_3;
        if(((this.gameUser.<additionalRoomInfo>k__BackingField) == null) || ((this.gameUser.<additionalRoomInfo>k__BackingField.poolid) == 0))
        {
            goto label_5;
        }
        
        val_3 = null;
        val_3 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_16) == null)
        {
            goto label_10;
        }
        
        label_15:
        this.mmocUser.JoinPool(poolId:  this.gameUser.<additionalRoomInfo>k__BackingField.poolid, initGems:  5f, onJoinPoolDone:  NFMMOCExampleUI.<>c.<>9__23_16);
        return;
        label_5:
        DialogPanel val_1 = DialogManager.Show(title:  "error", message:  "No pool created for current room", cancelButtonTitle:  0, onCancelCallback:  0);
        return;
        label_10:
        NFMMOCExampleUI.<>c.<>9__23_16 = new UnityEngine.Events.UnityAction<JoinedPoolData>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_16(MMOCClientUser.JoinedPoolData info));
        if(this.mmocUser != null)
        {
            goto label_15;
        }
        
        goto label_15;
    }
    private void <Start>b__23_5()
    {
        var val_4 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_17) == null)
        {
            goto label_5;
        }
        
        label_10:
        this.gameUser.SignUp(username:  this.userName.text, password:  this.password.text, callback:  NFMMOCExampleUI.<>c.<>9__23_17);
        return;
        label_5:
        NFMMOCExampleUI.<>c.<>9__23_17 = new UnityEngine.Events.UnityAction<IResponse>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_17(IResponse result));
        if(this.gameUser != null)
        {
            goto label_10;
        }
        
        goto label_10;
    }
    private void <Start>b__23_6()
    {
        var val_4 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_18) == null)
        {
            goto label_5;
        }
        
        label_10:
        this.gameUser.GGPLogin(username:  this.userName.text, password:  this.password.text, callback:  NFMMOCExampleUI.<>c.<>9__23_18);
        return;
        label_5:
        NFMMOCExampleUI.<>c.<>9__23_18 = new UnityEngine.Events.UnityAction<LoginDataResponse>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_18(NFClientUser.LoginDataResponse result));
        if(this.gameUser != null)
        {
            goto label_10;
        }
        
        goto label_10;
    }
    private void <Start>b__23_7()
    {
        var val_2;
        val_2 = null;
        val_2 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_19) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.gameUser.CreateRoom(aNewBet:  new System.Decimal(), extraData:  0, callback:  NFMMOCExampleUI.<>c.<>9__23_19);
        return;
        label_3:
        NFMMOCExampleUI.<>c.<>9__23_19 = new UnityEngine.Events.UnityAction<NFResponsCreateRoom>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_19(NFClientUser.NFResponsCreateRoom result));
        if(this.gameUser != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void <Start>b__23_8()
    {
        var val_2 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_20) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.gameUser.ListRoom(callback:  NFMMOCExampleUI.<>c.<>9__23_20);
        return;
        label_3:
        NFMMOCExampleUI.<>c.<>9__23_20 = new UnityEngine.Events.UnityAction<System.Collections.Generic.List<Room>>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_20(System.Collections.Generic.List<NFClientUser.Room> result));
        if(this.gameUser != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void <Start>b__23_9()
    {
        var val_5;
        UnityEngine.Events.UnityAction<NFResponseRoom> val_7;
        if((this.gameUser.returnedRoomList != null) && (this.gameUser.returnedRoomList.Count != 0))
        {
                Room val_2 = this.gameUser.returnedRoomList.Item[0];
            val_5 = null;
            val_5 = null;
            val_7 = NFMMOCExampleUI.<>c.<>9__23_21;
            if(val_7 == null)
        {
                UnityEngine.Events.UnityAction<NFResponseRoom> val_3 = null;
            val_7 = val_3;
            val_3 = new UnityEngine.Events.UnityAction<NFResponseRoom>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_21(NFClientUser.NFResponseRoom result));
            NFMMOCExampleUI.<>c.<>9__23_21 = val_7;
        }
        
            this.gameUser.JoinRoom(matchID:  val_2.matchID, callback:  val_3);
            return;
        }
        
        DialogPanel val_4 = DialogManager.Show(title:  "No Game Found", message:  "Create a game or refresh game list and retry.", cancelButtonTitle:  0, onCancelCallback:  0);
    }
    private void <Start>b__23_11()
    {
        var val_2 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_22) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.gameUser.LeaveRoom(callback:  NFMMOCExampleUI.<>c.<>9__23_22);
        return;
        label_3:
        NFMMOCExampleUI.<>c.<>9__23_22 = new UnityEngine.Events.UnityAction<IResponse>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_22(IResponse result));
        if(this.gameUser != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void <Start>b__23_13()
    {
        var val_9;
        if((System.String.IsNullOrWhiteSpace(value:  this.serverIP.text)) != false)
        {
                DialogPanel val_3 = DialogManager.Show(title:  "Error", message:  "Must have a server IP", cancelButtonTitle:  0, onCancelCallback:  0);
            return;
        }
        
        if(this.gameUser == null)
        {
                DialogPanel val_4 = DialogManager.Show(title:  "Error", message:  "Game User Null", cancelButtonTitle:  0, onCancelCallback:  0);
        }
        
        .id = "Some server";
        .IP = this.serverIP.text;
        .RESTPort = 8080;
        .TCPPort = 15001;
        .display = true;
        .order = 0;
        .protocol = "http";
        .localization = new System.Collections.Generic.List<GameServerLocalization>();
        this.gameUser.<Server>k__BackingField = new GameServerInfo();
        val_9 = null;
        val_9 = null;
        if((NFMMOCExampleUI.<>c.<>9__23_23) == null)
        {
            goto label_9;
        }
        
        label_14:
        this.gameUser.LeaveRoom(callback:  NFMMOCExampleUI.<>c.<>9__23_23);
        return;
        label_9:
        NFMMOCExampleUI.<>c.<>9__23_23 = new UnityEngine.Events.UnityAction<IResponse>(object:  NFMMOCExampleUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFMMOCExampleUI.<>c::<Start>b__23_23(IResponse result));
        if(this.gameUser != null)
        {
            goto label_14;
        }
        
        goto label_14;
    }

}
