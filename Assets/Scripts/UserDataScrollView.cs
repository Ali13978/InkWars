using UnityEngine;
public class UserDataScrollView : MonoBehaviour
{
    // Fields
    public CharacterSelectScrollView characterSelection;
    private UserDataScrollViewItem template;
    private bool isAdventureMode;
    private System.Collections.Generic.List<UserDataScrollViewItem> items;
    
    // Methods
    private void OnEnable()
    {
        if(this.isAdventureMode != false)
        {
                this.InitAdventureModeRecords();
            return;
        }
        
        if(0 == this.characterSelection)
        {
                this.InitPlayerRecord();
            return;
        }
        
        this.InitCharacterRecords(cid:  this.characterSelection.selection);
        this.characterSelection.OnSelectionChanged.AddListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  public System.Void UserDataScrollView::InitCharacterRecords(CharacterNameID cid)));
    }
    private void OnDisable()
    {
        if(0 == this.characterSelection)
        {
                return;
        }
        
        this.characterSelection.OnSelectionChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<CharacterNameID>(object:  this, method:  public System.Void UserDataScrollView::InitCharacterRecords(CharacterNameID cid)));
    }
    public void Init()
    {
        if(this.isAdventureMode != false)
        {
                this.InitAdventureModeRecords();
            return;
        }
        
        if(0 == this.characterSelection)
        {
                this.InitPlayerRecord();
            return;
        }
        
        this.InitCharacterRecords(cid:  this.characterSelection.selection);
    }
    private string CalculateWinRate(int wins, int played)
    {
        float val_5 = 100f;
        float val_4 = (float)wins;
        val_4 = val_4 / (float)played;
        val_5 = val_4 * val_5;
        bool val_1 = System.Single.IsNaN(f:  val_5);
        return (string)0.ToString(format:  "0.0#")(0.ToString(format:  "0.0#")) + "%"("%");
    }
    public void InitAdventureModeRecords()
    {
        var val_42;
        var val_44;
        this.RemoveAllItems();
        val_44 = null;
        val_44 = null;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item1")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item1")), value:  DataStructs.UserDataDictionary.GameSave.GetUniqueGameModePlayed(mode:  1).Count.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = DataStructs.UserDataDictionary.Stats.BattlesNoPower;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item2")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item2")), value:  val_8.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_12 = DataStructs.UserDataDictionary.Stats.Biggest_Combo;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item3")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item3")), value:  val_12.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_16 = DataStructs.UserDataDictionary.Stats.Maximum_Chains;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item4")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item4")), value:  val_16.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_20 = DataStructs.UserDataDictionary.Stats.FiredStunner;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item5")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item5")), value:  val_20.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_24 = DataStructs.UserDataDictionary.Stats.FiredIron;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item6")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item6")), value:  val_24.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_28 = DataStructs.UserDataDictionary.Stats.FiredColorEraserBall;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item7")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item7")), value:  val_28.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_32 = DataStructs.UserDataDictionary.Stats.Ink_Sequences;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item8")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item8")), value:  val_32.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_36 = DataStructs.UserDataDictionary.Stats.MostInkBubbles;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item9")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item9")), value:  val_36.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_40 = DataStructs.UserDataDictionary.Stats.AverageShots;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Adv.Item10")(LanguageManager.GetText(key:  "LK.Profile.Adv.Item10")), value:  val_42.ToString());
    }
    public void InitPlayerRecord()
    {
        var val_155;
        this.RemoveAllItems();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.NetworkWins;
        int val_155 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.NetworkLoses;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Stats.NetworkDraws;
        val_155 = ((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited})) + val_155) + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited}));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = DataStructs.UserDataDictionary.Stats.NetworkWins;
        int val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.currentCryptoKey, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, inited = val_8.inited});
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item1")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item1")), value:  val_9.CalculateWinRate(wins:  val_9, played:  val_155));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = DataStructs.UserDataDictionary.Stats.NetworkWins;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item2")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item2")), value:  System.String.Format(format:  "{0} / {1}", arg0:  val_15, arg1:  val_155));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_17 = DataStructs.UserDataDictionary.Stats.FastestVictory;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_17.currentCryptoKey, hiddenValue = val_17.hiddenValue, fakeValue = val_17.fakeValue, inited = val_17.inited})) == 2147483647)
        {
            
        }
        else
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_19 = DataStructs.UserDataDictionary.Stats.FastestVictory;
        }
        
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item3")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item3")), value:  System.String.Format(format:  "{0} sec", arg0:  val_19));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_25 = DataStructs.UserDataDictionary.Stats.WinStreak_Longest;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item4")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item4")), value:  val_25.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_29 = DataStructs.UserDataDictionary.Stats.MostBubblesRetained;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item5")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item5")), value:  val_29.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_33 = DataStructs.UserDataDictionary.Stats.InkingSequencesTriggered;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item6")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item6")), value:  val_33.currentCryptoKey.ToString());
        string val_36 = "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item7")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item7"));
        if(DataStructs.UserDataDictionary.Stats != null)
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_37 = DataStructs.UserDataDictionary.Stats.BeenInked;
            this.AddItem(title:  val_36, value:  val_37.currentCryptoKey.ToString());
        }
        else
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_39 = 0.BeenInked;
            this.AddItem(title:  val_36, value:  val_39.currentCryptoKey.ToString());
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_41 = DataStructs.UserDataDictionary.Stats.BiggestCombo_Ring;
        int val_42 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_41.currentCryptoKey, hiddenValue = val_41.hiddenValue, fakeValue = val_41.fakeValue, inited = val_41.inited});
        if(DataStructs.UserDataDictionary.Stats != null)
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_43 = DataStructs.UserDataDictionary.Stats.BiggestCombo_Cross;
            int val_44 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_43.currentCryptoKey, hiddenValue = val_43.hiddenValue, fakeValue = val_43.fakeValue, inited = val_43.inited});
        }
        else
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_45 = 0.BiggestCombo_Cross;
            int val_46 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_45.currentCryptoKey, hiddenValue = val_45.hiddenValue, fakeValue = val_45.fakeValue, inited = val_45.inited});
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_47 = DataStructs.UserDataDictionary.Stats.BiggestCombo_Bridge;
        int val_48 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_47.currentCryptoKey, hiddenValue = val_47.hiddenValue, fakeValue = val_47.fakeValue, inited = val_47.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_49 = DataStructs.UserDataDictionary.Stats.BiggestCombo_CrossBridge;
        int val_50 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_49.currentCryptoKey, hiddenValue = val_49.hiddenValue, fakeValue = val_49.fakeValue, inited = val_49.inited});
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item8")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item8")), value:  "");
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_55 = DataStructs.UserDataDictionary.Stats.BiggestCombo_Ring;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item9")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item9")), value:  val_55.currentCryptoKey.ToString() + " " + LanguageManager.GetText(key:  "LK.Profile.Hits")(LanguageManager.GetText(key:  "LK.Profile.Hits")));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_61 = DataStructs.UserDataDictionary.Stats.BiggestCombo_Cross;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item10")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item10")), value:  val_61.currentCryptoKey.ToString() + " " + LanguageManager.GetText(key:  "LK.Profile.Hits")(LanguageManager.GetText(key:  "LK.Profile.Hits")));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_67 = DataStructs.UserDataDictionary.Stats.BiggestCombo_Bridge;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item11")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item11")), value:  val_67.currentCryptoKey.ToString() + " " + LanguageManager.GetText(key:  "LK.Profile.Hits")(LanguageManager.GetText(key:  "LK.Profile.Hits")));
        if(DataStructs.UserDataDictionary.Stats != null)
        {
                val_155 = 0;
        }
        else
        {
                val_155 = 1;
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_73 = DataStructs.UserDataDictionary.Stats.BiggestCombo_CrossBridge;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item12")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item12")), value:  val_73.currentCryptoKey.ToString() + " " + LanguageManager.GetText(key:  "LK.Profile.Hits")(LanguageManager.GetText(key:  "LK.Profile.Hits")));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_77 = DataStructs.UserDataDictionary.Stats.Techniques_ReboundSave;
        int val_78 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_77.currentCryptoKey, hiddenValue = val_77.hiddenValue, fakeValue = val_77.fakeValue, inited = val_77.inited});
        if(DataStructs.UserDataDictionary.Stats != null)
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_79 = DataStructs.UserDataDictionary.Stats.Techniques_ReboundSuicide;
            int val_80 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_79.currentCryptoKey, hiddenValue = val_79.hiddenValue, fakeValue = val_79.fakeValue, inited = val_79.inited});
        }
        else
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_81 = 0.Techniques_ReboundSuicide;
            int val_82 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_81.currentCryptoKey, hiddenValue = val_81.hiddenValue, fakeValue = val_81.fakeValue, inited = val_81.inited});
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_83 = DataStructs.UserDataDictionary.Stats.Techniques_ReboundInterception;
        int val_84 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_83.currentCryptoKey, hiddenValue = val_83.hiddenValue, fakeValue = val_83.fakeValue, inited = val_83.inited});
        if(DataStructs.UserDataDictionary.Stats != null)
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_85 = DataStructs.UserDataDictionary.Stats.Techniques_ReboundCounter;
            int val_86 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_85.currentCryptoKey, hiddenValue = val_85.hiddenValue, fakeValue = val_85.fakeValue, inited = val_85.inited});
        }
        else
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_87 = 0.Techniques_ReboundCounter;
            int val_88 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_87.currentCryptoKey, hiddenValue = val_87.hiddenValue, fakeValue = val_87.fakeValue, inited = val_87.inited});
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_89 = DataStructs.UserDataDictionary.Stats.Techniques_BeenIntercepted;
        int val_90 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_89.currentCryptoKey, hiddenValue = val_89.hiddenValue, fakeValue = val_89.fakeValue, inited = val_89.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_91 = DataStructs.UserDataDictionary.Stats.Techniques_BeenCountered;
        int val_92 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_91.currentCryptoKey, hiddenValue = val_91.hiddenValue, fakeValue = val_91.fakeValue, inited = val_91.inited});
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item13")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item13")), value:  "");
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_97 = DataStructs.UserDataDictionary.Stats.Techniques_ReboundSave;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item14")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item14")), value:  val_97.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_101 = DataStructs.UserDataDictionary.Stats.Techniques_ReboundSuicide;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item15")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item15")), value:  val_101.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_105 = DataStructs.UserDataDictionary.Stats.Techniques_ReboundInterception;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item16")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item16")), value:  val_105.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_109 = DataStructs.UserDataDictionary.Stats.Techniques_ReboundCounter;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item17")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item17")), value:  val_109.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_113 = DataStructs.UserDataDictionary.Stats.Techniques_BeenIntercepted;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item18")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item18")), value:  val_113.currentCryptoKey.ToString());
        string val_116 = "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item19")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item19"));
        if(DataStructs.UserDataDictionary.Stats != null)
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_117 = DataStructs.UserDataDictionary.Stats.Techniques_BeenCountered;
            this.AddItem(title:  val_116, value:  val_117.currentCryptoKey.ToString());
        }
        else
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_119 = 0.Techniques_BeenCountered;
            this.AddItem(title:  val_116, value:  val_119.currentCryptoKey.ToString());
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_121 = DataStructs.UserDataDictionary.Stats.SuperBubbleShot_Stunner;
        int val_122 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_121.currentCryptoKey, hiddenValue = val_121.hiddenValue, fakeValue = val_121.fakeValue, inited = val_121.inited});
        if(DataStructs.UserDataDictionary.Stats != null)
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_123 = DataStructs.UserDataDictionary.Stats.SuperBubbleShot_CannonBall;
            int val_124 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_123.currentCryptoKey, hiddenValue = val_123.hiddenValue, fakeValue = val_123.fakeValue, inited = val_123.inited});
        }
        else
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_125 = 0.SuperBubbleShot_CannonBall;
            int val_126 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_125.currentCryptoKey, hiddenValue = val_125.hiddenValue, fakeValue = val_125.fakeValue, inited = val_125.inited});
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_127 = DataStructs.UserDataDictionary.Stats.SuperBubbleShot_Eraser;
        int val_128 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_127.currentCryptoKey, hiddenValue = val_127.hiddenValue, fakeValue = val_127.fakeValue, inited = val_127.inited});
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item20")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item20")), value:  "");
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_133 = DataStructs.UserDataDictionary.Stats.SuperBubbleShot_Stunner;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item21")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item21")), value:  val_133.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_137 = DataStructs.UserDataDictionary.Stats.SuperBubbleShot_CannonBall;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item22")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item22")), value:  val_137.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_141 = DataStructs.UserDataDictionary.Stats.SuperBubbleShot_RainbowTransformer;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.BUBBLE.RAINBOW_TRANSFOEMER")(LanguageManager.GetText(key:  "LK.BUBBLE.RAINBOW_TRANSFOEMER")), value:  val_141.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_145 = DataStructs.UserDataDictionary.Stats.SuperBubbleShot_Virus;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.BUBBLE.VIRUS")(LanguageManager.GetText(key:  "LK.BUBBLE.VIRUS")), value:  val_145.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_149 = DataStructs.UserDataDictionary.Stats.SuperBubbleShot_Eraser;
        this.AddItem(title:  "     \t• " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item23")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item23")), value:  val_149.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_153 = DataStructs.UserDataDictionary.Stats.StunBreaks;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.RankVS.Item24")(LanguageManager.GetText(key:  "LK.Profile.RankVS.Item24")), value:  val_153.currentCryptoKey.ToString());
    }
    public void InitCharacterRecords(CharacterNameID cid)
    {
        var val_30;
        DataStructs.PlayerRank val_31;
        this.RemoveAllItems();
        val_30 = null;
        val_30 = null;
        DataStructs.CharacterStats val_1 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  cid);
        DataStructs.CharacterStats val_2 = DataStructs.UserDataDictionary.Stats.GetCharacterPVPStats(cid:  cid);
        UserDataScrollViewItem val_3 = this.CreateItem();
        if(val_2.BPRank != 0)
        {
                val_31 = val_2.BPRank;
        }
        else
        {
                val_31 = 1;
        }
        
        UserDataScrollViewItem val_9 = val_3.SetupImage(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Char.Item1")(LanguageManager.GetText(key:  "LK.Profile.Char.Item1")), sprite:  RankingCollection.GetRankSprite(rank:  val_31));
        this.items.Add(item:  val_3);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_12 = val_2.Bp;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Char.Item2")(LanguageManager.GetText(key:  "LK.Profile.Char.Item2")), value:  val_12.currentCryptoKey.ToString());
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_16 = val_1.Win;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_18 = val_1.TotalMatchPlayed;
        int val_19 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_18.currentCryptoKey, hiddenValue = val_18.hiddenValue, fakeValue = val_18.fakeValue, inited = val_18.inited});
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Char.Item3")(LanguageManager.GetText(key:  "LK.Profile.Char.Item3")), value:  val_19.CalculateWinRate(wins:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16.currentCryptoKey, hiddenValue = val_16.hiddenValue, fakeValue = val_16.fakeValue, inited = val_16.inited}), played:  val_19));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_23 = val_1.Win;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_24 = val_1.TotalMatchPlayed;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Char.Item4")(LanguageManager.GetText(key:  "LK.Profile.Char.Item4")), value:  System.String.Format(format:  "{0} / {1}", arg0:  val_23, arg1:  val_24));
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_28 = val_1.WinStreakLongest;
        this.AddItem(title:  "  • " + LanguageManager.GetText(key:  "LK.Profile.Char.Item5")(LanguageManager.GetText(key:  "LK.Profile.Char.Item5")), value:  val_28.currentCryptoKey.ToString());
    }
    private void RemoveAllItems()
    {
        List.Enumerator<T> val_1 = this.items.GetEnumerator();
        label_6:
        if(((-1300897720) & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Object.Destroy(obj:  0.InitialType.gameObject);
        goto label_6;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UserDataScrollViewItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
        this.items.Clear();
    }
    public void AddItem(string title, string value)
    {
        UserDataScrollViewItem val_1 = this.CreateItem();
        UserDataScrollViewItem val_2 = val_1.Setup(title:  title, value:  value);
        this.items.Add(item:  val_1);
    }
    private UserDataScrollViewItem CreateItem()
    {
        UserDataScrollViewItem val_3 = UnityEngine.Object.Instantiate<UserDataScrollViewItem>(original:  this.template, parent:  this.template.transform.parent);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        val_3.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        val_3.gameObject.SetActive(value:  true);
        return val_3;
    }
    private void RefreshBottomLine()
    {
        var val_8;
        var val_9;
        val_8 = this;
        List.Enumerator<T> val_1 = this.items.GetEnumerator();
        label_4:
        if(((-1300431656) & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.ShowBottomLine(show:  true);
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UserDataScrollViewItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
        if(this.items.Count < 1)
        {
                return;
        }
        
        if(this.items != null)
        {
                val_9 = this.items.Count;
        }
        else
        {
                val_9 = 0.Count;
        }
        
        val_8 = this.items.Item[val_9 - 1];
        val_8.ShowBottomLine(show:  false);
    }
    public UserDataScrollView()
    {
        this.items = new System.Collections.Generic.List<UserDataScrollViewItem>();
    }

}
