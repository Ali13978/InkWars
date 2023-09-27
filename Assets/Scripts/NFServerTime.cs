using UnityEngine;
public class NFServerTime : MonoBehaviour
{
    // Fields
    private static NFServerTime _inst;
    private static UnityEngine.Events.UnityEvent OnServerTimeEnabled;
    private System.DateTime _serverTimeUtc;
    private float savedRealTimeSinceStart;
    private bool _isActive;
    
    // Properties
    private static NFServerTime inst { get; }
    public static bool isServerTimeActive { get; }
    
    // Methods
    private static NFServerTime get_inst()
    {
        var val_4;
        NFServerTime val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = NFServerTime._inst;
        if(0 == val_5)
        {
                UnityEngine.GameObject val_2 = null;
            val_5 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "ServerTimeUpdater");
            val_6 = null;
            val_6 = null;
            NFServerTime._inst = val_2.AddComponent<NFServerTime>();
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
        }
        
        val_7 = null;
        val_7 = null;
        return (NFServerTime)NFServerTime._inst;
    }
    public static bool get_isServerTimeActive()
    {
        if(NFServerTime.inst != null)
        {
                return (bool)val_1._isActive;
        }
        
        return (bool)val_1._isActive;
    }
    public static void SetFromServerTimeString(string timeStr)
    {
        var val_11;
        NFServerTime val_1 = NFServerTime.inst;
        System.DateTime val_3 = System.DateTime.ParseExact(s:  timeStr, format:  "dd.MM.yyyy - HH:mm:ss", provider:  System.Globalization.CultureInfo.InvariantCulture);
        val_1._serverTimeUtc = val_3;
        NFServerTime val_4 = NFServerTime.inst;
        val_4.savedRealTimeSinceStart = UnityEngine.Time.realtimeSinceStartup;
        NFServerTime val_6 = NFServerTime.inst;
        val_6._isActive = true;
        NFServerTime val_7 = NFServerTime.inst;
        UnityEngine.Debug.Log(message:  "Update server time UTC" + val_7._serverTimeUtc);
        System.DateTime val_9 = NFServerTime.GetLocal();
        UnityEngine.Debug.Log(message:  "Update server time LOCAL " + val_9.dateData);
        val_11 = null;
        if(NFServerTime.OnServerTimeEnabled != null)
        {
                NFServerTime.OnServerTimeEnabled.Invoke();
            val_11 = null;
        }
        
        val_11 = null;
        NFServerTime.OnServerTimeEnabled.RemoveAllListeners();
    }
    public static void CleanServerTime()
    {
        var val_6;
        NFServerTime val_7;
        val_6 = null;
        val_6 = null;
        val_7 = NFServerTime._inst;
        if(0 == val_7)
        {
                return;
        }
        
        NFServerTime val_2 = NFServerTime.inst;
        if(val_2._isActive != false)
        {
                System.DateTime val_3 = NFServerTime.GetUTC();
            UnityEngine.Debug.Log(message:  "Clean server time at" + val_3.dateData);
        }
        
        val_7 = NFServerTime.inst;
        val_5._isActive = false;
    }
    public static System.DateTime GetUTC()
    {
        null = null;
        return NFServerTime.GetUTC(defaultValue:  new System.DateTime() {dateData = System.DateTime.MinValue});
    }
    public static System.DateTime GetUTC(System.DateTime defaultValue)
    {
        NFServerTime val_1 = NFServerTime.inst;
        if(val_1._isActive == false)
        {
                return (System.DateTime)defaultValue.dateData;
        }
        
        float val_5 = UnityEngine.Time.realtimeSinceStartup;
        NFServerTime val_3 = NFServerTime.inst;
        val_5 = val_5 - val_3.savedRealTimeSinceStart;
        if(NFServerTime.inst != null)
        {
                return val_4._serverTimeUtc.AddSeconds(value:  (double)val_5);
        }
        
        return val_4._serverTimeUtc.AddSeconds(value:  (double)val_5);
    }
    public static System.DateTime GetLocal()
    {
        null = null;
        return NFServerTime.GetLocal(defaultValue:  new System.DateTime() {dateData = System.DateTime.MinValue});
    }
    public static System.DateTime GetLocal(System.DateTime defaultValue)
    {
        System.DateTime val_1 = NFServerTime.GetUTC(defaultValue:  new System.DateTime() {dateData = defaultValue.dateData});
        System.DateTime val_2 = val_1.dateData.ToLocalTime();
        return (System.DateTime)val_2.dateData;
    }
    public static void WaitUntilServerTimeActive(UnityEngine.Events.UnityAction callback)
    {
        .callback = callback;
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  new NFServerTime.<>c__DisplayClass15_0(), method:  System.Void NFServerTime.<>c__DisplayClass15_0::<WaitUntilServerTimeActive>b__0()), delay:  0f);
    }
    public NFServerTime()
    {
    
    }
    private static NFServerTime()
    {
        NFServerTime.OnServerTimeEnabled = new UnityEngine.Events.UnityEvent();
    }

}
