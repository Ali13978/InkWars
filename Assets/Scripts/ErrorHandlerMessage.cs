using UnityEngine;
[Serializable]
public class ErrorHandlerMessage
{
    // Fields
    public static System.Collections.Generic.HashSet<string> ReportedStackTraces;
    public string account;
    public string accountType;
    public string displayUserName;
    public string logMessage;
    public string[] stackTrace;
    public string logType;
    public string dateTime;
    public string sceneName;
    
    // Methods
    private ErrorHandlerMessage()
    {
    
    }
    public static byte[] Generate(string logMessage, string stackTrace, UnityEngine.LogType logType)
    {
        string val_25;
        var val_26;
        System.Collections.Generic.HashSet<System.String> val_27;
        var val_28;
        var val_29;
        string val_30;
        string val_31;
        string val_32;
        var val_33;
        DataStructs.Settings val_34;
        var val_35;
        val_25 = logMessage;
        val_26 = null;
        val_26 = null;
        val_27 = ErrorHandlerMessage.ReportedStackTraces;
        if((val_27.Contains(item:  stackTrace)) != false)
        {
                val_28 = 0;
            return (System.Byte[])val_28;
        }
        
        val_29 = null;
        val_29 = null;
        bool val_2 = ErrorHandlerMessage.ReportedStackTraces.Add(item:  stackTrace);
        val_30 = "unknown";
        val_31 = val_30;
        val_32 = val_30;
        if(NFUser.current != null)
        {
                NFUser val_4 = NFUser.current;
            val_31 = val_30;
            val_32 = val_30;
            if(val_4.loginUserInfo != null)
        {
                NFUser val_5 = NFUser.current;
            val_32 = val_5.loginUserInfo.account;
            NFUser val_7 = NFUser.current;
            val_31 = val_7.loginUserInfo.accountType;
        }
        
        }
        
        val_33 = null;
        val_33 = null;
        val_34 = DataStructs.UserDataDictionary.Settings;
        if(val_34 != null)
        {
                val_34 = DataStructs.UserDataDictionary.Settings;
            if(val_34 == null)
        {
                val_34 = 0;
        }
        
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Inequality(a:  val_34.UserName, b:  0)) != false)
        {
                val_35 = null;
            val_35 = null;
            val_30 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName);
        }
        
        }
        
        System.DateTime val_13 = System.DateTime.Now;
        System.TimeSpan val_15 = System.TimeZoneInfo.Local.GetUtcOffset(dateTime:  new System.DateTime() {dateData = val_13.dateData});
        char[] val_16 = new char[1];
        val_16[0] = '
        ';
        ErrorHandlerMessage val_18 = new ErrorHandlerMessage();
        if(val_18 != null)
        {
                .account = val_32;
            .accountType = val_31;
            .displayUserName = val_30;
            .logMessage = val_25;
        }
        else
        {
                mem[16] = val_32;
            mem[24] = val_31;
            mem[32] = val_30;
            mem[40] = val_25;
        }
        
        .stackTrace = stackTrace.Split(separator:  val_16);
        val_27 = logType.ToString();
        logType.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  0);
        .logType = val_27;
        .dateTime = ;
        UnityEngine.SceneManagement.Scene val_20 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        .sceneName = val_20.m_Handle.name;
        val_25 = UnityEngine.JsonUtility.ToJson(obj:  val_18);
        UnityEngine.Debug.Log(message:  "Log request body: "("Log request body: ") + val_25);
        val_28 = System.Text.Encoding.UTF8;
        return (System.Byte[])val_28;
    }
    private static ErrorHandlerMessage()
    {
        ErrorHandlerMessage.ReportedStackTraces = new System.Collections.Generic.HashSet<System.String>();
    }

}
