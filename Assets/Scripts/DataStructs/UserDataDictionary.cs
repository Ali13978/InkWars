using UnityEngine;

namespace DataStructs
{
    public static class UserDataDictionary
    {
        // Fields
        public static DataStructs.GameSave GameSave;
        public static DataStructs.Items Items;
        public static DataStructs.Settings Settings;
        public static DataStructs.Stats Stats;
        public static UnityEngine.Events.UnityEvent OnCurrencyChanged;
        public static DataStructs.UserDataDictionary.UserDataChangedEvents OnUserDataChanged;
        
        // Methods
        public static void OnValueChanged(string key, object obj)
        {
            var val_9;
            var val_10;
            var val_11;
            if((System.String.op_Equality(a:  key, b:  "mussels")) != true)
            {
                    if((System.String.op_Equality(a:  key, b:  "shells")) != true)
            {
                    if((System.String.op_Equality(a:  key, b:  "pearls")) == false)
            {
                goto label_3;
            }
            
            }
            
            }
            
            val_9 = null;
            val_9 = null;
            DataStructs.UserDataDictionary.OnCurrencyChanged.Invoke();
            label_25:
            val_10 = null;
            val_10 = null;
            DataStructs.UserDataDictionary.OnUserDataChanged.Invoke(arg0:  key, arg1:  obj);
            return;
            label_3:
            if((System.String.op_Equality(a:  key, b:  "NoAds")) == false)
            {
                goto label_10;
            }
            
            bool val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {hiddenValue = 268435456, fakeValue = false, fakeValueChanged = true, inited = true});
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {hiddenValue = 268435456, fakeValue = false, fakeValueChanged = true, inited = true})) == false)
            {
                goto label_25;
            }
            
            val_11 = null;
            val_11 = null;
            DataStructs.UserDataDictionary.GameSave.SetAchievementProcess(id:  11, process:  100);
            goto label_25;
            label_10:
            if((System.String.op_Equality(a:  key, b:  "musicEnabled")) == false)
            {
                goto label_18;
            }
            
            GameAudio.ResetMusicSettingsByUserData();
            goto label_25;
            label_18:
            if((System.String.op_Equality(a:  key, b:  "soundEnabled")) == false)
            {
                goto label_25;
            }
            
            GameAudio.ResetSoundSettingByUserData();
            goto label_25;
        }
        public static void DownloadData(System.Action onAllDone, System.Action<float, System.Exception> onProcess, System.Action<string> onFailed)
        {
            UserDataDictionary.<>c__DisplayClass8_0 val_1 = new UserDataDictionary.<>c__DisplayClass8_0();
            if(val_1 != null)
            {
                    .onAllDone = onAllDone;
                .onProcess = onProcess;
            }
            else
            {
                    mem[16] = onAllDone;
                mem[24] = onProcess;
            }
            
            .onFailed = onFailed;
            DataStructs.UserDataDictionary.ResetAndEnableSave();
            NFJson_Database.DownloadAllData(dataGameSave:  DataStructs.UserDataDictionary.GameSave, dataItems:  DataStructs.UserDataDictionary.Items, dataSettings:  DataStructs.UserDataDictionary.Settings, dataStats:  DataStructs.UserDataDictionary.Stats, callback:  new UnityEngine.Events.UnityAction<IDatabaseResponse>(object:  val_1, method:  System.Void UserDataDictionary.<>c__DisplayClass8_0::<DownloadData>b__0(NFJson_Database.IDatabaseResponse result)));
        }
        public static void ResetAndEnableSave()
        {
            var val_5;
            IWServerDB_Cache.EnableAddToCache(enable:  false);
            DataStructs.GameSave val_1 = new DataStructs.GameSave();
            mem[1152921529240808848] = 0;
            mem[1152921529240808856] = 0;
            val_5 = null;
            val_5 = null;
            DataStructs.UserDataDictionary.GameSave = val_1;
            DataStructs.Items val_2 = new DataStructs.Items();
            mem[1152921529240812944] = 0;
            mem[1152921529240812952] = 0;
            DataStructs.UserDataDictionary.Items = val_2;
            DataStructs.Settings val_3 = new DataStructs.Settings();
            mem[1152921529240817040] = 0;
            mem[1152921529240817048] = 0;
            DataStructs.UserDataDictionary.Settings = val_3;
            DataStructs.Stats val_4 = new DataStructs.Stats();
            mem[1152921529240821136] = 0;
            mem[1152921529240821144] = 0;
            DataStructs.UserDataDictionary.Stats = val_4;
            UnityEngine.Debug.Log(message:  "Loading GameSave Defaults...");
            val_1.Load(data:  0);
            UnityEngine.Debug.Log(message:  "Loading Item Defaults...");
            val_2.Load(data:  0);
            UnityEngine.Debug.Log(message:  "Loading Setting Defaults...");
            val_3.Load(data:  0);
            UnityEngine.Debug.Log(message:  "Loading Stat Defaults...");
            val_4.Load(data:  0);
            IWServerDB_Cache.EnableAddToCache(enable:  true);
        }
        public static NetworkUserInfo ToNetworkUserInfo()
        {
            var val_24 = null;
            .userName = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.userName);
            .flag = DataStructs.UserDataDictionary.Settings.UserFlag;
            .playerPoint = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 48 + 8, inited = DataStructs.UserDataDictionary.Stats + 48 + 8});
            .currentCharacterRank = DataStructs.UserDataDictionary.Stats.CurrentCharacterRank;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Stats.CurrentCharacterBP;
            .currentCharacterBP = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited});
            .avatarID = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 176 + 8, inited = DataStructs.UserDataDictionary.Settings + 176 + 8});
            .titleID = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 192 + 8, inited = DataStructs.UserDataDictionary.Settings + 192 + 8});
            .battleGridID = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 208 + 8, inited = DataStructs.UserDataDictionary.Settings + 208 + 8});
            .switcherID = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 224 + 8, inited = DataStructs.UserDataDictionary.Settings + 224 + 8});
            .musicID = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 144 + 8, inited = DataStructs.UserDataDictionary.Settings + 144 + 8});
            .stageID = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 160 + 8, inited = DataStructs.UserDataDictionary.Settings + 160 + 8});
            .bubbleID = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 240 + 8, inited = DataStructs.UserDataDictionary.Settings + 240 + 8});
            .enhancerID = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Settings + 272 + 8, inited = DataStructs.UserDataDictionary.Settings + 272 + 8});
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_16 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
            .win = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16.currentCryptoKey, hiddenValue = val_16.hiddenValue, fakeValue = val_16.fakeValue, inited = val_16.inited});
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_18 = DataStructs.UserDataDictionary.Stats.TotalPVPLosses;
            .lose = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_18.currentCryptoKey, hiddenValue = val_18.hiddenValue, fakeValue = val_18.fakeValue, inited = val_18.inited});
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_20 = DataStructs.UserDataDictionary.Stats.TotalPVPDraws;
            .draw = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_20.currentCryptoKey, hiddenValue = val_20.hiddenValue, fakeValue = val_20.fakeValue, inited = val_20.inited});
            .allTimeHighScore = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = 455270400, hiddenValue = 268435456, fakeValue = DataStructs.UserDataDictionary.Stats + 96 + 8, inited = DataStructs.UserDataDictionary.Stats + 96 + 8});
            .buff = PlayerBuff.GetLocalPlayerBuff();
            return (NetworkUserInfo)new NetworkUserInfo();
        }
        private static UserDataDictionary()
        {
            DataStructs.UserDataDictionary.GameSave = 0;
            DataStructs.UserDataDictionary.Items = 0;
            DataStructs.UserDataDictionary.Settings = 0;
            DataStructs.UserDataDictionary.Stats = 0;
            DataStructs.UserDataDictionary.OnCurrencyChanged = new UnityEngine.Events.UnityEvent();
            DataStructs.UserDataDictionary.OnUserDataChanged = new UserDataDictionary.UserDataChangedEvents();
        }
    
    }

}
