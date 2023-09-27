using UnityEngine;
public class AdventureLevelInfoPanel : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image bg;
    private UnityEngine.RectTransform panel;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Image stageBG;
    private TMPro.TextMeshProUGUI titleTxt;
    private UnityEngine.UI.Image characterImage;
    private CharacterNameController characterName;
    private UnityEngine.UI.Image inkMeterImage;
    private UnityEngine.UI.Image fillMeterImage;
    private TMPro.TextMeshProUGUI rewardTxt;
    private UnityEngine.UI.Image rewardItemImage;
    private AdventureGameModeButton puzzleButton;
    private DataStructs.GameLevel gameLevelData;
    
    // Methods
    private void OnEnable()
    {
        null = null;
        this.gameLevelData = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData();
        this.bg.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bg, endValue:  0f, duration:  0.5f));
        this.puzzleButton.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        this.panel.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.panel, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.5f)), ease:  27);
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdventureLevelInfoPanel::ClosePanel()));
        this.InitStage();
        this.InitCharacter();
        this.InitInkPanel();
    }
    private void OnDisable()
    {
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void AdventureLevelInfoPanel::ClosePanel()));
    }
    private void ClosePanel()
    {
        GameAudio.PlayButtonSound();
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bg, endValue:  0f, duration:  0.5f);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.panel, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  27);
        this.gameObject.SetActive(value:  false);
    }
    private void InitStage()
    {
        null = null;
        StageData val_3 = GameInfo.stage.GetStageDataByLevelId(levelId:  Character_GlobalInfo.stage_CurrentLevel - 1);
        this.stageBG.sprite = val_3.LoadStageSprite();
        this.titleTxt.text = LanguageManager.GetText(key:  "Lk.Shop.Bg." + val_3.ToString()).ToUpper();
    }
    private void InitCharacter()
    {
        AdventureCharacterBasedLevelSettings val_2 = AdventureLevelDataCollection.GetCurrent().GetSettingByCurrentCharacter();
        this.characterName.characterId = val_2.AICharacter;
        CharacterAssetLoader.Get(id:  val_2.AICharacter, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void AdventureLevelInfoPanel::<InitCharacter>b__17_0(CharacterAssetLoader loader)));
        Character_GlobalInfo.SetOpponentPlayer(nameID:  val_2.AICharacter);
    }
    private void InitInkPanel()
    {
        var val_24;
        eInkUnlockable val_25;
        var val_26;
        TMPro.TextMeshProUGUI val_27;
        string val_28;
        var val_29;
        float val_30;
        val_24 = null;
        val_24 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData().InkPercentage;
        int val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        if(val_4 < 100)
        {
                this.inkMeterImage.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "InkMeter/Ink_Meter_Empty");
            float val_24 = 0.01f;
            val_24 = (float)val_4 * val_24;
            this.fillMeterImage.fillAmount = val_24;
        }
        else
        {
                this.inkMeterImage.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "InkMeter/Ink_Meter_Broken_Full");
        }
        
        AdventureCharacterBasedLevelSettings val_8 = AdventureLevelDataCollection.GetCurrent().GetSettingByCurrentCharacter();
        if(val_8.fullyInkedRewards == null)
        {
            goto label_17;
        }
        
        val_25 = val_8.fullyInkedRewards;
        val_26 = this;
        val_27 = this.rewardTxt;
        if(val_8.fullyInkedRewards.item != 3)
        {
            goto label_18;
        }
        
        label_22:
        val_28 = System.String.Format(format:  val_8.fullyInkedRewards.description, arg0:  LanguageManager.GetText(key:  "LK.Adv.Unclock")).ToUpper();
        val_29 = 1;
        if(val_27 != null)
        {
            goto label_23;
        }
        
        goto label_21;
        label_17:
        val_25 = 24;
        val_26 = this;
        val_27 = this.rewardTxt;
        if(10260432 == 3)
        {
            goto label_22;
        }
        
        label_18:
        val_28 = "x" + val_8.fullyInkedRewards.quantity.ToString();
        val_29 = 0;
        if(val_27 != null)
        {
            goto label_23;
        }
        
        label_21:
        label_23:
        val_27.text = val_28;
        UnityEngine.RectTransform val_14 = val_27.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector2 val_15 = val_14.offsetMin;
        if((val_29 & 1) == 0)
        {
            goto label_26;
        }
        
        val_30 = 7f;
        if(val_14 != null)
        {
            goto label_31;
        }
        
        goto label_28;
        label_26:
        if(val_14 != null)
        {
            goto label_31;
        }
        
        label_28:
        label_31:
        val_14.offsetMin = new UnityEngine.Vector2() {x = (val_27.text.Length > 4) ? 20f : 7f, y = val_15.y};
        this.rewardItemImage.sprite = AdventureLevelDataCollection.GetRewardItemSprite(type:  val_25);
        if(0 == this.rewardItemImage.sprite)
        {
                UnityEngine.Color val_22 = UnityEngine.Color.clear;
        }
        else
        {
                UnityEngine.Color val_23 = UnityEngine.Color.white;
        }
        
        this.rewardItemImage.color = new UnityEngine.Color() {r = val_23.r, g = val_23.g, b = val_23.b, a = val_23.a};
    }
    public AdventureLevelInfoPanel()
    {
    
    }
    private void <InitCharacter>b__17_0(CharacterAssetLoader loader)
    {
        this.characterImage.sprite = loader.LoadPose_Dynamic();
    }

}
