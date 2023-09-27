using UnityEngine;
public class AdventureGameModeButton : MonoBehaviour
{
    // Fields
    private GameMode buttonGameMode;
    private UnityEngine.UI.Image star1Image;
    private UnityEngine.UI.Image star2Image;
    private UnityEngine.UI.Image star3Image;
    private TMPro.TextMeshProUGUI rewardDescTxt;
    private UnityEngine.UI.Image lockImage;
    private UnityEngine.UI.Image titleBG;
    private UnityEngine.UI.Image rewardItemImage;
    private UnityEngine.UI.Button modeBtn;
    private DataStructs.AdventureGameMode gameModeData;
    
    // Methods
    private void Awake()
    {
        this.modeBtn = this.GetComponent<UnityEngine.UI.Button>();
    }
    private void OnEnable()
    {
        var val_8;
        AdventureLevelData val_1 = AdventureLevelDataCollection.GetCurrent();
        if((val_1.enablePuzzleMode != true) && (this.buttonGameMode == 3))
        {
                this.gameObject.SetActive(value:  false);
            return;
        }
        
        val_8 = null;
        val_8 = null;
        this.gameModeData = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData().GetAdventureGameMode(key:  this.buttonGameMode);
        this.Init();
        this.modeBtn.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdventureGameModeButton::OnClick()));
    }
    private void OnDisable()
    {
        this.modeBtn.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdventureGameModeButton::OnClick()));
    }
    private void OnClick()
    {
        var val_2;
        GameAudio.PlayButtonSound();
        val_2 = null;
        val_2 = null;
        Character_GlobalInfo.gameMode = this.buttonGameMode;
        if(MVC_MusselTracker.GetMusselCount() != 0)
        {
                AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "MVC_GameScene", minimumDelayInSeconds:  1f, autoHideLoadingScreen:  true);
            return;
        }
        
        DynamicUISingleton<ExpressMusselPurchaseCanvas>.Show();
    }
    public void Init()
    {
        this.InitStars();
        this.InitReward();
        this.InitLock();
    }
    private void InitStars()
    {
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = this.gameModeData.Stars;
        int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = this.gameModeData.IsPlayable;
        val_3.fakeValue = val_3.fakeValue & 4294967295;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, fakeValueChanged = val_3.fakeValue, inited = val_3.fakeValue})) != false)
        {
                UnityEngine.Color val_5 = UnityEngine.Color.white;
        }
        else
        {
                UnityEngine.Color val_6 = UnityEngine.Color.clear;
        }
        
        UnityEngine.Color val_7 = UnityEngine.Color.clear;
        this.star1Image.color = new UnityEngine.Color() {r = (val_2 > 0) ? val_6.r : val_7.r, g = (val_2 > 0) ? val_6.g : val_7.g, b = (val_2 > 0) ? val_6.b : val_7.b, a = (val_2 > 0) ? val_6.a : val_7.a};
        this.star2Image.color = new UnityEngine.Color() {r = (val_2 > 1) ? val_6.r : val_7.r, g = (val_2 > 1) ? val_6.g : val_7.g, b = (val_2 > 1) ? val_6.b : val_7.b, a = (val_2 > 1) ? val_6.a : val_7.a};
        this.star3Image.color = new UnityEngine.Color() {r = (val_2 > 2) ? val_6.r : val_7.r, g = (val_2 > 2) ? val_6.g : val_7.g, b = (val_2 > 2) ? val_6.b : val_7.b, a = (val_2 > 2) ? val_6.a : val_7.a};
    }
    private void InitLock()
    {
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = this.gameModeData.IsPlayable;
        val_2.fakeValue = val_2.fakeValue & 4294967295;
        val_2.fakeValue = (~(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, fakeValueChanged = val_2.fakeValue, inited = val_2.fakeValue}))) & 1;
        this.lockImage.gameObject.SetActive(value:  val_2.fakeValue);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_5 = this.gameModeData.IsPlayable;
        val_5.fakeValue = val_5.fakeValue & 4294967295;
        val_5.fakeValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, fakeValueChanged = val_5.fakeValue, inited = val_5.fakeValue});
        this.titleBG.gameObject.SetActive(value:  val_5.fakeValue);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_7 = this.gameModeData.IsPlayable;
        val_7.fakeValue = val_7.fakeValue & 4294967295;
        val_7.fakeValue = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, fakeValueChanged = val_7.fakeValue, inited = val_7.fakeValue});
        this.modeBtn.interactable = val_7.fakeValue;
    }
    private void InitReward()
    {
        string val_16;
        AdventureModeSettings val_3 = AdventureLevelDataCollection.GetCurrent().GetSettingByCurrentCharacter().GetModeSetting(mode:  this.buttonGameMode, returnEmptyAsDefault:  false);
        if((this.buttonGameMode - 3) >= 2)
        {
            goto label_6;
        }
        
        string val_6 = System.String.Format(format:  val_3.reward.description, arg0:  LanguageManager.GetText(key:  "LK.Adv.Earn"));
        goto label_15;
        label_6:
        if(this.buttonGameMode != 1)
        {
            goto label_9;
        }
        
        AdventureLevelData val_7 = AdventureLevelDataCollection.GetCurrent();
        string val_8 = LanguageManager.GetText(key:  "LK.Adv.rewards.Description1");
        string val_9 = LanguageManager.GetText(key:  "LK.Adv.rewards.Description2");
        if(val_7.enablePuzzleMode == false)
        {
            goto label_14;
        }
        
        string val_11 = System.String.Format(format:  val_3.reward.description, arg0:  val_8, arg1:  val_9, arg2:  LanguageManager.GetText(key:  "LK.Adv.rewards.Description3"));
        goto label_15;
        label_9:
        val_16 = "";
        goto label_16;
        label_14:
        label_15:
        val_16 = System.String.Format(format:  val_3.reward.description, arg0:  val_8, arg1:  val_9);
        label_16:
        this.rewardDescTxt.text = val_16;
        if(0 == this.rewardItemImage)
        {
                return;
        }
        
        this.rewardItemImage.sprite = AdventureLevelDataCollection.GetRewardItemSprite(type:  val_3.reward.item);
    }
    public AdventureGameModeButton()
    {
    
    }

}
