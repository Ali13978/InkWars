using UnityEngine;
public class MVC_MusselTracker : MonoBehaviour
{
    // Fields
    public static int MAX_MUSSELS;
    private static System.TimeSpan RechargeTimeSpan;
    private static float TimeUntilNextRecharge;
    private static System.TimeSpan CalculationTimeSpan;
    private static System.DateTime TimeLastCalculation;
    private static bool FirstCalculationSinceAppOpen;
    private static string StrTimeUntilNextRecharge;
    
    // Properties
    private static int MusselCount { get; set; }
    private static System.DateTime Time_LastRechargeTime { get; set; }
    
    // Methods
    private static int get_MusselCount()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Mussels;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    private static void set_MusselCount(int value)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        val_4 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  UnityEngine.Mathf.Min(a:  value, b:  MVC_MusselTracker.MAX_MUSSELS));
        DataStructs.UserDataDictionary.Items.Mussels = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
    }
    private static System.DateTime get_Time_LastRechargeTime()
    {
        null = null;
        System.DateTime val_3 = System.DateTime.Parse(s:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.GameSave.MusselLastRechargeTime));
        return (System.DateTime)val_3.dateData;
    }
    private static void set_Time_LastRechargeTime(System.DateTime value)
    {
        null = null;
        DataStructs.UserDataDictionary.GameSave.MusselLastRechargeTime = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value.dateData);
    }
    public static int GetMusselCount()
    {
        MVC_MusselTracker.CheckForRecharge();
        return MVC_MusselTracker.MusselCount;
    }
    public static void AddMussels(int number)
    {
        var val_4 = null;
        int val_1 = MVC_MusselTracker.MusselCount;
        val_1 = val_1 + number;
        MVC_MusselTracker.MusselCount = val_1;
        if(MVC_MusselTracker.MusselCount != MVC_MusselTracker.MAX_MUSSELS)
        {
                return;
        }
        
        System.DateTime val_3 = System.DateTime.Now;
        MVC_MusselTracker.Time_LastRechargeTime = new System.DateTime() {dateData = val_3.dateData};
    }
    public static bool UseMussels(int number)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = null;
        MVC_MusselTracker.CheckForRecharge();
        if(MVC_MusselTracker.MusselCount < number)
        {
                val_7 = 0;
            return (bool)val_7;
        }
        
        val_8 = null;
        val_9 = null;
        if(MVC_MusselTracker.MusselCount == MVC_MusselTracker.MAX_MUSSELS)
        {
                System.DateTime val_3 = System.DateTime.Now;
            MVC_MusselTracker.Time_LastRechargeTime = new System.DateTime() {dateData = val_3.dateData};
            val_8 = 1152921505092792328;
            val_9 = null;
            MVC_MusselTracker.TimeUntilNextRecharge = (float)TotalSeconds;
        }
        
        int val_5 = MVC_MusselTracker.MusselCount;
        val_5 = val_5 - number;
        MVC_MusselTracker.MusselCount = val_5;
        val_7 = 1;
        return (bool)val_7;
    }
    public static string GetTimeTilNextMussel()
    {
        var val_2 = null;
        MVC_MusselTracker.CheckForRecharge();
        if(MVC_MusselTracker.MusselCount >= MVC_MusselTracker.MAX_MUSSELS)
        {
                return LanguageManager.GetText(key:  "Lk.Adv.Map.Full");
        }
        
        return (string)MVC_MusselTracker.StrTimeUntilNextRecharge;
    }
    private static void CheckForRecharge()
    {
        var val_32;
        var val_33;
        System.TimeSpan val_34;
        var val_35;
        float val_36;
        var val_38;
        var val_39;
        var val_40;
        var val_42;
        var val_46;
        val_32 = null;
        val_32 = null;
        if(MVC_MusselTracker.FirstCalculationSinceAppOpen != false)
        {
                System.DateTime val_1 = MVC_MusselTracker.Time_LastRechargeTime;
            MVC_MusselTracker.TimeLastCalculation = val_1.dateData;
        }
        
        System.DateTime val_2 = System.DateTime.Now;
        val_33 = null;
        val_33 = null;
        System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_2.dateData}, d2:  new System.DateTime() {dateData = MVC_MusselTracker.TimeLastCalculation});
        val_34 = MVC_MusselTracker.CalculationTimeSpan;
        if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_3._ticks}, t2:  new System.TimeSpan() {_ticks = val_34})) == true)
        {
                return;
        }
        
        System.DateTime val_5 = System.DateTime.Now;
        val_35 = null;
        val_35 = null;
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_5.dateData}, d2:  new System.DateTime() {dateData = MVC_MusselTracker.TimeLastCalculation});
        val_36 = val_6._ticks.TotalSeconds;
        val_34 = MVC_MusselTracker.MusselCount;
        if(val_34 < MVC_MusselTracker.MAX_MUSSELS)
        {
                double val_32 = (double)(int)val_36;
            val_32 = val_32 / TotalSeconds;
            int val_10 = UnityEngine.Mathf.FloorToInt(f:  (float)val_32);
            val_38 = null;
            if(val_10 >= 1)
        {
                val_39 = null;
            double val_12 = TotalSeconds;
            int val_33 = (int)TotalSeconds;
            val_12 = val_12 * (double)val_10;
            val_33 = val_33 - (int)val_36;
            val_33 = val_33 + (int)val_12;
            MVC_MusselTracker.TimeUntilNextRecharge = (float)val_33;
            System.DateTime val_13 = MVC_MusselTracker.Time_LastRechargeTime;
            double val_14 = TotalSeconds;
            val_14 = val_14 * (double)val_10;
            System.DateTime val_15 = val_13.dateData.AddSeconds(value:  val_14);
            MVC_MusselTracker.Time_LastRechargeTime = new System.DateTime() {dateData = val_15.dateData};
            val_40 = null;
        }
        else
        {
                val_40 = null;
            if(MVC_MusselTracker.FirstCalculationSinceAppOpen != false)
        {
                System.DateTime val_17 = System.DateTime.Now;
            System.DateTime val_18 = MVC_MusselTracker.Time_LastRechargeTime;
            System.TimeSpan val_19 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_17.dateData}, d2:  new System.DateTime() {dateData = val_18.dateData});
            val_40 = null;
            float val_34 = (float)val_19._ticks.TotalSeconds;
            val_34 = (float)TotalSeconds - val_34;
            MVC_MusselTracker.TimeUntilNextRecharge = val_34;
        }
        
        }
        
            val_40 = null;
            val_42 = null;
            val_34 = UnityEngine.Mathf.Min(a:  val_34 + val_10, b:  MVC_MusselTracker.MAX_MUSSELS);
            if((val_10 == 0) && (val_34 < MVC_MusselTracker.MAX_MUSSELS))
        {
                val_42 = null;
            if(MVC_MusselTracker.FirstCalculationSinceAppOpen != true)
        {
                val_42 = null;
            float val_35 = MVC_MusselTracker.TimeUntilNextRecharge;
            val_35 = val_35 - (float)(int)val_36;
            MVC_MusselTracker.TimeUntilNextRecharge = val_35;
            if(MVC_MusselTracker.TimeUntilNextRecharge <= 0f)
        {
                val_34 = val_34 + 1;
            float val_36 = (float)(int)TotalSeconds;
            MVC_MusselTracker.TimeUntilNextRecharge = val_36;
            System.DateTime val_24 = System.DateTime.Now;
            MVC_MusselTracker.Time_LastRechargeTime = new System.DateTime() {dateData = val_24.dateData};
            val_42 = null;
        }
        
        }
        
        }
        
            val_42 = null;
            val_36 = 60f;
            val_36 = MVC_MusselTracker.TimeUntilNextRecharge / val_36;
            MVC_MusselTracker.StrTimeUntilNextRecharge = UnityEngine.Mathf.FloorToInt(f:  val_36).ToString()(UnityEngine.Mathf.FloorToInt(f:  val_36).ToString()) + ":"(":") + UnityEngine.Mathf.FloorToInt(f:  MVC_MusselTracker.TimeUntilNextRecharge).ToString(format:  "D2")(UnityEngine.Mathf.FloorToInt(f:  MVC_MusselTracker.TimeUntilNextRecharge).ToString(format:  "D2"));
        }
        
        System.DateTime val_30 = System.DateTime.Now;
        val_46 = null;
        val_46 = null;
        MVC_MusselTracker.TimeLastCalculation = val_30.dateData;
        MVC_MusselTracker.FirstCalculationSinceAppOpen = false;
        if(val_34 == MVC_MusselTracker.MusselCount)
        {
                return;
        }
        
        MVC_MusselTracker.MusselCount = val_34;
    }
    public MVC_MusselTracker()
    {
    
    }
    private static MVC_MusselTracker()
    {
        MVC_MusselTracker.MAX_MUSSELS = 8;
        MVC_MusselTracker.RechargeTimeSpan = 0;
        MVC_MusselTracker.TimeUntilNextRecharge = 0f;
        MVC_MusselTracker.CalculationTimeSpan = 0;
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_2 = val_1.dateData.AddSeconds(value:  -1);
        MVC_MusselTracker.TimeLastCalculation = val_2.dateData;
        MVC_MusselTracker.FirstCalculationSinceAppOpen = true;
        MVC_MusselTracker.StrTimeUntilNextRecharge = "";
    }

}
