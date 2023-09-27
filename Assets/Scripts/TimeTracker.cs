using UnityEngine;
public static class TimeTracker
{
    // Fields
    private const int MAXIMUM_DAYS = 10;
    private static System.DateTime rewardPanelOpenDate;
    private static System.DateTime localCurrentDate;
    public static bool CanReceiveReward;
    public static CodeStage.AntiCheat.ObscuredTypes.ObscuredBool rewardReady;
    public static UnityEngine.Events.UnityEvent OnTimeValidated;
    
    // Methods
    public static void SetRewardedDate()
    {
        var val_10;
        var val_11;
        int val_12;
        var val_13;
        var val_14;
        val_10 = null;
        val_10 = null;
        val_11 = null;
        val_11 = null;
        DataStructs.UserDataDictionary.GameSave.LastDailyRewardTime = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  TimeTracker.rewardPanelOpenDate.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.GameSave.DailyRewardCounter;
        int val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        val_4 = val_4 + 1;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_4);
        val_12 = val_5.fakeValue;
        DataStructs.UserDataDictionary.GameSave.DailyRewardCounter = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_12, inited = val_5.inited};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.GameSave.DailyRewardCounter;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited})) >= 10)
        {
                val_13 = null;
            val_13 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            val_12 = val_8.fakeValue;
            DataStructs.UserDataDictionary.GameSave.DailyRewardCounter = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.currentCryptoKey, hiddenValue = val_8.hiddenValue, fakeValue = val_12, inited = val_8.inited};
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        val_14 = null;
        val_14 = null;
        TimeTracker.rewardReady = val_9.currentCryptoKey;
        TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1C = val_9.fakeValue;
        TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1D = val_9.fakeValueChanged;
        TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1E = val_9.inited;
    }
    public static void AssignRewardTime()
    {
        var val_2;
        var val_3;
        UnityEngine.Events.UnityAction<System.Boolean> val_5;
        val_2 = null;
        val_2 = null;
        TimeTracker.CanReceiveReward = true;
        val_3 = null;
        val_3 = null;
        val_5 = TimeTracker.<>c.<>9__7_0;
        if(val_5 == null)
        {
                UnityEngine.Events.UnityAction<System.Boolean> val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  TimeTracker.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TimeTracker.<>c::<AssignRewardTime>b__7_0(bool ready));
            TimeTracker.<>c.<>9__7_0 = val_5;
        }
        
        TimeTracker.ValidateRewardDate(callback:  val_1);
    }
    private static void ValidateRewardDate(UnityEngine.Events.UnityAction<bool> callback)
    {
        object val_19;
        var val_20;
        int val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        bool val_27;
        var val_28;
        ulong val_29;
        var val_30;
        var val_31;
        TimeTracker.<>c__DisplayClass8_0 val_1 = null;
        val_19 = val_1;
        val_1 = new TimeTracker.<>c__DisplayClass8_0();
        if(val_19 == null)
        {
            goto label_1;
        }
        
        val_20 = val_19;
        .callback = callback;
        if(callback != null)
        {
            goto label_2;
        }
        
        return;
        label_1:
        val_20 = 16;
        mem[16] = callback;
        if(mem[16] == 0)
        {
                return;
        }
        
        label_2:
        System.DateTime val_2 = System.DateTime.UtcNow;
        System.DateTime val_3 = TimeTracker.ResetDateHours(t:  new System.DateTime() {dateData = val_2.dateData});
        TimeTracker.localCurrentDate = val_3.dateData;
        val_21 = 1152921505151520768;
        val_22 = null;
        val_22 = null;
        val_23 = null;
        if((System.String.IsNullOrEmpty(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.GameSave.LastDailyRewardTime))) != false)
        {
                val_24 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            val_21 = val_7.currentCryptoKey;
            DataStructs.UserDataDictionary.GameSave.DailyRewardCounter = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_21, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited};
            val_25 = null;
            val_25 = null;
            TimeTracker.rewardPanelOpenDate = TimeTracker.localCurrentDate;
            val_26 = 1152921528216153408;
            var val_8 = (TimeTracker.CanReceiveReward == true) ? 1 : 0;
        }
        else
        {
                val_28 = null;
            System.DateTime val_12 = TimeTracker.DeserializeTime(binaryData:  System.Convert.ToInt64(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.GameSave.LastDailyRewardTime)));
            val_29 = val_12.dateData;
            if(val_19 != null)
        {
                .rewardDate = val_12;
        }
        else
        {
                val_21 = 24;
            mem[24] = val_29;
            val_29 = mem[24];
        }
        
            System.TimeSpan val_13 = TimeTracker.localCurrentDate.Subtract(value:  new System.DateTime() {dateData = val_29});
            if(val_13._ticks.Days >= 1)
        {
                val_30 = null;
            val_30 = null;
            System.TimeSpan val_15 = TimeTracker.rewardPanelOpenDate.Subtract(value:  new System.DateTime() {dateData = TimeTracker.localCurrentDate});
            if(val_15._ticks.Days != 0)
        {
                TimeTracker.GetOnlineTime(callback:  new UnityEngine.Events.UnityAction<System.String>(object:  val_1, method:  System.Void TimeTracker.<>c__DisplayClass8_0::<ValidateRewardDate>b__0(string dateString)));
            return;
        }
        
        }
        
            val_31 = null;
            val_19 = mem[16];
            val_31 = null;
            val_21 = TimeTracker.rewardReady;
            val_26 = 1152921528216153408;
            val_27 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_21, hiddenValue = val_21, fakeValue = TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1C, fakeValueChanged = TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1C, inited = TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1C});
        }
        
        val_19.Invoke(arg0:  val_27);
    }
    private static void GetOnlineTime(UnityEngine.Events.UnityAction<string> callback)
    {
        .callback = callback;
        .getter = new UnityEngine.GameObject(name:  "TimeGetter").AddComponent<OnlineTimeGetter>();
        IOnlineTimeParser[] val_4 = new IOnlineTimeParser[1];
        TimeParseWhatTimeIsIt val_5 = new TimeParseWhatTimeIsIt();
        if(val_4 == null)
        {
            goto label_3;
        }
        
        if(val_5 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_5 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_4[0] = val_5;
        (TimeTracker.<>c__DisplayClass9_0)[1152921528216403440].getter.GetOnlineTime(parserList:  val_4, callback:  new UnityEngine.Events.UnityAction<System.String>(object:  new TimeTracker.<>c__DisplayClass9_0(), method:  System.Void TimeTracker.<>c__DisplayClass9_0::<GetOnlineTime>b__0(string dateString)));
    }
    private static string SerializeTime(System.DateTime t)
    {
        return (string)t.dateData.ToString();
    }
    private static System.DateTime DeserializeTime(long binaryData)
    {
        return System.DateTime.FromBinary(dateData:  binaryData);
    }
    private static System.DateTime ResetDateHours(System.DateTime t)
    {
        int val_1 = t.dateData.Year;
        int val_2 = t.dateData.Month;
        int val_3 = t.dateData.Day;
        return 0;
    }
    private static TimeTracker()
    {
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        TimeTracker.rewardReady = val_1.currentCryptoKey;
        TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1C = val_1.fakeValue;
        TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1D = val_1.fakeValueChanged;
        TimeTracker.rewardPanelOpenDate.__il2cppRuntimeField_1E = val_1.inited;
        TimeTracker.OnTimeValidated = new UnityEngine.Events.UnityEvent();
    }

}
