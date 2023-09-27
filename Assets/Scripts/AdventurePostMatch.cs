using UnityEngine;
public class AdventurePostMatch
{
    // Methods
    public static void Show(bool isPlayerWin)
    {
        var val_1;
        if(isPlayerWin != false)
        {
                val_1 = 1152921528899405280;
        }
        else
        {
                val_1 = 1152921528899406304;
        }
        
        DynamicUISingleton<AdventureLosePostMatchCanvas>.Show();
    }
    public static void PlayAgain()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Mussels;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) >= 1)
        {
                UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  val_3.m_Handle.name, minimumDelayInSeconds:  2f, autoHideLoadingScreen:  true);
            DynamicUISingleton<AdventureWinPostMatchCanvas>.Hide();
            DynamicUISingleton<AdventureLosePostMatchCanvas>.Hide();
            return;
        }
        
        DynamicUISingleton<ExpressMusselPurchaseCanvas>.Show();
    }
    public static void Back()
    {
        var val_3;
        string val_13;
        var val_14;
        var val_15;
        byte val_16;
        var val_17;
        val_13 = 1152921505064992768;
        val_14 = null;
        val_14 = null;
        if(Character_GlobalInfo.gameMode != 2)
        {
            goto label_3;
        }
        
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        val_3.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        val_13 = "BEAT_BOSS_" + val_3.ToString();
        val_15 = null;
        val_15 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        val_16 = val_6.currentCryptoKey;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_8 = DataStructs.UserDataDictionary.GameSave.GetGameSaveFlags(key:  val_13, defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_16, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue & 4294967295, fakeValueChanged = val_6.fakeValue & 4294967295, inited = val_6.fakeValue & 4294967295});
        val_8.fakeValue = val_8.fakeValue & 4294967295;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_8.currentCryptoKey, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, fakeValueChanged = val_8.fakeValue, inited = val_8.fakeValue})) == false)
        {
            goto label_13;
        }
        
        label_3:
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "Scene_loadLevels", minimumDelayInSeconds:  2f, autoHideLoadingScreen:  true);
        DynamicUISingleton<AdventureWinPostMatchCanvas>.Hide();
        DynamicUISingleton<AdventureLosePostMatchCanvas>.Hide();
        return;
        label_13:
        val_17 = null;
        val_17 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        val_16 = val_10.currentCryptoKey;
        DataStructs.UserDataDictionary.GameSave.SetGameSaveFlags(key:  val_13, aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_16, hiddenValue = val_10.hiddenValue, fakeValue = val_10.fakeValue & 4294967295, fakeValueChanged = val_10.fakeValue & 4294967295, inited = val_10.fakeValue & 4294967295});
        StoryMovieCtrl.PlayED();
    }
    public AdventurePostMatch()
    {
    
    }

}
