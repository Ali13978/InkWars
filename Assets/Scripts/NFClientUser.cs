using UnityEngine;
public class NFClientUser
{
    // Fields
    private GameServerInfo <Server>k__BackingField;
    private string <User>k__BackingField;
    private string <JWT_TOKEN>k__BackingField;
    private string <refreshCode>k__BackingField;
    private UnityEngine.Events.UnityAction<IResponse> _signUpCallback;
    private NFClientUser.RegisterDataResponse _signUpResult;
    private NFClientUser.NFResponsCreateRoom <currentRoom>k__BackingField;
    private NFClientUser.NFResponseAdditionalRoomInfo <additionalRoomInfo>k__BackingField;
    internal System.Collections.Generic.List<NFClientUser.Room> returnedRoomList;
    private static string REGION;
    private static BestHTTP.SocketIO.SocketManager _socketIoManager;
    public readonly NFClientUser.MessageReceiveEvent OnMsgReceivedEvent;
    public readonly NFClientUser.MessageReceiveEvent OnStartMsgReceivedEvent;
    public readonly NFClientUser.MessageReceiveEvent OnFinishReceiveEvent;
    public readonly NFClientUser.MessageReceiveEvent OnDisconnectingReceiveEvent;
    
    // Properties
    public GameServerInfo Server { get; set; }
    public string User { get; set; }
    public string JWT_TOKEN { get; set; }
    public string refreshCode { get; set; }
    public bool IsLoggedIn { get; }
    public string lastUser { get; set; }
    public NFClientUser.NFResponsCreateRoom currentRoom { get; set; }
    public NFClientUser.NFResponseAdditionalRoomInfo additionalRoomInfo { get; set; }
    public BestHTTP.SocketIO.SocketManager SocketIoManager { get; }
    public bool IsTcpConnecting { get; }
    public bool IsTcpConnected { get; }
    
