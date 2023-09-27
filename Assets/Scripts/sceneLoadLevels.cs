using UnityEngine;
public class sceneLoadLevels : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Button[] stageButton;
    public UnityEngine.GameObject modePanel;
    
    // Methods
    private void Awake()
    {
        var val_16;
        var val_17;
        var val_18;
        int val_19;
        val_16 = null;
        val_16 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  0).NormalMode.IsPlayable;
        val_4.fakeValue = val_4.fakeValue & 4294967295;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue})) != true)
        {
                val_17 = null;
            val_17 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  0).NormalMode.IsPlayable = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue & 4294967295, fakeValueChanged = val_9.fakeValue & 4294967295, inited = val_9.fakeValue & 4294967295};
        }
        
        var val_17 = 0;
        do
        {
            val_18 = null;
            val_18 = null;
            DataStructs.GameLevel val_12 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  0);
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = val_12.InkPercentage;
            val_19 = val_13.fakeValue;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13.currentCryptoKey, hiddenValue = val_13.hiddenValue, fakeValue = val_19, inited = val_13.inited})) < 80)
        {
                CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  80);
            val_19 = val_15.fakeValue;
            val_12.InkPercentage = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_19, inited = val_15.inited};
        }
        
            val_17 = val_17 + 1;
            var val_16 = 80 - 10;
        }
        while(val_17 != 4);
    
    }
    private void Start()
    {
        var val_2;
        GameAudio.SwitchMusic(musicId:  0, forcePlay:  false);
        this.modePanel.SetActive(value:  false);
        this.StageStatus();
        val_2 = null;
        val_2 = null;
        bool val_1 = DataStructs.UserDataDictionary.GameSave.IsRateUsClicked;
        if(val_1 != false)
        {
                return;
        }
        
        val_1.CheckForRateUs();
    }
    private void StageStatus()
    {
        var val_69;
        var val_70;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_81;
        var val_81 = 0;
        val_69 = 0;
        label_194:
        val_70 = null;
        val_70 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  0).NormalMode.IsPlayable;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = false, fakeValueChanged = true, inited = true})) == false)
        {
            goto label_126;
        }
        
        if(val_81 == 11)
        {
                this.stageButton[11].gameObject.GetComponent<UnityEngine.Animator>().enabled = true;
        }
        
        this.stageButton[val_81].interactable = true;
        this.stageButton[val_81].gameObject.transform.GetChild(index:  0).gameObject.SetActive(value:  false);
        System.Collections.IEnumerator val_13 = this.stageButton[val_81].transform.GetEnumerator();
        label_83:
        var val_78 = 0;
        val_78 = val_78 + 1;
        if(val_13.MoveNext() == false)
        {
            goto label_35;
        }
        
        var val_79 = 0;
        val_79 = val_79 + 1;
        val_73 = val_13.Current;
        if(val_73 != null)
        {
                val_73 = 0;
        }
        
        if(val_81 <= 10)
        {
                if((System.String.op_Equality(a:  val_73.name, b:  "1")) == true)
        {
            goto label_46;
        }
        
        }
        
        if((System.String.op_Equality(a:  val_73.name, b:  "2")) == true)
        {
            goto label_48;
        }
        
        if((System.String.op_Equality(a:  val_73.name, b:  "3")) == false)
        {
            goto label_83;
        }
        
        val_74 = null;
        val_74 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_29 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  0).ExBattleMode.IsPlayable;
        val_73.gameObject.SetActive(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_29.currentCryptoKey, hiddenValue = val_29.hiddenValue, fakeValue = true, fakeValueChanged = true, inited = true}));
        goto label_83;
        label_48:
        val_75 = null;
        val_75 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_36 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  0).NormalMode.IsPlayable;
        val_73.gameObject.SetActive(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_36.currentCryptoKey, hiddenValue = val_36.hiddenValue, fakeValue = true, fakeValueChanged = true, inited = true}));
        goto label_83;
        label_46:
        val_76 = null;
        val_76 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_43 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  0).PuzzleMode.IsPlayable;
        val_73.gameObject.SetActive(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_43.currentCryptoKey, hiddenValue = val_43.hiddenValue, fakeValue = true, fakeValueChanged = true, inited = true}));
        goto label_83;
        label_35:
        val_69 = val_69 + 1;
        val_77 = 0;
        mem2[0] = 595;
        if(val_13 != null)
        {
                var val_80 = 0;
            val_80 = val_80 + 1;
            val_13.Dispose();
        }
        
        if(val_69 != 1)
        {
                if((-1582210608 + ((val_69 + 1)) << 2) == 595)
        {
            goto label_127;
        }
        
        }
        
        label_126:
        if(val_81 > 0)
        {
            goto label_128;
        }
        
        val_81 = val_81 + 1;
        goto label_194;
        label_128:
        val_81 = null;
        val_81 = null;
        int val_49 = val_81 - 1;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_52 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetGameLevel(key:  val_49).NormalMode.IsPlayable;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_52.currentCryptoKey, hiddenValue = val_52.hiddenValue, fakeValue = true, fakeValueChanged = true, inited = true})) != false)
        {
                this.stageButton[val_49].gameObject.GetComponent<UnityEngine.Animator>().enabled = true;
        }
        
        System.Collections.IEnumerator val_57 = this.stageButton[val_81].transform.GetEnumerator();
        goto label_164;
        label_171:
        var val_84 = 0;
        val_84 = val_84 + 1;
        object val_59 = val_57.Current;
        if((System.String.op_Equality(a:  0.name, b:  "1")) != true)
        {
                if((System.String.op_Equality(a:  0.name, b:  "2")) != true)
        {
                if((System.String.op_Equality(a:  0.name, b:  "3")) == false)
        {
            goto label_164;
        }
        
        }
        
        }
        
        0.gameObject.SetActive(value:  false);
        label_164:
        var val_85 = 0;
        val_85 = val_85 + 1;
        if(val_57.MoveNext() == true)
        {
            goto label_171;
        }
        
        val_77 = 0;
        val_69 = val_69 + 1;
        mem2[0] = 595;
        goto label_172;
        label_127:
        var val_86 = 0;
        val_86 = val_86 ^ (val_69 >> 31);
        val_69 = val_69 + val_86;
        goto label_193;
        label_172:
        if(val_13 != null)
        {
                var val_87 = 0;
            val_87 = val_87 + 1;
            val_13.Dispose();
        }
        
        if(val_69 != 1)
        {
                var val_72 = ((-1582210608 + (((val_69 + 1) + (0 ^ ((int)(val_69 + 1)) >> 31))) << 2) == 595) ? 1 : 0;
            val_72 = ((val_69 >= 0) ? 1 : 0) & val_72;
            val_69 = val_69 - val_72;
        }
        
        label_193:
        val_81 = val_81 + 1;
        if(val_81 < 11)
        {
            goto label_194;
        }
    
    }
    public void onTutorialButtonClicked()
    {
        GameAudio.PlayButtonSound();
        YesNoDialog val_4 = YesNoDialog.Show(title:  LanguageManager.GetText(key:  "LK.ReplayTutorial"), msg:  "", yesAction:  new System.Action(object:  this, method:  public System.Void sceneLoadLevels::onReplayTutorialYes()), noAction:  new System.Action(object:  0, method:  public static System.Void GameAudio::PlayButtonSound()));
    }
    public void onReplayTutorialYes()
    {
        GameAudio.PlayButtonSound();
        TutorialDataManager.LoadBasicTutorial(nextScene:  "Scene_LoadLevels", showLoadingScreen:  true, selectionHand:  false, preload:  false);
    }
    public void buttonRateUs()
    {
        null = null;
        DataStructs.UserDataDictionary.GameSave.IsRateUsClicked = true;
        UnityEngine.Application.OpenURL(url:  "https://play.google.com/store/apps/details?id=com.mediahive.inkwars");
        GameAudio.PlayButtonSound();
    }
    public void buttonMayBeLater()
    {
        GameAudio.PlayButtonSound();
    }
    private void CheckForRateUs()
    {
        var val_8;
        var val_9;
        var val_10;
        DataStructs.GameSave val_11;
        var val_12;
        var val_13;
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.DayPassedSinceSignUp;
        int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
        if(DataStructs.UserDataDictionary.GameSave.IsRateUsShown != false)
        {
                val_9 = null;
            val_9 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.GameSave.LastRateUpDaySinceSignUp;
            if((val_2 - (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited}))) < 2)
        {
                return;
        }
        
            val_10 = null;
            val_10 = null;
            val_11 = DataStructs.UserDataDictionary.GameSave;
            val_12 = null;
        }
        else
        {
                if(val_2 < 5)
        {
                return;
        }
        
            val_13 = null;
            val_13 = null;
            DataStructs.UserDataDictionary.GameSave.IsRateUsShown = true;
            val_12 = null;
            val_11 = DataStructs.UserDataDictionary.GameSave;
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_2);
        val_11.LastRateUpDaySinceSignUp = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited};
    }
    private void OnLevelButton(int level)
    {
        GameAudio.PlayButtonSound();
        Character_GlobalInfo.stage_CurrentLevel = level;
        this.modePanel.SetActive(value:  true);
    }
    public void Button_Level1()
    {
        this.OnLevelButton(level:  1);
    }
    public void Button_Level2()
    {
        this.OnLevelButton(level:  2);
    }
    public void Button_Level3()
    {
        this.OnLevelButton(level:  3);
    }
    public void Button_Level4()
    {
        this.OnLevelButton(level:  4);
    }
    public void Button_Level5()
    {
        this.OnLevelButton(level:  5);
    }
    public void Button_Level6()
    {
        this.OnLevelButton(level:  6);
    }
    public void Button_Level7()
    {
        this.OnLevelButton(level:  7);
    }
    public void Button_Level8()
    {
        this.OnLevelButton(level:  8);
    }
    public void Button_Level9()
    {
        this.OnLevelButton(level:  9);
    }
    public void Button_Level10()
    {
        this.OnLevelButton(level:  10);
    }
    public void Button_Level11()
    {
        this.OnLevelButton(level:  11);
    }
    public void Button_Level12()
    {
        this.OnLevelButton(level:  12);
    }
    public void back()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
    }
    public void ShowPowerUpExpressPurchase()
    {
        DynamicUISingleton<ExpressPowerBallPurchaseCanvas>.Show();
    }
    public sceneLoadLevels()
    {
    
    }

}
