using UnityEngine;
public class NFJson_Database : MonoBehaviour
{
    // Fields
    private static NFJson_Database inst;
    
    // Methods
    public static void DownloadAllData(DataStructs.GameSave dataGameSave, DataStructs.Items dataItems, DataStructs.Settings dataSettings, DataStructs.Stats dataStats, UnityEngine.Events.UnityAction<NFJson_Database.IDatabaseResponse> callback)
    {
        DataStructs.Items val_10 = dataItems;
        NFJson_Database.<>c__DisplayClass2_0 val_1 = new NFJson_Database.<>c__DisplayClass2_0();
        if(val_1 != null)
        {
                .dataGameSave = dataGameSave;
            .dataItems = val_10;
            .dataSettings = dataSettings;
            .dataStats = dataStats;
        }
        else
        {
                mem[16] = dataGameSave;
            mem[24] = val_10;
            mem[32] = dataSettings;
            mem[40] = dataStats;
        }
        
        .callback = callback;
        if(NFUser.current.clientUser.IsLoggedIn != true)
        {
                UnityEngine.Debug.LogError(message:  "Attempting NFJsonDataSave without logging in!");
            NFJson_Database.IDatabaseResponse val_5 = null;
            val_10 = "Attempting NFJsonDataSave without logging in!";
            val_5 = new NFJson_Database.IDatabaseResponse();
            .success = false;
            .message = val_10;
            (NFJson_Database.<>c__DisplayClass2_0)[1152921528248912640].callback.Invoke(arg0:  val_5);
        }
        
        IWServerDB_Cache.EnableAddToCache(enable:  false);
        IWServerDB_Cache.EnableSaveRoutine(enable:  false);
        IWServerDB_Cache.CleanCache();
        .result = new NFJson_Database.IDatabaseResponse();
        NFUser.current.clientUser.loadData(callback:  new UnityEngine.Events.UnityAction<IResponse>(object:  val_1, method:  System.Void NFJson_Database.<>c__DisplayClass2_0::<DownloadAllData>b__0(IResponse res)));
    }
    private static bool CheckContainsKey(System.Collections.Generic.Dictionary<string, object> dataObj, string key)
    {
        string val_3;
        var val_4;
        val_3 = key;
        if((dataObj.ContainsKey(key:  val_3)) != false)
        {
                val_4 = 1;
            return (bool)val_4;
        }
        
        val_3 = "WARNING, MISSING " + val_3 + " DATA, SKIPPING...";
        UnityEngine.Debug.LogWarning(message:  val_3);
        val_4 = 0;
        return (bool)val_4;
    }
    private static void LoadJsonAllData(string jsonData, DataStructs.GameSave dataGameSave, DataStructs.Items dataItems, DataStructs.Settings dataSettings, DataStructs.Stats dataStats)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_15;
        Newtonsoft.Json.JsonSerializerSettings val_1 = new Newtonsoft.Json.JsonSerializerSettings();
        val_1.DateParseHandling = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.Dictionary<System.String, System.Object>>(value:  jsonData, settings:  val_1);
        if((NFJson_Database.CheckContainsKey(dataObj:  val_2, key:  "gamesave")) != false)
        {
                object val_4 = val_2.Item["gamesave"];
            dataGameSave.Load(data:  0.ToObject<System.Collections.Generic.Dictionary<System.String, System.Object>>());
        }
        
        val_15 = "items";
        if((NFJson_Database.CheckContainsKey(dataObj:  val_2, key:  "items")) != false)
        {
                object val_7 = val_2.Item["items"];
            val_15 = 0.ToObject<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            dataItems.Load(data:  val_15);
        }
        
        if((NFJson_Database.CheckContainsKey(dataObj:  val_2, key:  "settings")) != false)
        {
                object val_10 = val_2.Item["settings"];
            dataSettings.Load(data:  0.ToObject<System.Collections.Generic.Dictionary<System.String, System.Object>>());
        }
        
        if((NFJson_Database.CheckContainsKey(dataObj:  val_2, key:  "stats")) == false)
        {
                return;
        }
        
        object val_13 = val_2.Item["stats"];
        dataStats.Load(data:  0.ToObject<System.Collections.Generic.Dictionary<System.String, System.Object>>());
    }
    public NFJson_Database()
    {
    
    }

}
