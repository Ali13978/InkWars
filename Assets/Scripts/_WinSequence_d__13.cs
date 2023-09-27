using UnityEngine;
private sealed class View_PostMatch.<WinSequence>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_PostMatch <>4__this;
    public int finalScore;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_PostMatch.<WinSequence>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterNameID val_50;
        View_PostMatch val_59;
        byte val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        int val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        CharacterAssetLoader val_75;
        int val_76;
        val_59 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.WinPanel_Score.enabled = true;
        this.<>4__this.WinPanel_YouveCrackedThePuzzle.enabled = false;
        string val_2 = System.String.Format(format:  "{0:00000}", arg0:  this.finalScore.ToString());
        val_60 = Character_GlobalInfo.stage_CurrentLevel;
        int val_4 = val_60 - 1;
        if(Character_GlobalInfo.gameMode == 1)
        {
            goto label_9;
        }
        
        if(Character_GlobalInfo.gameMode == 4)
        {
            goto label_10;
        }
        
        if(Character_GlobalInfo.gameMode != 3)
        {
            goto label_67;
        }
        
        this.<>4__this.WinPanel_Score.enabled = false;
        this.<>4__this.WinPanel_YouveCrackedThePuzzle.enabled = true;
        val_61 = null;
        val_61 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        val_60 = val_8.currentCryptoKey;
        DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  val_4).PuzzleMode.Passed = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_60, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue & 4294967295, fakeValueChanged = val_8.fakeValue & 4294967295, inited = val_8.fakeValue & 4294967295};
        val_62 = 3;
        goto label_22;
        label_1:
        this.<>1__state = 0;
        if(val_59 != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_9:
        if(val_4 != 11)
        {
                val_63 = null;
            val_63 = null;
            if((DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetPassedLevelCount(mode:  0)) < val_60)
        {
                val_64 = null;
            val_64 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  val_4).PuzzleMode.IsPlayable = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_15.fakeValue & 4294967295, fakeValueChanged = val_15.fakeValue & 4294967295, inited = val_15.fakeValue & 4294967295};
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  val_60).NormalMode.IsPlayable = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_20.currentCryptoKey, hiddenValue = val_20.hiddenValue, fakeValue = val_20.fakeValue & 4294967295, fakeValueChanged = val_20.fakeValue & 4294967295, inited = val_20.fakeValue & 4294967295};
        }
        
        }
        
        val_65 = null;
        val_65 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_25 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  val_4).NormalMode.Passed = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_25.currentCryptoKey, hiddenValue = val_25.hiddenValue, fakeValue = val_25.fakeValue & 4294967295, fakeValueChanged = val_25.fakeValue & 4294967295, inited = val_25.fakeValue & 4294967295};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_30 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  View_Core.InkEmUp_BubblesTotal);
        val_66 = val_30.currentCryptoKey;
        DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData().InkPercentage = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_66, hiddenValue = val_30.hiddenValue, fakeValue = val_30.fakeValue, inited = val_30.inited};
        if(View_Core.InkEmUp_BubblesTotal == 100)
        {
                val_67 = null;
            val_67 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_35 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            val_66 = val_35.currentCryptoKey;
            DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  val_4).ExBattleMode.IsPlayable = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_66, hiddenValue = val_35.hiddenValue, fakeValue = val_35.fakeValue & 4294967295, fakeValueChanged = val_35.fakeValue & 4294967295, inited = val_35.fakeValue & 4294967295};
        }
        
        if(val_4 <= 4)
        {
            goto label_65;
        }
        
        if(val_4 <= 8)
        {
            goto label_66;
        }
        
        if(val_4 > 11)
        {
            goto label_67;
        }
        
        val_68 = 3000;
        val_69 = 40000;
        val_70 = 42000;
        goto label_68;
        label_10:
        val_71 = null;
        val_71 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_40 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        val_60 = val_40.currentCryptoKey;
        DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  val_4).ExBattleMode.Passed = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_60, hiddenValue = val_40.hiddenValue, fakeValue = val_40.fakeValue & 4294967295, fakeValueChanged = val_40.fakeValue & 4294967295, inited = val_40.fakeValue & 4294967295};
        label_67:
        val_62 = 1;
        label_22:
        val_72 = 15000;
        val_73 = 18000;
        goto label_77;
        label_65:
        val_69 = 25000;
        val_70 = 29000;
        val_74 = val_4 * 1000;
        goto label_78;
        label_66:
        val_68 = 2000;
        val_69 = 31000;
        val_70 = 34000;
        label_68:
        val_74 = val_60 * 2000;
        label_78:
        val_72 = 31000 - val_74;
        val_73 = 34000 - val_74;
        val_62 = 1;
        label_77:
        var val_43 = (this.finalScore < val_73) ? ((this.finalScore < val_72) ? (val_62) : 2) : 3;
        this.<>4__this.WinPanel_Stars[0].gameObject.SetActive(value:  true);
        this.<>4__this.WinPanel_Stars[1].gameObject.SetActive(value:  (val_43 > 1) ? 1 : 0);
        this.<>4__this.WinPanel_Stars[2].gameObject.SetActive(value:  (val_43 == 3) ? 1 : 0);
        CharacterInfo val_49 = Character_GlobalInfo.GetLeftPlayer();
        UnityEngine.Coroutine val_52 = val_59.StartCoroutine(routine:  this.<>4__this.assetLoader.RetrieveBundle(inputCharID:  val_50, callback:  0));
        label_24:
        val_75 = this.<>4__this.assetLoader;
        if((this.<>4__this.assetLoader.ready) == false)
        {
            goto label_95;
        }
        
        val_75 = this.<>4__this.assetLoader.LoadPose_Dynamic();
        this.<>4__this.WinPanel_Dynamic.sprite = val_75;
        val_59 = this.<>4__this.WinPanel.gameObject;
        val_59.SetActive(value:  true);
        label_2:
        val_76 = 0;
        return (bool)val_76;
        label_95:
        val_76 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_76;
        return (bool)val_76;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
