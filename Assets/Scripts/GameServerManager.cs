using UnityEngine;
public static class GameServerManager
{
    // Fields
    private static UnityEngine.Events.UnityEvent OnServerIPCheckDoneEvent;
    private static System.Collections.Generic.List<GameServerInfo> serverData;
    
    // Methods
    public static GameServerInfo Get(string serverId)
    {
        var val_9;
        var val_10;
        .serverId = serverId;
        val_9 = null;
        val_9 = null;
        if(GameServerManager.serverData != null)
        {
                if((System.String.IsNullOrWhiteSpace(value:  .serverId)) == false)
        {
            goto label_5;
        }
        
        }
        
        object[] val_3 = new object[1];
        val_3[0] = ((System.String.IsNullOrWhiteSpace(value:  .serverId)) != true) ? "null or white space" : 358800032;
        label_22:
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot get server ip by name: {0}", args:  val_3);
        return 0;
        label_5:
        val_10 = null;
        val_10 = null;
        if((GameServerManager.serverData.Find(match:  new System.Predicate<GameServerInfo>(object:  new GameServerManager.<>c__DisplayClass2_0(), method:  System.Boolean GameServerManager.<>c__DisplayClass2_0::<Get>b__0(GameServerInfo x)))) != null)
        {
                return 0;
        }
        
        new object[1][0] = .serverId;
        goto label_22;
    }
    public static System.Collections.Generic.List<GameServerInfo> GetAllServers()
    {
        var val_4;
        var val_5;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = null;
        val_5 = null;
        if((GameServerManager.<>c.<>9__3_0) == null)
        {
            goto label_5;
        }
        
        label_11:
        val_7 = GameServerManager.serverData.FindAll(match:  GameServerManager.<>c.<>9__3_0);
        if(val_7 != null)
        {
                return (System.Collections.Generic.List<GameServerInfo>)val_7;
        }
        
        System.Collections.Generic.List<GameServerInfo> val_2 = null;
        val_7 = val_2;
        val_2 = new System.Collections.Generic.List<GameServerInfo>();
        return (System.Collections.Generic.List<GameServerInfo>)val_7;
        label_5:
        GameServerManager.<>c.<>9__3_0 = new System.Predicate<GameServerInfo>(object:  GameServerManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameServerManager.<>c::<GetAllServers>b__3_0(GameServerInfo x));
        if(GameServerManager.serverData != null)
        {
            goto label_11;
        }
        
        goto label_11;
    }
    public static System.Collections.Generic.List<GameServerInfo> GetAllDisplayServers()
    {
        var val_7;
        var val_8;
        var val_10;
        System.Func<GameServerInfo, System.Int32> val_12;
        var val_13;
        val_7 = null;
        val_7 = null;
        val_8 = null;
        val_8 = null;
        if((GameServerManager.<>c.<>9__4_0) == null)
        {
            goto label_5;
        }
        
        label_17:
        System.Collections.Generic.List<T> val_1 = GameServerManager.serverData.FindAll(match:  GameServerManager.<>c.<>9__4_0);
        if(val_1 == null)
        {
            goto label_7;
        }
        
        val_10 = null;
        val_10 = null;
        val_12 = GameServerManager.<>c.<>9__4_1;
        if(val_12 == null)
        {
                System.Func<GameServerInfo, System.Int32> val_2 = null;
            val_12 = val_2;
            val_2 = new System.Func<GameServerInfo, System.Int32>(object:  GameServerManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GameServerManager.<>c::<GetAllDisplayServers>b__4_1(GameServerInfo x));
            GameServerManager.<>c.<>9__4_1 = val_12;
        }
        
        val_13 = System.Linq.Enumerable.ToList<GameServerInfo>(source:  System.Linq.Enumerable.OrderByDescending<GameServerInfo, System.Int32>(source:  val_1, keySelector:  val_2));
        return (System.Collections.Generic.List<GameServerInfo>)val_13;
        label_5:
        GameServerManager.<>c.<>9__4_0 = new System.Predicate<GameServerInfo>(object:  GameServerManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameServerManager.<>c::<GetAllDisplayServers>b__4_0(GameServerInfo x));
        if(GameServerManager.serverData != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_7:
        System.Collections.Generic.List<GameServerInfo> val_6 = null;
        val_13 = val_6;
        val_6 = new System.Collections.Generic.List<GameServerInfo>();
        return (System.Collections.Generic.List<GameServerInfo>)val_13;
    }
    public static void FetchGameServerIP(UnityEngine.Events.UnityAction OnDone, bool showLoadingWhenProc = False)
    {
        null = null;
        GameServerManager.OnServerIPCheckDoneEvent.AddListener(call:  OnDone);
        if(showLoadingWhenProc != false)
        {
                DialogManager.ShowLoading();
        }
        
        AzureRemoteConfig.FetchRemote(callback:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  0, method:  static System.Void GameServerManager::OnServerIPFetchDone(bool success, string error)));
    }
    private static void OnServerIPFetchDone(bool success, string error)
    {
        DialogManager.HideLoading();
        if(success != false)
        {
                GameServerManager.OnFetchSuccess();
            return;
        }
        
        GameServerManager.OnFetchFail();
    }
    public static void ReloadWithoutDownload()
    {
        GameServerManager.OnFetchSuccess();
    }
    private static void OnFetchSuccess()
    {
        var val_7;
        System.Object[] val_9;
        var val_10;
        var val_11;
        val_7 = null;
        val_7 = null;
        GameServerManager.serverData.Clear();
        do
        {
            string val_4 = AzureRemoteConfig.GetString(key:  "data.ServerInfo_" + 0.ToString(), defaultValue:  0);
            if(val_4 != null)
        {
                val_9 = UnityEngine.JsonUtility.FromJson<GameServerInfo>(json:  val_4);
            if(val_9 != null)
        {
                UnityEngine.Debug.Log(message:  UnityEngine.JsonUtility.ToJson(obj:  val_9));
            val_10 = null;
            val_10 = null;
            GameServerManager.serverData.Add(item:  val_9);
        }
        
        }
        
            var val_7 = 0;
            val_7 = val_7 + 1;
        }
        while(val_7 < 10);
        
        val_11 = null;
        val_11 = null;
        GameServerManager.OnServerIPCheckDoneEvent.Invoke();
        GameServerManager.OnServerIPCheckDoneEvent.RemoveAllListeners();
    }
    private static void SendRemortConfigData()
    {
        string val_44;
        var val_45;
        string val_47;
        UnityEngine.DrivenTransformProperties val_48;
        string val_49;
        string val_50;
        var val_51;
        object val_52;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_44 = "\"";
        val_45 = 1152921511426435152;
        do
        {
            string val_4 = "ServerInfo_" + 0.ToString();
            string val_5 = AzureRemoteConfig.GetString(key:  val_4, defaultValue:  "null");
            if((UnityEngine.JsonUtility.FromJson<GameServerInfo>(json:  val_5)) != null)
        {
                val_1.Add(item:  "\"" + val_4 + "\" : "("\" : ") + val_5);
        }
        
            var val_44 = 0;
            val_44 = val_44 + 1;
        }
        while(val_44 < 100);
        
        val_47 = "{";
        val_1.Add(item:  "\"Cancelled_ServerInfo_3\" : "("\"Cancelled_ServerInfo_3\" : ") + AzureRemoteConfig.GetString(key:  "data.Cancelled_ServerInfo_3", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.Cancelled_ServerInfo_3", defaultValue:  0)));
        val_1.Add(item:  "\"VIPPromo\" : "("\"VIPPromo\" : ") + AzureRemoteConfig.GetString(key:  "data.VIPPromo", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.VIPPromo", defaultValue:  0)));
        val_1.Add(item:  "\"VIPData\" : "("\"VIPData\" : ") + AzureRemoteConfig.GetString(key:  "data.VIPData", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.VIPData", defaultValue:  0)));
        val_1.Add(item:  "\"BattleBonusConfig\" : "("\"BattleBonusConfig\" : ") + AzureRemoteConfig.GetString(key:  "data.BattleBonusConfig", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.BattleBonusConfig", defaultValue:  0)));
        val_1.Add(item:  "\"CharacterPromoConfig\" : "("\"CharacterPromoConfig\" : ") + AzureRemoteConfig.GetString(key:  "data.CharacterPromoConfig", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.CharacterPromoConfig", defaultValue:  0)));
        val_1.Add(item:  "\"MMOC_API_BasicInfo\" : \""("\"MMOC_API_BasicInfo\" : \"") + AzureRemoteConfig.GetString(key:  "data.MMOC_API_BasicInfo", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.MMOC_API_BasicInfo", defaultValue:  0)) + val_44);
        val_1.Add(item:  "\"MMOC_API_AuthTokenDataFormat\" : \""("\"MMOC_API_AuthTokenDataFormat\" : \"") + AzureRemoteConfig.GetString(key:  "data.MMOC_API_AuthTokenDataFormat", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.MMOC_API_AuthTokenDataFormat", defaultValue:  0)) + "\"");
        val_1.Add(item:  "\"MMOC_API_AuthToken\" : \""("\"MMOC_API_AuthToken\" : \"") + AzureRemoteConfig.GetString(key:  "data.MMOC_API_AuthToken", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.MMOC_API_AuthToken", defaultValue:  0)) + "\"");
        val_1.Add(item:  "\"MMOC_API_AddGemFormat\" : \""("\"MMOC_API_AddGemFormat\" : \"") + AzureRemoteConfig.GetString(key:  "data.MMOC_API_AddGemFormat", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.MMOC_API_AddGemFormat", defaultValue:  0)) + "\"");
        val_1.Add(item:  "\"MMOC_API_JoinPoolFormat\" : \""("\"MMOC_API_JoinPoolFormat\" : \"") + AzureRemoteConfig.GetString(key:  "data.MMOC_API_JoinPoolFormat", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.MMOC_API_JoinPoolFormat", defaultValue:  0)) + "\"");
        val_1.Add(item:  "\"MMOC_RedirectUrl\" : \""("\"MMOC_RedirectUrl\" : \"") + AzureRemoteConfig.GetString(key:  "data.MMOC_RedirectUrl", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.MMOC_RedirectUrl", defaultValue:  0)) + "\"");
        val_1.Add(item:  "\"MMOC_ClientId\" : \""("\"MMOC_ClientId\" : \"") + AzureRemoteConfig.GetString(key:  "data.MMOC_ClientId", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.MMOC_ClientId", defaultValue:  0)) + "\"");
        val_1.Add(item:  "\"MMOC_LoginUrlFormat\" : \""("\"MMOC_LoginUrlFormat\" : \"") + AzureRemoteConfig.GetString(key:  "data.MMOC_LoginUrlFormat", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.MMOC_LoginUrlFormat", defaultValue:  0)) + "\"");
        val_1.Add(item:  "\"MMOC_ShopUrl\" : \""("\"MMOC_ShopUrl\" : \"") + AzureRemoteConfig.GetString(key:  "data.MMOC_ShopUrl", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.MMOC_ShopUrl", defaultValue:  0)) + "\"");
        val_48 = 0;
        val_49 = "\"active_game_version\" : \""("\"active_game_version\" : \"") + AzureRemoteConfig.GetString(key:  "data.active_game_version", defaultValue:  0)(AzureRemoteConfig.GetString(key:  "data.active_game_version", defaultValue:  0)) + "\"";
        if(val_1 != null)
        {
                val_50 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            val_1.Add(item:  val_49);
        }
        else
        {
                val_50 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            val_1.Add(item:  val_49);
        }
        
        List.Enumerator<T> val_38 = val_1.GetEnumerator();
        val_51 = 1152921519703869328;
        val_52 = 0;
        goto label_37;
        label_39:
        val_49 = 0.InitialType;
        val_50 = mem[val_52 < val_41 ? "," : "}"];
        val_50 = (val_52 < (val_1.Count - 1)) ? "," : "}";
        val_48 = 0;
        val_47 = val_47 + val_49 + val_50;
        val_52 = 1;
        label_37:
        if((359889056 & 1) != 0)
        {
            goto label_39;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<System.String>::Dispose(), rectTransform:  val_50, drivenProperties:  val_48);
    }
    private static void OnFetchFail()
    {
        DialogPanel val_1 = DialogManager.Show(title:  "LK.CannotConnectServerTitle", message:  "LK.CannotConnectServerMessage", cancelButtonTitle:  0, onCancelCallback:  0);
    }
    private static void SetFetchEnable(bool enable)
    {
        if(enable != false)
        {
                DialogManager.ShowLoading();
            return;
        }
        
        DialogManager.HideLoading();
    }
    private static GameServerManager()
    {
        GameServerManager.OnServerIPCheckDoneEvent = new UnityEngine.Events.UnityEvent();
        GameServerManager.serverData = new System.Collections.Generic.List<GameServerInfo>();
    }

}
