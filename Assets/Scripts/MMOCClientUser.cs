using UnityEngine;
public class MMOCClientUser
{
    // Fields
    public static string CLIENT_ID;
    public static string REDIRECT_URI;
    public static string SHOP_URL;
    public static string API_JOIN_POOL_FORMAT;
    public static string API_ADD_GEM_FORMAT;
    public static string API_AUTH_TOKEN;
    public static string API_AUTH_TOKEN_REFRESH_DATA_FORMAT;
    public static string API_AUTH_TOKEN_DATA_FORMAT;
    public static string API_BASIC_INFO;
    private readonly MMOCClientUser.MMOCOnEvents <OnEvents>k__BackingField;
    private decimal <originGemsBeforeJoinPool>k__BackingField;
    private decimal <wagedGems>k__BackingField;
    private string _token;
    private MMOCClientUser.MMOCLoginResponseData authResult;
    private string _authCode;
    private string _tokenType;
    private MMOCClientUser.MMOCUserProfile _profile;
    public MMOCClientUser.JoinedPoolData poolData;
    
    // Properties
    public MMOCClientUser.MMOCOnEvents OnEvents { get; }
    public decimal originGemsBeforeJoinPool { get; set; }
    public decimal wagedGems { get; set; }
    public string accessToken { get; set; }
    public string authCode { get; set; }
    public string tokenType { get; set; }
    public int id { get; }
    public string apiAuthToken { get; }
    public static string LOGIN_URL { get; }
    public static string CODE_URL { get; }
    public MMOCClientUser.MMOCUserProfile userProfile { get; set; }
    
