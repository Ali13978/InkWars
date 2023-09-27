using UnityEngine;
public class NetworkDiscovery_Custom : NetworkDiscovery
{
    // Fields
    public static NetworkDiscovery_Custom instance;
    
    // Methods
    public void SetHostData()
    {
        var val_13;
        .PlayerName = PlayerPrefsManager.PlayerName;
        val_13 = null;
        val_13 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        .Wins = (long)CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Stats.TotalPVPDraws;
        .Draws = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Stats.TotalPVPLosses;
        .Losses = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited});
        .Shells = PlayerPrefsManager.Shells;
        .Timer = PlayerPrefsManager.OnlinePVPTime;
        .version = VersionText.GetVersionString(format:  "{0}.{1}");
        this.broadcastData = UnityEngine.JsonUtility.ToJson(obj:  new HostData());
    }
    private void Awake()
    {
        if(NetworkDiscovery_Custom.instance != 0)
        {
                UnityEngine.Object.Destroy(obj:  NetworkDiscovery_Custom.instance);
        }
        
        NetworkDiscovery_Custom.instance = this;
    }
    private void Start()
    {
        this.SetHostData();
    }
    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        string val_12;
        var val_13;
        val_12 = data;
        if(HostManager.instance == 0)
        {
                return;
        }
        
        char[] val_3 = new char[1];
        val_3[0] = '}';
        val_13 = val_12.Split(separator:  val_3);
        if(val_4.Length >= 2)
        {
                if(val_12 != null)
        {
                val_13 = val_12.IndexOf(value:  '}');
        }
        else
        {
                val_13 = 0.IndexOf(value:  '}');
        }
        
            val_12 = val_12.Substring(startIndex:  0, length:  val_13 + 1);
        }
        
        UnityEngine.MonoBehaviour.print(message:  "BCast:"("BCast:") + val_12);
        val_10.IPAddress = fromAddress;
        HostManager.instance.HostRefreshed(host:  UnityEngine.JsonUtility.FromJson<HostData>(json:  val_12));
    }
    public void GuiPrint(string s = "")
    {
        NetworkManager_Custom.stringRPCMessageId.GuiPrint(s:  s);
    }
    public static void SafeStopBroadcasting()
    {
        NetworkDiscovery_Custom val_4 = NetworkDiscovery_Custom.instance;
        if(val_4 == 0)
        {
                return;
        }
        
        if(NetworkDiscovery_Custom.instance.isClient != true)
        {
                val_4 = NetworkDiscovery_Custom.instance;
            if(val_4.isServer == false)
        {
                return;
        }
        
        }
        
        val_4 = NetworkDiscovery_Custom.instance;
        val_4.StopBroadcast();
    }
    public NetworkDiscovery_Custom()
    {
    
    }

}