    // Methods
    public void loadData(UnityEngine.Events.UnityAction<IResponse> callback)
    {
        NFClientUser.<>c__DisplayClass3_0 val_1 = new NFClientUser.<>c__DisplayClass3_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .callback = callback;
        HttpNetworkingExecutor.Instance.Get(apiUrl:  "user/data", authUser:  this, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFClientUser.<>c__DisplayClass3_0::<loadData>b__0(IResponse response)), buildUrl:  true);
    }
    public void GetLeaderBoardData(DataStructs.LeaderboardType type, int maxScore, UnityEngine.Events.UnityAction<IResponse> callback)
    {
        object val_11;
        UnityEngine.RectTransform val_12;
        var val_13;
        object val_14;
        .callback = X4;
        object[] val_2 = new object[4];
        if(maxScore != 999999)
        {
            goto label_2;
        }
        
        val_11 = "all";
        if(val_2 != null)
        {
            goto label_7;
        }
        
        goto label_4;
        label_2:
        val_11 = maxScore.ToString();
        maxScore.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  maxScore, drivenProperties:  callback);
        if(val_2 != null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        if((val_11 != null) && (val_11 == null))
        {
                val_12 = 0;
        }
        
        if(val_2.Length == 0)
        {
                val_12 = 0;
        }
        
        val_2[0] = val_11;
        if(268435461 == 0)
        {
            goto label_11;
        }
        
        val_13 = null;
        val_13 = null;
        DataStructs.Flag val_4 = DataStructs.UserDataDictionary.Settings.UserFlag;
        val_14 = val_4.ToString();
        val_4.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_12, drivenProperties:  callback);
        if(val_14 != null)
        {
            goto label_17;
        }
        
        goto label_20;
        label_11:
        val_14 = "world";
        label_17:
        label_20:
        val_2[1] = val_14;
        val_2[2] = "bp";
        val_2[3] = callback;
        HttpNetworkingExecutor.Instance.Get(apiUrl:  System.String.Format(format:  "leaderboard/list?character={0}&country={1}&scoreType={2}&offset={3}", args:  val_2), authUser:  NFUser.current.clientUser, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new NFClientUser.<>c__DisplayClass4_0(), method:  System.Void NFClientUser.<>c__DisplayClass4_0::<GetLeaderBoardData>b__0(IResponse response)), buildUrl:  true);
    }
    public void updateData(object data, UnityEngine.Events.UnityAction<IResponse> callback)
    {
        object val_4;
        NFClientUser.<>c__DisplayClass5_0 val_1 = new NFClientUser.<>c__DisplayClass5_0();
        if(val_1 != null)
        {
                val_4 = val_1;
            .data = data;
            mem[1152921528591361728] = this;
        }
        else
        {
                mem[16] = this;
            val_4 = 24;
            mem[24] = data;
        }
        
        .callback = callback;
        HttpNetworkingExecutor.Instance.Post(apiUrl:  "user/update", authUser:  this, data:  val_4, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFClientUser.<>c__DisplayClass5_0::<updateData>b__0(IResponse response)), buildUrl:  true);
    }
    public GameServerInfo get_Server()
    {
        return (GameServerInfo)this.<Server>k__BackingField;
    }
    public void set_Server(GameServerInfo value)
    {
        this.<Server>k__BackingField = value;
    }
    public string get_User()
    {
        return (string)this.<User>k__BackingField;
    }
    private void set_User(string value)
    {
        this.<User>k__BackingField = value;
    }
    public string get_JWT_TOKEN()
    {
        return (string)this.<JWT_TOKEN>k__BackingField;
    }
    private void set_JWT_TOKEN(string value)
    {
        this.<JWT_TOKEN>k__BackingField = value;
    }
    public string get_refreshCode()
    {
        return (string)this.<refreshCode>k__BackingField;
    }
    private void set_refreshCode(string value)
    {
        this.<refreshCode>k__BackingField = value;
    }
    public bool get_IsLoggedIn()
    {
        GameServerInfo val_4 = this.<Server>k__BackingField;
        if(val_4 != null)
        {
                if((System.String.IsNullOrWhiteSpace(value:  this.<User>k__BackingField)) != false)
        {
                val_4 = 0;
        }
        else
        {
                bool val_2 = System.String.IsNullOrWhiteSpace(value:  this.<JWT_TOKEN>k__BackingField);
            val_4 = val_2 ^ 1;
        }
        
        }
        
        val_2 = val_4;
        return (bool)val_2;
    }
    public void Logout()
    {
        this.<JWT_TOKEN>k__BackingField = 0;
        this.<refreshCode>k__BackingField = 0;
        this.<User>k__BackingField = 0;
    }
    public void SetUser(string userAcc, string userJwt, string userRefreshCode)
    {
        this.<User>k__BackingField = userAcc;
        this.<JWT_TOKEN>k__BackingField = userJwt;
        this.<refreshCode>k__BackingField = userRefreshCode;
    }
    public void GetProductList(UnityEngine.Events.UnityAction<BestHTTP.HTTPRequest, BestHTTP.HTTPResponse> callback)
    {
        .callback = callback;
        BestHTTP.HTTPRequest val_5 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  "https://snationapi.mmocircles.com/Products?app_id=197&range=100"), methodType:  0, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  new NFClientUser.<>c__DisplayClass26_0(), method:  System.Void NFClientUser.<>c__DisplayClass26_0::<GetProductList>b__0(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse res))).Send();
    }
    public System.Threading.Tasks.Task<IResponse> PurchaseAsyncProduct(string id, int amount)
    {
        System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> val_1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder<IResponse>.Create();
        return (System.Threading.Tasks.Task<IResponse>);
    }
    public void PurchaseProduct(string id, int amount, UnityEngine.Events.UnityAction<BestHTTP.HTTPRequest, BestHTTP.HTTPResponse> callback)
    {
        BestHTTP.OnRequestFinishedDelegate val_13;
        .callback = callback;
        BestHTTP.OnRequestFinishedDelegate val_7 = null;
        val_13 = val_7;
        val_7 = new BestHTTP.OnRequestFinishedDelegate(object:  new NFClientUser.<>c__DisplayClass28_0(), method:  System.Void NFClientUser.<>c__DisplayClass28_0::<PurchaseProduct>b__0(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse res));
        BestHTTP.HTTPRequest val_8 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  System.String.Format(format:  "https://snationapi.mmocircles.com/Products/{0}/purchase", arg0:  id)), methodType:  2, callback:  val_7);
        if(("{" + System.String.Format(format:  "\"quantity\": {0}", arg0:  amount.ToString())(System.String.Format(format:  "\"quantity\": {0}", arg0:  amount.ToString())) + "}") != null)
        {
                val_13 = System.Text.Encoding.UTF8;
            val_8.RawData = val_13;
        }
        
        val_8.AddHeader(name:  "Content-Type", value:  "application/json");
        string val_11 = MMOCUser.current.apiAuthToken;
        if(val_8 != null)
        {
                val_8.AddHeader(name:  "Authorization", value:  val_11);
        }
        else
        {
                val_8.AddHeader(name:  "Authorization", value:  val_11);
        }
        
        BestHTTP.HTTPRequest val_12 = val_8.Send();
    }
    public void GGPLogin(string username, string password, UnityEngine.Events.UnityAction<NFClientUser.LoginDataResponse> callback)
    {
        string val_5;
        NFClientUser.<>c__DisplayClass29_0 val_1 = new NFClientUser.<>c__DisplayClass29_0();
        if(val_1 != null)
        {
                val_5 = val_1;
            .username = username;
            mem[1152921528593388432] = this;
        }
        else
        {
                mem[16] = this;
            val_5 = 24;
            mem[24] = username;
        }
        
        .callback = callback;
        NFClientUser.LoginDataRequest val_2 = new NFClientUser.LoginDataRequest();
        if(val_2 != null)
        {
                .username = val_5;
        }
        else
        {
                mem[16] = val_5;
        }
        
        .password = password;
        HttpNetworkingExecutor.Instance.Post(apiUrl:  "login", authUser:  0, data:  val_2, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFClientUser.<>c__DisplayClass29_0::<GGPLogin>b__0(IResponse response)), buildUrl:  true);
    }
    public void SignUp(string username, string password, UnityEngine.Events.UnityAction<IResponse> callback)
    {
        NFClientUser.<>c__DisplayClass32_0 val_1 = new NFClientUser.<>c__DisplayClass32_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .username = username;
        this._signUpCallback = callback;
        NFClientUser.RegisterDataRequest val_2 = new NFClientUser.RegisterDataRequest();
        if(val_2 != null)
        {
                .username = (NFClientUser.<>c__DisplayClass32_0)[1152921528593571168].username;
        }
        else
        {
                mem[16] = (NFClientUser.<>c__DisplayClass32_0)[1152921528593571168].username;
        }
        
        .password = password;
        .mmocUserID = MMOCUser.current.id.ToString();
        HttpNetworkingExecutor.Instance.Post(apiUrl:  "register", authUser:  0, data:  val_2, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFClientUser.<>c__DisplayClass32_0::<SignUp>b__0(IResponse response)), buildUrl:  true);
    }
    private void HandleSignUpInitialSave()
    {
        var val_2;
        this._signUpCallback.Invoke(arg0:  this._signUpResult);
        this._signUpCallback = 0;
        this._signUpResult = 0;
        val_2 = null;
        val_2 = null;
        IWServerDB_Cache.OnHasSavedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NFClientUser::HandleSignUpInitialSave()));
    }
    public void IWRefresh(UnityEngine.Events.UnityAction<NFClientUser.RefreshDataResponse> callback)
    {
        NFClientUser.<>c__DisplayClass34_0 val_1 = new NFClientUser.<>c__DisplayClass34_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .callback = callback;
        HttpNetworkingExecutor.Instance.Get(apiUrl:  "refresh", authUser:  this, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFClientUser.<>c__DisplayClass34_0::<IWRefresh>b__0(IResponse response)), buildUrl:  true);
    }
    public void GetRankData(int start, int size, UnityEngine.Events.UnityAction<NFClientUser.NFResponseRankData> callback)
    {
        .callback = callback;
        if(new NFClientUser.NFRequestRankData() != null)
        {
                .start = start;
        }
        else
        {
                mem[16] = start;
        }
        
        .size = size;
        HttpNetworkingExecutor.Instance.Get(apiUrl:  "rank", authUser:  this, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new NFClientUser.<>c__DisplayClass38_0(), method:  System.Void NFClientUser.<>c__DisplayClass38_0::<GetRankData>b__0(IResponse response)), buildUrl:  true);
    }
    public void SaveRankData(int score, string data, UnityEngine.Events.UnityAction<IResponse> callback)
    {
        .callback = callback;
        if((score == 0) || ((System.String.IsNullOrEmpty(value:  data)) == true))
        {
            goto label_3;
        }
        
        NFClientUser.NFRequestSaveRankData val_3 = new NFClientUser.NFRequestSaveRankData();
        if(val_3 == null)
        {
            goto label_4;
        }
        
        .score = score;
        goto label_5;
        label_3:
        UnityEngine.Debug.LogError(message:  "Invalid rank data");
        if(((NFClientUser.<>c__DisplayClass39_0)[1152921528594196512].callback) == null)
        {
                return;
        }
        
        NFClientUser.NFResponseRoom val_4 = new NFClientUser.NFResponseRoom();
        if(val_4 == null)
        {
            goto label_9;
        }
        
        mem[1152921528594208824] = 0;
        goto label_10;
        label_4:
        mem[16] = score;
        label_5:
        .data = data;
        HttpNetworkingExecutor.Instance.Post(apiUrl:  "rank", authUser:  this, data:  val_3, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new NFClientUser.<>c__DisplayClass39_0(), method:  System.Void NFClientUser.<>c__DisplayClass39_0::<SaveRankData>b__0(IResponse response)), buildUrl:  true);
        return;
        label_9:
        mem[24] = 0;
        label_10:
        mem[1152921528594208816] = "Invalid rank data";
        (NFClientUser.<>c__DisplayClass39_0)[1152921528594196512].callback.Invoke(arg0:  val_4);
    }
    public void Login(string username, string password, UnityEngine.Events.UnityAction<NFClientUser.LoginDataResponse> callback)
    {
        string val_5;
        NFClientUser.<>c__DisplayClass45_0 val_1 = new NFClientUser.<>c__DisplayClass45_0();
        if(val_1 != null)
        {
                val_5 = val_1;
            .username = username;
            mem[1152921528594379184] = this;
        }
        else
        {
                mem[16] = this;
            val_5 = 24;
            mem[24] = username;
        }
        
        .callback = callback;
        NFClientUser.LoginDataRequest val_2 = new NFClientUser.LoginDataRequest();
        if(val_2 != null)
        {
                .username = val_5;
        }
        else
        {
                mem[16] = val_5;
        }
        
        .password = password;
        HttpNetworkingExecutor.Instance.Post(apiUrl:  "login", authUser:  0, data:  val_2, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFClientUser.<>c__DisplayClass45_0::<Login>b__0(IResponse response)), buildUrl:  true);
    }
    public void Refresh(UnityEngine.Events.UnityAction<IResponse> callback)
    {
        .callback = callback;
        HttpNetworkingExecutor.Instance.Get(apiUrl:  "refresh", authUser:  this, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new NFClientUser.<>c__DisplayClass46_0(), method:  System.Void NFClientUser.<>c__DisplayClass46_0::<Refresh>b__0(IResponse response)), buildUrl:  true);
    }
    public void CreateAccount(string user, string password, UnityEngine.Events.UnityAction<IResponse> callback)
    {
        .callback = callback;
        NFClientUser.LoginDataRequest val_2 = new NFClientUser.LoginDataRequest();
        if(val_2 != null)
        {
                .username = user;
        }
        else
        {
                mem[16] = user;
        }
        
        .password = password;
        HttpNetworkingExecutor.Instance.Post(apiUrl:  "register", authUser:  0, data:  val_2, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new NFClientUser.<>c__DisplayClass47_0(), method:  System.Void NFClientUser.<>c__DisplayClass47_0::<CreateAccount>b__0(IResponse response)), buildUrl:  true);
    }
    public string get_lastUser()
    {
        return CMS.Security.Cryptography.AES.Decrypt(inputBase64:  UnityEngine.PlayerPrefs.GetString(key:  "lastUser", defaultValue:  ""), passphrase:  "CMS.Device.uniqueDeviceId");
    }
    public void set_lastUser(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  "lastUser", value:  CMS.Security.Cryptography.AES.Encrypt(input:  value, passphrase:  "CMS.Device.uniqueDeviceId"));
        UnityEngine.PlayerPrefs.Save();
    }
    public NFClientUser.NFResponsCreateRoom get_currentRoom()
    {
        return (NFResponsCreateRoom)this.<currentRoom>k__BackingField;
    }
    private void set_currentRoom(NFClientUser.NFResponsCreateRoom value)
    {
        this.<currentRoom>k__BackingField = value;
    }
    public NFClientUser.NFResponseAdditionalRoomInfo get_additionalRoomInfo()
    {
        return (NFResponseAdditionalRoomInfo)this.<additionalRoomInfo>k__BackingField;
    }
    private void set_additionalRoomInfo(NFClientUser.NFResponseAdditionalRoomInfo value)
    {
        this.<additionalRoomInfo>k__BackingField = value;
    }
    public void CreateRoom(decimal aNewBet, NFClientUser.RoomExtraData extraData, UnityEngine.Events.UnityAction<NFClientUser.NFResponsCreateRoom> callback)
    {
        var val_5;
        NFClientUser.<>c__DisplayClass70_0 val_1 = new NFClientUser.<>c__DisplayClass70_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .callback = callback;
        val_5 = null;
        val_5 = null;
        HttpNetworkingExecutor.Instance.Post(apiUrl:  System.String.Format(format:  "user/createroom?wager={0}&region={1}", arg0:  aNewBet, arg1:  NFClientUser.REGION), authUser:  this, data:  extraData, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFClientUser.<>c__DisplayClass70_0::<CreateRoom>b__0(IResponse response)), buildUrl:  true);
    }
    public void LeaveRoom(UnityEngine.Events.UnityAction<IResponse> callback)
    {
        NFClientUser.<>c__DisplayClass71_0 val_1 = new NFClientUser.<>c__DisplayClass71_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .callback = callback;
        HttpNetworkingExecutor.Instance.Post(apiUrl:  "user/leave", authUser:  this, data:  0, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFClientUser.<>c__DisplayClass71_0::<LeaveRoom>b__0(IResponse response)), buildUrl:  true);
    }
    public void ListRoom(UnityEngine.Events.UnityAction<System.Collections.Generic.List<NFClientUser.Room>> callback)
    {
        var val_5;
        NFClientUser.<>c__DisplayClass72_0 val_1 = new NFClientUser.<>c__DisplayClass72_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .callback = callback;
        this.returnedRoomList = 0;
        val_5 = null;
        val_5 = null;
        HttpNetworkingExecutor.Instance.Get(apiUrl:  System.String.Format(format:  "user/rooms?region={0}", arg0:  NFClientUser.REGION), authUser:  this, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFClientUser.<>c__DisplayClass72_0::<ListRoom>b__0(IResponse response)), buildUrl:  true);
    }
    public void JoinRoom(string matchID, UnityEngine.Events.UnityAction<NFClientUser.NFResponseRoom> callback)
    {
        .callback = callback;
        HttpNetworkingExecutor.Instance.Post(apiUrl:  System.String.Format(format:  "user/join?matchID={0}", arg0:  matchID), authUser:  this, data:  0, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new NFClientUser.<>c__DisplayClass73_0(), method:  System.Void NFClientUser.<>c__DisplayClass73_0::<JoinRoom>b__0(IResponse response)), buildUrl:  true);
    }
    public void RoomStatus(UnityEngine.Events.UnityAction<NFClientUser.NFResponseRoom> callback)
    {
        .callback = callback;
        HttpNetworkingExecutor.Instance.Get(apiUrl:  "user/roomstatus", authUser:  this, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new NFClientUser.<>c__DisplayClass74_0(), method:  System.Void NFClientUser.<>c__DisplayClass74_0::<RoomStatus>b__0(IResponse response)), buildUrl:  true);
    }
    public void GetServerTime(UnityEngine.Events.UnityAction<string> callback)
    {
        .callback = callback;
        HttpNetworkingExecutor.Instance.Get(apiUrl:  "time", authUser:  0, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new NFClientUser.<>c__DisplayClass75_0(), method:  System.Void NFClientUser.<>c__DisplayClass75_0::<GetServerTime>b__0(IResponse response)), buildUrl:  true);
    }
    public BestHTTP.SocketIO.SocketManager get_SocketIoManager()
    {
        var val_1 = null;
        if(NFClientUser._socketIoManager == null)
        {
                this.StartSocketIo();
            val_1 = null;
        }
        
        val_1 = null;
        return (BestHTTP.SocketIO.SocketManager)NFClientUser._socketIoManager;
    }
    public bool get_IsTcpConnecting()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = this;
        val_7 = null;
        val_7 = null;
        if(NFClientUser._socketIoManager != null)
        {
                if(this.SocketIoManager.State == 1)
        {
                return (bool)val_8;
        }
        
            val_6 = this.SocketIoManager;
            var val_5 = (val_6.State == 4) ? 1 : 0;
            return (bool)val_8;
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    public bool get_IsTcpConnected()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = this;
        val_5 = null;
        val_5 = null;
        if(NFClientUser._socketIoManager != null)
        {
                val_4 = this.SocketIoManager;
            var val_3 = (val_4.State == 2) ? 1 : 0;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    public void StartSocketIo()
    {
        var val_11;
        if(this.IsTcpConnecting != true)
        {
                if(this.IsTcpConnected == false)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Debug.LogWarning(message:  "rouge call trying to InitSocketIO when already connecting || connected");
        label_2:
        BestHTTP.SocketIO.SocketOptions val_3 = new BestHTTP.SocketIO.SocketOptions();
        val_3.QueryParamsOnlyForHandshake = true;
        PlatformSupport.Collections.ObjectModel.ObservableDictionary<System.String, System.String> val_4 = new PlatformSupport.Collections.ObjectModel.ObservableDictionary<System.String, System.String>();
        if(val_3 != null)
        {
                val_3.AdditionalQueryParams = val_4;
        }
        else
        {
                val_3.AdditionalQueryParams = val_4;
        }
        
        val_3.AdditionalQueryParams.Add(key:  "jwt", value:  this.<JWT_TOKEN>k__BackingField);
        object[] val_6 = new object[2];
        val_6[0] = this.<Server>k__BackingField.IP;
        val_6[1] = this.<Server>k__BackingField.TCPPort;
        UnityEngine.Debug.LogFormat(format:  "Built SocketIO {0} {1}", args:  val_6);
        BestHTTP.SocketIO.SocketManager val_10 = new BestHTTP.SocketIO.SocketManager(uri:  new System.Uri(uriString:  this.<Server>k__BackingField.RestUrl(this.<Server>k__BackingField.RestUrl) + "/socket.io/"("/socket.io/")), options:  val_3);
        val_11 = null;
        val_11 = null;
        NFClientUser._socketIoManager = val_10;
        this.AttachEventsToHandlers(socketManager:  val_10);
    }
    public void SendSocketMessage(string msg)
    {
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_2;
        }
        
        if(msg != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(msg == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_3[0] = msg;
        BestHTTP.SocketIO.Socket val_4 = this.SocketIoManager.Socket.Emit(eventName:  "sendToAll", args:  val_3);
    }
    public void SendMatchResultILost()
    {
        BestHTTP.SocketIO.Socket val_4 = this.SocketIoManager.Socket.Emit(eventName:  "lost", args:  System.Array.Empty<System.Object>());
    }
    public void SendMatchResultDraw()
    {
        BestHTTP.SocketIO.Socket val_4 = this.SocketIoManager.Socket.Emit(eventName:  "draw", args:  System.Array.Empty<System.Object>());
    }
    private void AttachEventsToHandlers(BestHTTP.SocketIO.SocketManager socketManager)
    {
        socketManager.Socket.On(eventName:  "message", callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void NFClientUser::HandleMessageReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)));
        socketManager.Socket.On(eventName:  "start", callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void NFClientUser::HandleStartReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)));
        socketManager.Socket.On(eventName:  "finish", callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void NFClientUser::HandleFinishReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)));
        socketManager.Socket.On(eventName:  "disconnecting", callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void NFClientUser::HandleDisconnectingReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)));
    }
    private void HandleDisconnectingReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)
    {
        string val_2;
        object val_2 = args[0];
        if(this.OnDisconnectingReceiveEvent == null)
        {
            goto label_3;
        }
        
        if(val_2 == null)
        {
            goto label_4;
        }
        
        label_6:
        var val_1 = (null == static_value_032D1378) ? (val_2) : 0;
        goto label_5;
        label_3:
        if(val_2 != null)
        {
            goto label_6;
        }
        
        label_4:
        val_2 = 0;
        label_5:
        this.OnDisconnectingReceiveEvent.Invoke(arg0:  val_2);
    }
    private void HandleStartReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)
    {
        UnityEngine.Debug.Log(message:  "SocketIo Start Event");
        this.OnStartMsgReceivedEvent.Invoke(arg0:  0);
    }
    private void HandleMessageReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)
    {
        string val_2;
        object val_2 = args[0];
        if(this.OnMsgReceivedEvent == null)
        {
            goto label_3;
        }
        
        if(val_2 == null)
        {
            goto label_4;
        }
        
        label_6:
        var val_1 = (null == static_value_032D1378) ? (val_2) : 0;
        goto label_5;
        label_3:
        if(val_2 != null)
        {
            goto label_6;
        }
        
        label_4:
        val_2 = 0;
        label_5:
        this.OnMsgReceivedEvent.Invoke(arg0:  val_2);
    }
    private void HandleFinishReceived(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)
    {
        string val_5;
        FinishReason val_2 = 5;
        object val_5 = args[0];
        if(val_5 != null)
        {
                var val_1 = (null == static_value_032D1378) ? (val_5) : 0;
        }
        else
        {
                val_5 = 0;
        }
        
        bool val_3 = System.Enum.TryParse<FinishReason>(value:  val_5, ignoreCase:  true, result: out  val_2);
        val_2.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_2, drivenProperties:  public static System.Boolean System.Enum::TryParse<FinishReason>(string value, bool ignoreCase, out FinishReason result));
        this.OnFinishReceiveEvent.Invoke(arg0:  val_2.ToString());
    }
    public void StopSocketIo()
    {
        null = null;
        if(NFClientUser._socketIoManager == null)
        {
                return;
        }
        
        if(this.SocketIoManager.State == 5)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Stop Socket");
        this.SocketIoManager.Close();
    }
    public NFClientUser()
    {
        this.OnMsgReceivedEvent = new NFClientUser.MessageReceiveEvent();
        this.OnStartMsgReceivedEvent = new NFClientUser.MessageReceiveEvent();
        this.OnFinishReceiveEvent = new NFClientUser.MessageReceiveEvent();
        this.OnDisconnectingReceiveEvent = new NFClientUser.MessageReceiveEvent();
    }
    private static NFClientUser()
    {
        NFClientUser.REGION = "ASIA";
    }

}