    // Methods
    public MMOCClientUser.MMOCOnEvents get_OnEvents()
    {
        return (MMOCOnEvents)this.<OnEvents>k__BackingField;
    }
    public decimal get_originGemsBeforeJoinPool()
    {
        return new System.Decimal() {flags = this.<originGemsBeforeJoinPool>k__BackingField, hi = this.<originGemsBeforeJoinPool>k__BackingField};
    }
    private void set_originGemsBeforeJoinPool(decimal value)
    {
        this.<originGemsBeforeJoinPool>k__BackingField = value;
        mem[1152921528576061408] = value.lo;
        mem[1152921528576061412] = value.mid;
    }
    public decimal get_wagedGems()
    {
        return new System.Decimal() {flags = this.<wagedGems>k__BackingField, hi = this.<wagedGems>k__BackingField};
    }
    private void set_wagedGems(decimal value)
    {
        this.<wagedGems>k__BackingField = value;
        mem[1152921528576285424] = value.lo;
        mem[1152921528576285428] = value.mid;
    }
    public string get_accessToken()
    {
        if(this._token != null)
        {
                return val_2;
        }
        
        NFUser val_1 = NFUser.current;
        string val_2 = val_1.loginUserInfo.ggpJWT;
        this._token = val_2;
        return val_2;
    }
    private void set_accessToken(string value)
    {
        this._token = value;
        NFUser val_1 = NFUser.current;
        val_1.loginUserInfo.ggpJWT = this._token;
        this.<OnEvents>k__BackingField.Invoke(arg0:  0);
    }
    public string get_authCode()
    {
        return (string)this._authCode;
    }
    private void set_authCode(string value)
    {
        this._authCode = value;
        this.<OnEvents>k__BackingField.Invoke(arg0:  2);
    }
    public string get_tokenType()
    {
        if(this._tokenType != null)
        {
                return val_2;
        }
        
        NFUser val_1 = NFUser.current;
        string val_2 = val_1.loginUserInfo.ggpJwtType;
        this._tokenType = val_2;
        return val_2;
    }
    private void set_tokenType(string value)
    {
        this._tokenType = value;
        NFUser val_1 = NFUser.current;
        val_1.loginUserInfo.ggpJwtType = this._tokenType;
    }
    public int get_id()
    {
        if(this._profile == null)
        {
                return 0;
        }
        
        return (int)this._profile.id;
    }
    public string get_apiAuthToken()
    {
        return System.String.Format(format:  "{0} {1}", arg0:  this.tokenType, arg1:  this.accessToken);
    }
    public static string get_LOGIN_URL()
    {
        null = null;
        return System.String.Format(format:  "https://snationapi.mmocircles.com/auth/authorize?client_id={0}&response_type=token&redirect_uri={1}", arg0:  MMOCClientUser.CLIENT_ID, arg1:  MMOCClientUser.REDIRECT_URI);
    }
    public static string get_CODE_URL()
    {
        null = null;
        return System.String.Format(format:  "https://snationapi.mmocircles.com/auth/authorize?client_id={0}&response_type=code&redirect_uri={1}", arg0:  MMOCClientUser.CLIENT_ID, arg1:  MMOCClientUser.REDIRECT_URI);
    }
    public MMOCClientUser.MMOCUserProfile get_userProfile()
    {
        return (MMOCUserProfile)this._profile;
    }
    public void set_userProfile(MMOCClientUser.MMOCUserProfile value)
    {
        this._profile = value;
        this.<OnEvents>k__BackingField.Invoke(arg0:  1);
    }
    public void GetAuthCode(UnityEngine.Events.UnityAction<bool, string> onLoginDone)
    {
        MMOCClientUser.<>c__DisplayClass52_0 val_1 = new MMOCClientUser.<>c__DisplayClass52_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .onLoginDone = onLoginDone;
        MMOCLoginListener val_2 = MMOCClientUser.MMOCLoginListener.instance;
        val_2.OnLogin = new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  val_1, method:  System.Void MMOCClientUser.<>c__DisplayClass52_0::<GetAuthCode>b__0(bool success, string url));
        UnityEngine.Application.OpenURL(url:  MMOCClientUser.CODE_URL);
    }
    private void OpenLoginURL(string page)
    {
        InAppBrowser.OpenURL(URL:  page, displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), pageTitle = "SGC InkWars Login", displayURLAsPageTitle = false, hidesTopBar = true, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = true, hidesHistoryButtons = true, setLoadWithOverviewMode = false});
    }
    public string ToJson(object obj)
    {
        return UnityEngine.JsonUtility.ToJson(obj:  obj);
    }
    public void GetToken(UnityEngine.Events.UnityAction<bool, string> onDone)
    {
        string val_9;
        var val_10;
        MMOCClientUser.<>c__DisplayClass55_0 val_1 = new MMOCClientUser.<>c__DisplayClass55_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .onDone = onDone;
        MMOCClientUser.MMOCAuthRequestData val_3 = new MMOCClientUser.MMOCAuthRequestData();
        if(val_3 != null)
        {
                .grant_type = "authorization_code";
            val_9 = this._authCode;
        }
        else
        {
                mem[16] = "authorization_code";
            val_9 = this._authCode;
        }
        
        .code = val_9;
        val_10 = null;
        val_10 = null;
        .client_id = MMOCClientUser.CLIENT_ID;
        .redirect_uri = MMOCClientUser.REDIRECT_URI;
        BestHTTP.HTTPRequest val_5 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  "https://snationapi.mmocircles.com/auth/token"), methodType:  2, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  val_1, method:  System.Void MMOCClientUser.<>c__DisplayClass55_0::<GetToken>b__0(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse res)));
        string val_6 = UnityEngine.JsonUtility.ToJson(obj:  val_3);
        System.Text.Encoding val_7 = System.Text.Encoding.UTF8;
        if(val_5 != null)
        {
                val_5.RawData = val_7;
            val_5.AddHeader(name:  "Content-Type", value:  "application/json");
            val_5.AddHeader(name:  "Cache-Control", value:  "no-cache");
        }
        else
        {
                val_5.RawData = val_7;
            val_5.AddHeader(name:  "Content-Type", value:  "application/json");
            val_5.AddHeader(name:  "Cache-Control", value:  "no-cache");
        }
        
        BestHTTP.HTTPRequest val_8 = val_5.Send();
    }
    public void Login(UnityEngine.Events.UnityAction<bool, string> onLoginDone)
    {
        MMOCClientUser.<>c__DisplayClass56_0 val_1 = new MMOCClientUser.<>c__DisplayClass56_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .onLoginDone = onLoginDone;
        MMOCLoginListener val_2 = MMOCClientUser.MMOCLoginListener.instance;
        val_2.OnLogin = new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  val_1, method:  System.Void MMOCClientUser.<>c__DisplayClass56_0::<Login>b__0(bool success, string url));
        UnityEngine.Application.OpenURL(url:  MMOCClientUser.LOGIN_URL);
    }
    private static string CreateErrorUrl(string error, string error_desc)
    {
        var val_6 = null;
        string val_5 = System.String.Format(format:  "{0}#error={1}&error_description={2}", arg0:  MMOCClientUser.REDIRECT_URI, arg1:  ((System.String.IsNullOrWhiteSpace(value:  error)) != true) ? "Unknown Error" : error, arg2:  ((System.String.IsNullOrWhiteSpace(value:  error_desc)) != true) ? "No Error Desc" : error_desc);
        if(val_5 != null)
        {
                return val_5.Replace(oldValue:  " ", newValue:  "%20");
        }
        
        return val_5.Replace(oldValue:  " ", newValue:  "%20");
    }
    public void JoinPool(int poolId, float initGems, UnityEngine.Events.UnityAction<MMOCClientUser.JoinedPoolData> onJoinPoolDone)
    {
        var val_11;
        MMOCClientUser.<>c__DisplayClass59_0 val_1 = new MMOCClientUser.<>c__DisplayClass59_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .onJoinPoolDone = onJoinPoolDone;
        if(poolId == 0)
        {
            goto label_3;
        }
        
        val_11 = null;
        val_11 = null;
        BestHTTP.HTTPRequest val_5 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  System.String.Format(format:  MMOCClientUser.API_JOIN_POOL_FORMAT, arg0:  poolId)), methodType:  2, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  val_1, method:  System.Void MMOCClientUser.<>c__DisplayClass59_0::<JoinPool>b__0(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response)));
        val_5.AddHeader(name:  "Content-Type", value:  "application/json-patch+json");
        val_5.AddHeader(name:  "Authorization", value:  this.apiAuthToken);
        System.Text.Encoding val_7 = System.Text.Encoding.UTF8;
        string val_8 = initGems.ToString();
        if(val_5 == null)
        {
            goto label_9;
        }
        
        val_5.RawData = val_7;
        goto label_10;
        label_3:
        if(onJoinPoolDone == null)
        {
                return;
        }
        
        MMOCClientUser.JoinedPoolData val_9 = new MMOCClientUser.JoinedPoolData();
        if(val_9 == null)
        {
            goto label_12;
        }
        
        mem[1152921528578973312] = "Invalid pool id 0";
        goto label_13;
        label_9:
        val_5.RawData = val_7;
        label_10:
        BestHTTP.HTTPRequest val_10 = val_5.Send();
        return;
        label_12:
        mem[16] = "Invalid pool id 0";
        label_13:
        mem[1152921528578973320] = 0;
        (MMOCClientUser.<>c__DisplayClass59_0)[1152921528578936432].onJoinPoolDone.Invoke(arg0:  val_9);
    }
    public void AddGems(int poolId, decimal addedGems, UnityEngine.Events.UnityAction<MMOCClientUser.JoinedPoolData> onAddGemsDone)
    {
        int val_14;
        int val_15;
        object val_16;
        var val_17;
        JoinedPoolData val_18;
        var val_19;
        var val_20;
        var val_21;
        val_14 = addedGems.lo;
        val_15 = poolId;
        MMOCClientUser.<>c__DisplayClass61_0 val_1 = null;
        val_16 = val_1;
        val_1 = new MMOCClientUser.<>c__DisplayClass61_0();
        .onAddGemsDone = onAddGemsDone;
        if(val_15 == 0)
        {
            goto label_2;
        }
        
        val_17 = null;
        val_17 = null;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = addedGems.flags, hi = addedGems.hi, lo = val_14, mid = addedGems.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
        {
            goto label_5;
        }
        
        if(((MMOCClientUser.<>c__DisplayClass61_0)[1152921528579168352].onAddGemsDone) == null)
        {
                return;
        }
        
        MMOCClientUser.JoinedPoolData val_3 = null;
        val_18 = val_3;
        val_3 = new MMOCClientUser.JoinedPoolData();
        if(val_18 == null)
        {
            goto label_7;
        }
        
        val_19 = "At least add 1 gem.";
        goto label_8;
        label_2:
        if(onAddGemsDone == null)
        {
                return;
        }
        
        MMOCClientUser.JoinedPoolData val_4 = null;
        val_18 = val_4;
        val_4 = new MMOCClientUser.JoinedPoolData();
        if(val_18 == null)
        {
            goto label_10;
        }
        
        val_19 = "Invalid pool id 0";
        label_8:
        mem[1152921528579180656] = val_19;
        goto label_11;
        label_5:
        val_20 = null;
        val_20 = null;
        BestHTTP.OnRequestFinishedDelegate val_7 = null;
        val_15 = val_7;
        val_7 = new BestHTTP.OnRequestFinishedDelegate(object:  val_1, method:  System.Void MMOCClientUser.<>c__DisplayClass61_0::<AddGems>b__0(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response));
        BestHTTP.HTTPRequest val_8 = null;
        val_16 = val_8;
        val_8 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  System.String.Format(format:  MMOCClientUser.API_ADD_GEM_FORMAT, arg0:  val_15)), methodType:  2, callback:  val_7);
        val_8.AddHeader(name:  "Content-Type", value:  "application/json-patch+json");
        val_8.AddHeader(name:  "Authorization", value:  this.apiAuthToken);
        .amount = addedGems;
        mem[1152921528579209336] = val_14;
        mem[1152921528579209340] = addedGems.mid;
        string val_11 = UnityEngine.JsonUtility.ToJson(obj:  new MMOCClientUser.AddGemsToPoolData());
        val_14 = System.Text.Encoding.UTF8;
        if(val_16 != null)
        {
                val_8.RawData = val_14;
        }
        else
        {
                val_8.RawData = val_14;
        }
        
        BestHTTP.HTTPRequest val_13 = val_8.Send();
        return;
        label_10:
        val_21 = "Invalid pool id 0";
        goto label_20;
        label_7:
        val_21 = "At least add 1 gem.";
        label_20:
        mem[16] = val_21;
        label_11:
        mem[1152921528579176568] = 0;
        (MMOCClientUser.<>c__DisplayClass61_0)[1152921528579168352].onAddGemsDone.Invoke(arg0:  val_3);
    }
    public void RefreshToken(UnityEngine.Events.UnityAction<bool, string> onDone)
    {
        var val_10;
        MMOCClientUser.<>c__DisplayClass62_0 val_1 = new MMOCClientUser.<>c__DisplayClass62_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .onDone = onDone;
        BestHTTP.HTTPRequest val_4 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  "https://snationapi.mmocircles.com/auth/token"), methodType:  2, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  val_1, method:  System.Void MMOCClientUser.<>c__DisplayClass62_0::<RefreshToken>b__0(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse res)));
        val_10 = null;
        val_10 = null;
        NFUser val_5 = NFUser.current;
        string val_7 = System.String.Format(format:  MMOCClientUser.API_AUTH_TOKEN_REFRESH_DATA_FORMAT, arg0:  val_5.loginUserInfo.refreshCode, arg1:  MMOCClientUser.CLIENT_ID);
        System.Text.Encoding val_8 = System.Text.Encoding.UTF8;
        if(val_4 != null)
        {
                val_4.RawData = val_8;
            val_4.AddHeader(name:  "Content-Type", value:  "application/x-www-form-urlencoded");
            val_4.AddHeader(name:  "Cache-Control", value:  "no-cache");
        }
        else
        {
                val_4.RawData = val_8;
            val_4.AddHeader(name:  "Content-Type", value:  "application/x-www-form-urlencoded");
            val_4.AddHeader(name:  "Cache-Control", value:  "no-cache");
        }
        
        BestHTTP.HTTPRequest val_9 = val_4.Send();
    }
    public void GetUserProfile(UnityEngine.Events.UnityAction<MMOCClientUser.MMOCUserProfile> onGetUserProfileDone)
    {
        var val_10;
        MMOCClientUser.<>c__DisplayClass63_0 val_1 = new MMOCClientUser.<>c__DisplayClass63_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .onGetUserProfileDone = onGetUserProfileDone;
        NFUser val_2 = NFUser.current;
        if((System.String.IsNullOrWhiteSpace(value:  val_2.loginUserInfo.refreshCode)) != false)
        {
                if(((MMOCClientUser.<>c__DisplayClass63_0)[1152921528579596128].onGetUserProfileDone) == null)
        {
                return;
        }
        
            (MMOCClientUser.<>c__DisplayClass63_0)[1152921528579596128].onGetUserProfileDone.Invoke(arg0:  0);
            return;
        }
        
        val_10 = null;
        val_10 = null;
        BestHTTP.HTTPRequest val_7 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  MMOCClientUser.API_BASIC_INFO), methodType:  0, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  val_1, method:  System.Void MMOCClientUser.<>c__DisplayClass63_0::<GetUserProfile>b__0(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response)));
        val_7.AddHeader(name:  "Content-Type", value:  "application/json");
        string val_8 = this.apiAuthToken;
        if(val_7 != null)
        {
                val_7.AddHeader(name:  "Authorization", value:  val_8);
        }
        else
        {
                val_7.AddHeader(name:  "Authorization", value:  val_8);
        }
        
        BestHTTP.HTTPRequest val_9 = val_7.Send();
    }
    public void SetToken(string aNewToken, string aNewTokenType)
    {
        this.accessToken = aNewToken;
        this.tokenType = aNewTokenType;
        NFUser val_1 = NFUser.current;
        val_1.loginUserInfo.ggpJWT = aNewToken;
        NFUser val_2 = NFUser.current;
        val_2.loginUserInfo.ggpJwtType = aNewTokenType;
    }
    public MMOCClientUser()
    {
        this.<OnEvents>k__BackingField = new MMOCClientUser.MMOCOnEvents();
    }
    private static MMOCClientUser()
    {
        MMOCClientUser.CLIENT_ID = "196";
        MMOCClientUser.REDIRECT_URI = "inkwars://mediahive.inkwarsdgc/MMOC/Auth";
        MMOCClientUser.SHOP_URL = "https://dolcegame.com.au";
        MMOCClientUser.API_JOIN_POOL_FORMAT = "https://snationapi.mmocircles.com/Pool/{0}/join";
        MMOCClientUser.API_ADD_GEM_FORMAT = "https://snationapi.mmocircles.com/Pool/{0}/addgems";
        MMOCClientUser.API_AUTH_TOKEN = "https://snationapi.mmocircles.com/auth/token";
        MMOCClientUser.API_AUTH_TOKEN_REFRESH_DATA_FORMAT = "grant_type=refresh_token&refresh_token={0}&client_id={1}";
        MMOCClientUser.API_AUTH_TOKEN_DATA_FORMAT = "grant_type=password&client_id={0}&username={1}&password={2}";
        MMOCClientUser.API_BASIC_INFO = "https://snationapi.mmocircles.com/Profile/basicinfo";
    }

}
