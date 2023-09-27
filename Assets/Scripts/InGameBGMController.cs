using UnityEngine;
public class InGameBGMController : MonoBehaviour
{
    // Fields
    public MusicTitlePopup musicTitleTemplate;
    private MusicTitlePopup musicTitlePopup;
    private static InGameBGMController instance;
    
    // Methods
    public static void SetupBGM()
    {
        if(0 != InGameBGMController.instance)
        {
                InGameBGMController.instance.SetBGM();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "InGameBGMController not exist");
    }
    private void Awake()
    {
        var val_2;
        GameMode val_3;
        InGameBGMController.instance = this;
        this.musicTitlePopup = UnityEngine.Object.Instantiate<MusicTitlePopup>(original:  this.musicTitleTemplate);
        val_2 = null;
        val_2 = null;
        val_3 = Character_GlobalInfo.gameMode;
        if(val_3 == 6)
        {
                return;
        }
        
        val_3 = Character_GlobalInfo.gameMode;
        if(val_3 == 10)
        {
                return;
        }
        
        this.SetBGM();
    }
    private void SetBGM()
    {
        var val_30;
        var val_52;
        var val_53;
        GameMode val_54;
        int val_55;
        var val_56;
        var val_57;
        var val_58;
        string val_59;
        int val_61;
        var val_62;
        var val_63;
        var val_64;
        int val_65;
        var val_66;
        var val_68;
        val_52 = null;
        val_52 = null;
        int val_1 = GameInfo.music.GetRandomDefaultIds();
        val_53 = null;
        val_53 = null;
        val_54 = Character_GlobalInfo.gameMode;
        if(val_54 != 3)
        {
            goto label_6;
        }
        
        val_55 = 846528512;
        val_55 = 12917;
        goto label_146;
        label_6:
        val_53 = null;
        val_54 = Character_GlobalInfo.gameMode;
        if(val_54 != 5)
        {
            goto label_10;
        }
        
        val_56 = null;
        val_56 = null;
        System.Collections.Generic.List<System.Int32> val_2 = GameInfo.music.GetAllRandomBGMIds();
        val_55 = val_2.Item[UnityEngine.Random.Range(min:  0, max:  val_2.Count)];
        goto label_146;
        label_10:
        val_53 = null;
        val_54 = Character_GlobalInfo.gameMode;
        if(val_54 == 6)
        {
            goto label_19;
        }
        
        val_53 = null;
        val_54 = Character_GlobalInfo.gameMode;
        if(val_54 != 10)
        {
            goto label_22;
        }
        
        label_19:
        if(0 == InkWars.Model.MVC_Multiplayer_Manager_Base.Instance)
        {
            goto label_27;
        }
        
        val_57 = null;
        val_57 = null;
        val_58 = null;
        val_58 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = DataStructs.UserDataDictionary.Settings.SelectedMusicTrack;
        MusicData val_10 = GameInfo.music.GetItemDataById(uniqueId:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.currentCryptoKey, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, inited = val_8.inited}));
        NetworkUserInfo val_11 = CloudOpponent.current;
        MusicData val_12 = GameInfo.music.GetItemDataById(uniqueId:  val_11.musicID);
        object[] val_13 = new object[1];
        if(val_10 == null)
        {
            goto label_38;
        }
        
        string val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  X24);
        if(val_13 != null)
        {
            goto label_101;
        }
        
        label_102:
        label_101:
        val_13[0] = val_14;
        UnityEngine.Debug.LogFormat(format:  "Player1 BGM {0}", args:  val_13);
        object[] val_15 = new object[1];
        val_59 = "Player2 BGM {0}";
        if(val_12 == null)
        {
            goto label_47;
        }
        
        if(val_15 != null)
        {
            goto label_103;
        }
        
        label_104:
        label_103:
        val_15[0] = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_14);
        UnityEngine.Debug.LogFormat(format:  val_59, args:  val_15);
        if((val_10 == null) || (val_12 == null))
        {
            goto label_57;
        }
        
        object[] val_17 = new object[4];
        val_17[0] = val_59;
        val_17[1] = val_17.Length;
        val_17[2] = val_17.Length;
        val_17[3] = val_17.Length;
        UnityEngine.Debug.LogFormat(format:  ">>>> BACKGROUND_MUSIC - {0}({1})::{2}({3})", args:  val_17);
        int val_18 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = -1893142896, hiddenValue = 268435461, fakeValue = -1893134672, inited = true});
        int val_19 = (val_18 != 0) ? 1 : 0;
        int val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, fakeValue = -1893134672, inited = true});
        var val_22 = (val_20 != 0) ? 1 : 0;
        if((val_20 | val_18) == 0)
        {
            goto label_76;
        }
        
        val_22 = val_19 & val_22;
        if(val_22 != 0)
        {
            goto label_76;
        }
        
        if((val_20 != 0) || (val_18 == 0))
        {
            goto label_123;
        }
        
        val_61 = val_12;
        goto label_81;
        label_27:
        val_55 = PlayerPrefsManager.LanMusicIndex;
        goto label_146;
        label_22:
        val_53 = null;
        val_54 = Character_GlobalInfo.gameMode;
        if(val_54 != 4)
        {
            goto label_85;
        }
        
        val_55 = 359464960;
        val_55 = 5485;
        goto label_146;
        label_57:
        if((val_10 | val_12) == null)
        {
            goto label_87;
        }
        
        var val_25 = (val_10 != 0) ? (val_10) : (val_12);
        val_55 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10 != null ? val_10 : val_12 + 40, hiddenValue = val_10 != null ? val_10 : val_12 + 40, fakeValue = val_10 != null ? val_10 : val_12 + 40 + 8, inited = val_10 != null ? val_10 : val_12 + 40 + 8});
        object[] val_27 = new object[2];
        val_27[0] = (val_10 != 0) ? "Player 1" : "Player 2";
        val_59 = val_55;
        val_27[1] = val_59;
        UnityEngine.Debug.LogFormat(format:  "Only find music data for {0}, play {1}", args:  val_27);
        goto label_146;
        label_38:
        if(val_13 != null)
        {
            goto label_101;
        }
        
        goto label_102;
        label_47:
        if(val_15 != null)
        {
            goto label_103;
        }
        
        goto label_104;
        label_85:
        CharacterInfo val_29 = Character_GlobalInfo.GetMainPlayer();
        if(val_30 != 1)
        {
            goto label_107;
        }
        
        if((Character_GlobalInfo.stage_CurrentLevel - 1) < 4)
        {
            goto label_110;
        }
        
        if((Character_GlobalInfo.stage_CurrentLevel - 1) < 8)
        {
            goto label_113;
        }
        
        int val_36 = Character_GlobalInfo.stage_CurrentLevel - 1;
        val_62 = 927268864;
        val_62 = 14149;
        val_63 = 607649792;
        val_63 = 9272;
        goto label_116;
        label_87:
        val_64 = null;
        val_64 = null;
        if(GameInfo.music == null)
        {
            goto label_119;
        }
        
        val_65 = GameInfo.music.GetRandomDefaultIds();
        goto label_120;
        label_76:
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_19, hiddenValue = val_19, fakeValue = val_18, inited = val_18})) <= (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, hiddenValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.__il2cppRuntimeField_cctor_finished, fakeValue = val_18, inited = val_18})))
        {
            goto label_123;
        }
        
        val_66 = null;
        goto label_127;
        label_123:
        val_66 = null;
        label_127:
        val_61 = val_18;
        label_81:
        val_55 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_61, hiddenValue = val_61, fakeValue = val_10, inited = val_10});
        goto label_146;
        label_107:
        if((Character_GlobalInfo.stage_CurrentLevel - 1) < 4)
        {
            goto label_131;
        }
        
        if((Character_GlobalInfo.stage_CurrentLevel - 1) < 8)
        {
            goto label_134;
        }
        
        val_62 = 356188160;
        val_62 = 5435;
        val_63 = 301662208;
        val_63 = 4603;
        label_116:
        var val_47 = ((Character_GlobalInfo.stage_CurrentLevel - 1) > 10) ? 301714136 : 356228526;
        goto label_146;
        label_119:
        val_65 = 0.GetRandomDefaultIds();
        label_120:
        val_55 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_65, hiddenValue = val_65, fakeValue = GameInfo.music.GetItemDataById(uniqueId:  val_65), inited = GameInfo.music.GetItemDataById(uniqueId:  val_65)});
        UnityEngine.Debug.Log(message:  "Cannot find music data from players, select a default one");
        goto label_146;
        label_110:
        val_55 = 217186304;
        val_55 = 3314;
        goto label_146;
        label_131:
        val_55 = 991494144;
        val_55 = 15129;
        goto label_146;
        label_113:
        val_55 = 488636416;
        val_55 = 7456;
        goto label_146;
        label_134:
        val_55 = 752156672;
        val_55 = 11477;
        label_146:
        GameAudio.SwitchMusic(musicId:  167, forcePlay:  true);
        val_68 = null;
        val_68 = null;
        this.musicTitlePopup.SetupMusicData(data:  GameInfo.music.GetItemDataById(uniqueId:  752217767));
    }
    public InGameBGMController()
    {
    
    }

}
