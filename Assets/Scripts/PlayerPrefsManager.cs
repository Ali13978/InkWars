using UnityEngine;
public class PlayerPrefsManager : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.InputField IF_PlayerName;
    public UnityEngine.UI.InputField IF_Wins;
    public UnityEngine.UI.InputField IF_Loses;
    public UnityEngine.UI.InputField IF_Draws;
    public UnityEngine.UI.InputField IF_Shells;
    public UnityEngine.UI.InputField IF_Pearls;
    private static long <Player2Wins>k__BackingField;
    private static int <Player2Loses>k__BackingField;
    private static int <Player2Draws>k__BackingField;
    
    // Properties
    public static string PlayerName { get; set; }
    public static string Player2Name { get; set; }
    public static long Player2Wins { get; set; }
    public static int Player2Loses { get; set; }
    public static int Player2Draws { get; set; }
    public static int OnlinePVPTime { get; set; }
    public static int LocalPVPTime { get; set; }
    public static int Shells { get; set; }
    public static int Player2Shells { get; set; }
    public static int Pearls { get; set; }
    public static int LanMusicIndex { get; set; }
    public static string LastIPUsed { get; set; }
    
    // Methods
    private void Awake()
    {
        var val_12;
        this.IF_PlayerName.text = PlayerPrefsManager.PlayerName;
        val_12 = null;
        val_12 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Stats.TotalPVPWins;
        this.IF_Wins.text = val_2.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Stats.TotalPVPLosses;
        this.IF_Loses.text = val_4.currentCryptoKey.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Stats.TotalPVPDraws;
        this.IF_Draws.text = val_6.currentCryptoKey.ToString();
        this.IF_Shells.text = PlayerPrefsManager.Shells.ToString();
        this.IF_Pearls.text = PlayerPrefsManager.Pearls.ToString();
    }
    public void Finish()
    {
        PlayerPrefsManager.PlayerName = this.IF_PlayerName.text;
        PlayerPrefsManager.Shells = System.Int32.Parse(s:  this.IF_Shells.text);
        PlayerPrefsManager.Pearls = System.Int32.Parse(s:  this.IF_Pearls.text);
        UnityEngine.SceneManagement.Scene val_6 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex:  val_6.m_Handle.buildIndex);
    }
    public static string get_PlayerName()
    {
        null = null;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName);
    }
    public static void set_PlayerName(string value)
    {
        null = null;
        DataStructs.UserDataDictionary.Settings.UserName = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  value);
    }
    public static string get_Player2Name()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  "ChallengerName", defaultValue:  "");
    }
    public static void set_Player2Name(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  "ChallengerName", value:  value);
    }
    public static long get_Player2Wins()
    {
        return (long)PlayerPrefsManager.<Player2Wins>k__BackingField;
    }
    public static void set_Player2Wins(long value)
    {
        PlayerPrefsManager.<Player2Wins>k__BackingField = value;
    }
    public static int get_Player2Loses()
    {
        return (int)PlayerPrefsManager.<Player2Loses>k__BackingField;
    }
    public static void set_Player2Loses(int value)
    {
        PlayerPrefsManager.<Player2Loses>k__BackingField = value;
    }
    public static int get_Player2Draws()
    {
        return (int)PlayerPrefsManager.<Player2Draws>k__BackingField;
    }
    public static void set_Player2Draws(int value)
    {
        PlayerPrefsManager.<Player2Draws>k__BackingField = value;
    }
    public static int get_OnlinePVPTime()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedGameDuration;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    public static void set_OnlinePVPTime(int value)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  value);
        DataStructs.UserDataDictionary.Settings.SelectedGameDuration = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        val_3 = null;
        val_3 = null;
        Character_GlobalInfo.gameDuration = value;
    }
    public static int get_LocalPVPTime()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedGameDuration;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    public static void set_LocalPVPTime(int value)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  value);
        DataStructs.UserDataDictionary.Settings.SelectedGameDuration = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        val_3 = null;
        val_3 = null;
        Character_GlobalInfo.gameDuration = value;
    }
    public static int get_Shells()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Shells;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    public static void set_Shells(int value)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  value);
        DataStructs.UserDataDictionary.Items.Shells = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
    }
    public static int get_Player2Shells()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  "Player2Shells", defaultValue:  10);
    }
    public static void set_Player2Shells(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "Player2Shells", value:  value);
    }
    public static int get_Pearls()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Pearls;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    public static void set_Pearls(int value)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  value);
        DataStructs.UserDataDictionary.Items.Pearls = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
    }
    public static int get_LanMusicIndex()
    {
        null = null;
        if(DataStructs.UserDataDictionary.Settings != null)
        {
                return DataStructs.UserDataDictionary.Settings.LanMusicIndex;
        }
        
        return DataStructs.UserDataDictionary.Settings.LanMusicIndex;
    }
    public static void set_LanMusicIndex(int value)
    {
        null = null;
        DataStructs.UserDataDictionary.Settings.LanMusicIndex = value;
    }
    public static string get_LastIPUsed()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  "LastIPUsed", defaultValue:  "");
    }
    public static void set_LastIPUsed(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  "LastIPUsed", value:  value);
    }
    public static string GetShellString(int shells)
    {
        return (string)shells.ToString();
    }
    public PlayerPrefsManager()
    {
    
    }

}
