using UnityEngine;
public class AzureRemoteConfig : MonoBehaviour
{
    // Fields
    private static bool <IsFetching>k__BackingField;
    private static System.Nullable<System.DateTime> _lastFetched;
    private static readonly double _secBetweenFetches;
    private static Newtonsoft.Json.Linq.JObject _configData;
    private static readonly OnFetchSubscriber OnDone;
    public const string ACTIVE_GAME_VERSION_KEY = "data.active_game_version";
    private static readonly string URLSTR;
    
    // Properties
    private static bool IsFetching { get; set; }
    
    // Methods
    private static bool get_IsFetching()
    {
        null = null;
        return (bool)AzureRemoteConfig.ACTIVE_GAME_VERSION_KEY;
    }
    private static void set_IsFetching(bool value)
    {
        null = null;
        AzureRemoteConfig.ACTIVE_GAME_VERSION_KEY = value;
    }
    public static string GetString(string key, string defaultValue = "")
    {
        null = null;
        Newtonsoft.Json.Linq.JToken val_1 = AzureRemoteConfig._configData.SelectToken(path:  key);
        if(val_1 != null)
        {
                return (string)val_1;
        }
        
        return (string)val_1;
    }
    public static double GetTimeSinceLastFetch()
    {
        ulong val_6;
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        if((1152921505088266248 & 1) == 0)
        {
                return (double)0.TotalSeconds;
        }
        
        System.DateTime val_1 = System.DateTime.Now;
        val_8 = null;
        val_6 = val_1.dateData;
        val_8 = null;
        if(((-2133160512) & 1) != 0)
        {
                System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_6}, d2:  new System.DateTime() {dateData = AzureRemoteConfig._lastFetched.InitialType});
        }
        
        return (double)0.TotalSeconds;
    }
    public static void FetchRemote(UnityEngine.Events.UnityAction<bool, string> callback)
    {
        if(AzureRemoteConfig.GetTimeSinceLastFetch() < 0)
        {
                callback.Invoke(arg0:  true, arg1:  "");
            return;
        }
        
        AzureRemoteConfig.OnDone.AddListener(call:  callback);
        if(AzureRemoteConfig.IsFetching != false)
        {
                return;
        }
        
        HttpNetworkingExecutor.Instance.Get(apiUrl:  HttpNetworkingExecutor.RemoteConfigUri, authUser:  0, callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  0, method:  static System.Void AzureRemoteConfig::FinishFetching(IResponse res)), buildUrl:  false);
    }
    private static void FinishFetching(IResponse res)
    {
        var val_10;
        if(res.IsSuccess != false)
        {
                AzureRemoteConfig.IsFetching = false;
            AzureRemoteConfig._configData = Newtonsoft.Json.Linq.JObject.Parse(json:  res.msg);
            UnityEngine.Debug.Log(message:  "Got fresh remote config");
            System.DateTime val_3 = System.DateTime.Now;
            AzureRemoteConfig._lastFetched = 0;
            AzureRemoteConfig.ACTIVE_GAME_VERSION_KEY.__il2cppRuntimeField_10 = 0;
            AzureRemoteConfig.OnDone.Invoke(arg0:  res.IsSuccess, arg1:  (res.IsSuccess != true) ? "" : (res + 16));
            val_10 = null;
            val_10 = null;
            AzureRemoteConfig.OnDone.RemoveAllListeners();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "remote config fetch fail");
        DialogPanel val_9 = DialogManager.Show(title:  "Remote Config", message:  (res.msg == null) ? "" : res.msg, cancelButtonTitle:  0, onCancelCallback:  0);
    }
    public AzureRemoteConfig()
    {
    
    }
    private static AzureRemoteConfig()
    {
        AzureRemoteConfig._secBetweenFetches = 30;
        AzureRemoteConfig.OnDone = new OnFetchSubscriber();
        AzureRemoteConfig.URLSTR = "config?region=ASIA";
    }

}
