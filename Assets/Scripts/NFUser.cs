using UnityEngine;
public class NFUser
{
    // Fields
    public const string FACEBOOK_USER_PASSWORD = "ImFacebookUser";
    public const string GGP_USER_PASSWORD = "ImGGPUser";
    public NFUser.UserInfo loginUserInfo;
    private GameServerInfo _server;
    private NFClientUser _client;
    private string deviceSaveID;
    private static NFUser _curr;
    private static bool canShowMMOCError;
    
    // Properties
    public GameServerInfo Server { get; set; }
    public NFClientUser clientUser { get; }
    public MMOCClientUser mmocUser { get; }
    public static NFUser current { get; }
    public string lastUser { get; set; }
    
    // Methods
    public GameServerInfo get_Server()
    {
        GameServerInfo val_2 = this._server;
        if(val_2 != null)
        {
                return val_2;
        }
        
        GameServerInfo val_1 = null;
        val_2 = val_1;
        val_1 = new GameServerInfo();
        this._server = val_2;
        return val_2;
    }
    protected void set_Server(GameServerInfo value)
    {
        this._server = value;
        this.OnSwitchServer(aNewServer:  value);
    }
    private void OnSwitchServer(GameServerInfo aNewServer)
    {
        NFUser.Logout();
        NFClientUser val_1 = this.clientUser;
        val_1.<Server>k__BackingField = aNewServer;
    }
    public void SetupServer(string serverId)
    {
        GameServerInfo val_1 = GameServerManager.Get(serverId:  serverId);
        this._server = val_1;
        this.OnSwitchServer(aNewServer:  val_1);
        object[] val_2 = new object[1];
        GameServerInfo val_3 = this.Server;
        if(val_2 == null)
        {
            goto label_4;
        }
        
        if(val_3 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_2[0] = val_3;
        UnityEngine.Debug.LogFormat(format:  "Set Server to {0}", args:  val_2);
    }
    public void SetupServer(GameServerInfo serverInfo)
    {
        this._server = serverInfo;
        this.OnSwitchServer(aNewServer:  serverInfo);
        object[] val_1 = new object[1];
        GameServerInfo val_2 = this.Server;
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(val_2.id != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_2.id == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = val_2.id;
        UnityEngine.Debug.LogFormat(format:  "Set Server to {0}", args:  val_1);
    }
    public static void SaveToDevice(string userName, string aNewPassword, string jwt, string ggpJwt, string ggpJwtType, string refreshCode, string aNewServerId)
    {
        NFUser.UserLoginInfo val_1 = new NFUser.UserLoginInfo();
        if(val_1 != null)
        {
                .name = userName;
            .password = aNewPassword;
            .serverId = aNewServerId;
            .userJWT = jwt;
            .ggpJWT = ggpJwt;
            .ggpJwtType = ggpJwtType;
        }
        else
        {
                mem[16] = userName;
            mem[24] = aNewPassword;
            mem[32] = aNewServerId;
            mem[48] = jwt;
            mem[56] = ggpJwt;
            mem[64] = ggpJwtType;
        }
        
        .ggpRefreshCode = refreshCode;
        NFUser.current.lastUser = Newtonsoft.Json.JsonConvert.SerializeObject(value:  val_1);
    }
    public bool TryLoadFromDevice()
    {
        if(((((((Newtonsoft.Json.JsonConvert.DeserializeObject<UserLoginInfo>(value:  NFUser.current.lastUser)) != null) && ((System.String.IsNullOrWhiteSpace(value:  val_3.name)) != true)) && ((System.String.IsNullOrWhiteSpace(value:  val_3.password)) != true)) && ((System.String.IsNullOrWhiteSpace(value:  val_3.userJWT)) != true)) && ((System.String.IsNullOrWhiteSpace(value:  val_3.ggpJWT)) != true)) && ((System.String.IsNullOrWhiteSpace(value:  val_3.ggpJwtType)) != true))
        {
                if((System.String.IsNullOrWhiteSpace(value:  val_3.ggpRefreshCode)) != true)
        {
                if((System.String.IsNullOrWhiteSpace(value:  val_3.serverId)) == false)
        {
            goto label_13;
        }
        
        }
        
        }
        
        UnityEngine.Debug.Log(message:  "TryLoadFromDevice(): cache auth data null, returning false");
        return false;
        label_13:
        NFUser.current.SetupServer(serverId:  val_3.serverId);
        NFClientUser val_13 = NFUser.current.clientUser;
        val_13.<User>k__BackingField = val_3.name;
        val_13.<JWT_TOKEN>k__BackingField = val_3.userJWT;
        val_13.<refreshCode>k__BackingField = val_3.ggpRefreshCode;
        this.loginUserInfo._account = val_3.name;
        this.loginUserInfo.Save();
        this.loginUserInfo._password = val_3.password;
        this.loginUserInfo.Save();
        this.loginUserInfo._userJWT = val_3.userJWT;
        this.loginUserInfo.Save();
        this.loginUserInfo._ggpJWT = val_3.ggpJWT;
        this.loginUserInfo.Save();
        this.loginUserInfo._ggpJwtType = val_3.ggpJwtType;
        this.loginUserInfo.Save();
        this.loginUserInfo._refreshCode = val_3.ggpRefreshCode;
        this.loginUserInfo.Save();
        return false;
    }
    public NFClientUser get_clientUser()
    {
        NFClientUser val_3 = this._client;
        if(val_3 != null)
        {
                return val_3;
        }
        
        this._client = new NFClientUser();
        .<Server>k__BackingField = this.Server;
        val_3 = this._client;
        return val_3;
    }
    public MMOCClientUser get_mmocUser()
    {
        return MMOCUser.current;
    }
    public static NFUser get_current()
    {
        NFUser val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(NFUser._curr == null)
        {
                val_4 = null;
            val_4 = null;
            NFUser._curr = new NFUser();
            val_3 = null;
            val_2 = NFUser._curr;
            if(val_2 == null)
        {
                val_3 = null;
        }
        
            mem[1152921528616538360] = "lastUser";
        }
        
        val_3 = null;
        return (NFUser)NFUser._curr;
    }
    public string get_lastUser()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  this.deviceSaveID, defaultValue:  "");
        if((System.String.op_Inequality(a:  val_1, b:  "")) == false)
        {
                return val_1;
        }
        
        return CMS.Security.Cryptography.AES.Decrypt(inputBase64:  val_1, passphrase:  "CMS.Device.uniqueDeviceId");
    }
    public void set_lastUser(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  this.deviceSaveID, value:  CMS.Security.Cryptography.AES.Encrypt(input:  value, passphrase:  "CMS.Device.uniqueDeviceId"));
        UnityEngine.PlayerPrefs.Save();
    }
    public void CreateAccount(string userNameTxt, string passwordTxt, System.Action OnRegisterDone)
    {
        .OnRegisterDone = OnRegisterDone;
        this.clientUser.SignUp(username:  userNameTxt, password:  passwordTxt, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  new NFUser.<>c__DisplayClass26_0(), method:  System.Void NFUser.<>c__DisplayClass26_0::<CreateAccount>b__0(IResponse registerResponse)));
    }
    public void LoginNFServer(string userNameTxt, string passwordTxt, bool createAccountIfUserNotExist, System.Action OnLoginStepDone, System.Action OnNFLoginSuccess, System.Action<NFClientUser.LoginDataResponse> OnNFLoginFail)
    {
        string val_7;
        string val_8;
        var val_9;
        NFUser.<>c__DisplayClass27_0 val_1 = new NFUser.<>c__DisplayClass27_0();
        if(val_1 != null)
        {
                val_7 = val_1;
            .passwordTxt = passwordTxt;
            mem[1152921528617139936] = OnLoginStepDone;
            mem[1152921528617139944] = OnNFLoginSuccess;
            mem[1152921528617139952] = createAccountIfUserNotExist;
            mem[1152921528617139960] = this;
            mem[1152921528617139968] = userNameTxt;
            mem[1152921528617139984] = OnNFLoginFail;
            val_8 = mem[1152921528617139968];
            val_9 = this.clientUser;
        }
        else
        {
                mem[16] = OnLoginStepDone;
            mem[24] = OnNFLoginSuccess;
            mem[32] = createAccountIfUserNotExist;
            mem[40] = this;
            mem[48] = userNameTxt;
            val_7 = 56;
            mem[56] = passwordTxt;
            mem[64] = OnNFLoginFail;
            val_9 = this.clientUser;
            val_8 = mem[48];
        }
        
        val_9.GGPLogin(username:  val_8, password:  val_7, callback:  new UnityEngine.Events.UnityAction<LoginDataResponse>(object:  val_1, method:  System.Void NFUser.<>c__DisplayClass27_0::<LoginNFServer>b__0(NFClientUser.LoginDataResponse loginResponse)));
    }
    public static void UpdateServerTime()
    {
        var val_2;
        System.Action val_4;
        val_2 = null;
        val_2 = null;
        val_4 = NFUser.<>c.<>9__28_0;
        if(val_4 == null)
        {
                System.Action val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action(object:  NFUser.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NFUser.<>c::<UpdateServerTime>b__28_0());
            NFUser.<>c.<>9__28_0 = val_4;
        }
        
        MainThreadDispatcher.Invoke(action:  val_1, delay:  0f);
    }
    public static void Logout()
    {
        if(NFUser.current.clientUser.IsLoggedIn != false)
        {
                NFUser.current.clientUser.LeaveRoom(callback:  0);
            NFUser.current.clientUser.StopSocketIo();
            NFClientUser val_9 = NFUser.current.clientUser;
            val_9.<JWT_TOKEN>k__BackingField = 0;
            val_9.<refreshCode>k__BackingField = 0;
            val_9.<User>k__BackingField = 0;
        }
        
        NFUser val_10 = NFUser.current;
        val_10.loginUserInfo.Clear();
        MMOCUser.Logout();
        IWServerDB_Cache.EnableSaveRoutine(enable:  false);
        VIP.DeInit();
    }
    public void CheckMMOCGemsChangedAfterDelay(float delayInSeconds, int diffDir)
    {
        var val_3;
        NFUser.<>c__DisplayClass30_0 val_1 = new NFUser.<>c__DisplayClass30_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .diffDir = diffDir;
        val_3 = null;
        val_3 = null;
        if(Character_GlobalInfo.isCryptoMMOCMode == false)
        {
                return;
        }
        
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  val_1, method:  System.Void NFUser.<>c__DisplayClass30_0::<CheckMMOCGemsChangedAfterDelay>b__0()), delay:  delayInSeconds);
    }
    public static void QuitGameToLobbyAndShowError()
    {
        object[] val_1 = new object[2];
        val_1[0] = "<color=#EED58EFF>";
        val_1[1] = "</color>";
        NFUser.QuitGameToLobbyAndShowError(errorMessage:  LanguageManager.GetTextFormat(key:  "LK.ErrorContactMsg", list:  val_1));
    }
    public static void QuitGameToLobbyAndShowError(string errorMessage)
    {
        var val_3;
        .errorMessage = errorMessage;
        val_3 = null;
        val_3 = null;
        if(NFUser.canShowMMOCError == false)
        {
                return;
        }
        
        NFUser.canShowMMOCError = false;
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  new NFUser.<>c__DisplayClass33_0(), method:  System.Void NFUser.<>c__DisplayClass33_0::<QuitGameToLobbyAndShowError>b__0()), delay:  3f);
    }
    public NFUser()
    {
        this.loginUserInfo = new NFUser.UserInfo();
        this.deviceSaveID = "";
    }
    private static NFUser()
    {
        NFUser.canShowMMOCError = true;
    }

}
