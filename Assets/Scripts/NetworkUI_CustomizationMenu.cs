using UnityEngine;
public class NetworkUI_CustomizationMenu : NetworkUIMenu
{
    // Fields
    private UnityEngine.UI.Image m_Flag;
    private TMPro.TextMeshProUGUI m_UsernameField;
    private UnityEngine.UI.Image m_Avatar;
    private UnityEngine.CanvasGroup m_TitleTransparency;
    private CustomTitle m_Title;
    private TMPro.TextMeshProUGUI m_AvatarSlotText;
    private TMPro.TextMeshProUGUI m_TitleSlotText;
    private TMPro.TextMeshProUGUI m_FlagSlotText;
    private TMPro.TextMeshProUGUI m_CharacterSpecificSlotText;
    private TMPro.TextMeshProUGUI m_CommonSlotText;
    private float fadeOutValue;
    private UnityEngine.Color transparent;
    private UnityEngine.UI.Button commonButton;
    private UnityEngine.UI.Button specificButton;
    private UnityEngine.UI.Button avatarButton;
    private UnityEngine.UI.Button titleButton;
    private AvatarGridView commonAvatarPanel;
    private AvatarGridView specificAvatarPanel;
    private TitleGridView commonTitlePanel;
    private TitleGridView specificTitlePanel;
    private UnityEngine.GameObject characterSelectionPanel;
    private UnityEngine.RectTransform typeButtonGroup;
    private UnityEngine.RectTransform typeButtonGroupBG;
    private UnityEngine.RectTransform avatarTypeHolder;
    private UnityEngine.RectTransform titleTypeHolder;
    private UnityEngine.AudioClip onEquipSound;
    private NetworkUI_CustomizationMenu.GroupType groupType;
    private NetworkUI_CustomizationMenu.ItemType itemType;
    private int originAvatar;
    private int originTitle;
    
    // Methods
    private void Awake()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedAvatar;
        this.originAvatar = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Settings.SelectedTitle;
        this.originTitle = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
    }
    protected override void OnShow()
    {
        var val_5;
        this.Initialize();
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedAvatar;
        this.originAvatar = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Settings.SelectedTitle;
        this.originTitle = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
    }
    protected override void OnHide()
    {
        int val_5;
        var val_6;
        int val_7;
        var val_8;
        val_5 = this;
        val_6 = null;
        val_6 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedAvatar;
        val_7 = val_1.fakeValue;
        if(this.originAvatar == (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_7, inited = val_1.inited})))
        {
                val_8 = null;
            val_7 = this.originTitle;
            val_8 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Settings.SelectedTitle;
            val_5 = val_3.currentCryptoKey;
            if(val_7 == (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited})))
        {
                return;
        }
        
        }
        
        UnityEngine.Debug.Log(message:  "Custom avatar/title changed. save to firebase");
    }
    private void Start()
    {
        this.characterSelectionPanel.gameObject.SetActive(value:  true);
        this.commonButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkUI_CustomizationMenu::<Start>b__35_0()));
        this.specificButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkUI_CustomizationMenu::<Start>b__35_1()));
        this.avatarButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkUI_CustomizationMenu::<Start>b__35_2()));
        this.titleButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkUI_CustomizationMenu::<Start>b__35_3()));
        this.groupType = 1;
        this.SelectMainSlot();
        this.SelectSpecificationSlot();
        this.RefreshUserInfoPanel();
    }
    private void OnEnable()
    {
        this.commonTitlePanel.AddListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Title>(object:  this, method:  System.Void NetworkUI_CustomizationMenu::OnTitleEquip(ProfileUnlockables_Title data)));
        this.specificTitlePanel.AddListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Title>(object:  this, method:  System.Void NetworkUI_CustomizationMenu::OnTitleEquip(ProfileUnlockables_Title data)));
        this.commonAvatarPanel.AddListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Avatar>(object:  this, method:  System.Void NetworkUI_CustomizationMenu::OnAvatarEquip(ProfileUnlockables_Avatar data)));
        this.specificAvatarPanel.AddListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Avatar>(object:  this, method:  System.Void NetworkUI_CustomizationMenu::OnAvatarEquip(ProfileUnlockables_Avatar data)));
        this.Initialize();
    }
    private void RefreshUserInfoPanel()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedTitle;
        this.OnTitleEquipSFX(data:  TitleCollection.GetTitleFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})), enableSound:  false);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = DataStructs.UserDataDictionary.Settings.SelectedAvatar;
        this.OnAvatarEquipSFX(data:  AvatarCollection.GetAvatarFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited})), enableSound:  false);
    }
    private void OnDisable()
    {
        this.commonTitlePanel.RemoveListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Title>(object:  this, method:  System.Void NetworkUI_CustomizationMenu::OnTitleEquip(ProfileUnlockables_Title data)));
        this.specificTitlePanel.RemoveListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Title>(object:  this, method:  System.Void NetworkUI_CustomizationMenu::OnTitleEquip(ProfileUnlockables_Title data)));
        this.commonAvatarPanel.RemoveListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Avatar>(object:  this, method:  System.Void NetworkUI_CustomizationMenu::OnAvatarEquip(ProfileUnlockables_Avatar data)));
        this.specificAvatarPanel.RemoveListener(call:  new UnityEngine.Events.UnityAction<ProfileUnlockables_Avatar>(object:  this, method:  System.Void NetworkUI_CustomizationMenu::OnAvatarEquip(ProfileUnlockables_Avatar data)));
    }
    private void OnTitleEquip(ProfileUnlockables_Title data)
    {
        this.OnTitleEquipSFX(data:  data, enableSound:  true);
    }
    private void OnTitleEquipSFX(ProfileUnlockables_Title data, bool enableSound)
    {
        var val_5;
        this.m_Title.Setup(title:  data);
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  data.GetIntId());
        DataStructs.UserDataDictionary.Settings.SelectedTitle = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
        if(enableSound == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  this.onEquipSound, volume:  1f);
    }
    private void OnAvatarEquip(ProfileUnlockables_Avatar data)
    {
        this.OnAvatarEquipSFX(data:  data, enableSound:  true);
    }
    private void OnAvatarEquipSFX(ProfileUnlockables_Avatar data, bool enableSound)
    {
        var val_5;
        this.m_Avatar.sprite = data.Sprite_Avatar;
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  data.GetIntId());
        DataStructs.UserDataDictionary.Settings.SelectedAvatar = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
        if(enableSound == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_4 = GameAudio.sound.PlayOneShot(clip:  this.onEquipSound, volume:  1f);
    }
    private void Initialize()
    {
        null = null;
        this.m_UsernameField.text = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName);
        this.m_Flag.sprite = NetworkUtils.GetCountry(_flag:  DataStructs.UserDataDictionary.Settings.UserFlag);
    }
    public void SelectMainSlot()
    {
        if(this.itemType == 2)
        {
            goto label_0;
        }
        
        if(this.itemType == 1)
        {
            goto label_1;
        }
        
        if(this.itemType != 0)
        {
            goto label_2;
        }
        
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Avatar, endValue:  1f, duration:  0.1f);
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_TitleTransparency, endValue:  this.fadeOutValue, duration:  0.15f);
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Flag, endValue:  this.fadeOutValue, duration:  0.15f);
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        if(this.m_TitleSlotText != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        if(this.m_FlagSlotText != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        label_2:
        this.UpdatePanel();
        this.UpdateTypeButtonGroup();
        return;
        label_0:
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Avatar, endValue:  this.fadeOutValue, duration:  0.15f);
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_TitleTransparency, endValue:  this.fadeOutValue, duration:  0.15f);
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Flag, endValue:  1f, duration:  0.1f);
        UnityEngine.Color val_8 = UnityEngine.Color.white;
        if(this.m_FlagSlotText != null)
        {
            goto label_8;
        }
        
        goto label_9;
        label_1:
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Avatar, endValue:  this.fadeOutValue, duration:  0.15f);
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_TitleTransparency, endValue:  1f, duration:  0.1f);
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.m_Flag, endValue:  this.fadeOutValue, duration:  0.15f);
        UnityEngine.Color val_12 = UnityEngine.Color.white;
        if(this.m_TitleSlotText != null)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    public void SelectSpecificationSlot()
    {
        TMPro.TextMeshProUGUI val_3;
        UnityEngine.Color val_4;
        var val_5;
        var val_6;
        var val_7;
        if(this.groupType == 0)
        {
            goto label_0;
        }
        
        if(this.groupType != 1)
        {
            goto label_1;
        }
        
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        val_3 = this.m_CommonSlotText;
        val_4 = this.transparent;
        if(val_3 != null)
        {
            goto label_6;
        }
        
        goto label_4;
        label_0:
        val_3 = this.m_CommonSlotText;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        val_4 = val_2.r;
        val_5 = val_2.g;
        val_6 = val_2.b;
        val_7 = val_2.a;
        if(val_3 != null)
        {
            goto label_6;
        }
        
        label_4:
        label_6:
        label_1:
        this.UpdatePanel();
    }
    private void UpdatePanel()
    {
        var val_14;
        var val_15;
        UnityEngine.Object val_16;
        if(true != 0)
        {
                GameAudio.PlayButtonSound();
        }
        
        UnityEngine.GameObject val_1 = this.commonAvatarPanel.gameObject;
        if(this.groupType == 0)
        {
            goto label_5;
        }
        
        if(val_1 != null)
        {
            goto label_27;
        }
        
        label_28:
        label_27:
        val_1.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.commonTitlePanel.gameObject;
        if(this.groupType == 0)
        {
            goto label_8;
        }
        
        if(val_2 != null)
        {
            goto label_29;
        }
        
        label_30:
        label_29:
        val_2.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.specificAvatarPanel.gameObject;
        if(this.groupType != 1)
        {
            goto label_11;
        }
        
        var val_4 = (this.itemType == 0) ? 1 : 0;
        if(val_3 != null)
        {
            goto label_14;
        }
        
        goto label_13;
        label_11:
        val_14 = 0;
        if(val_3 != null)
        {
            goto label_14;
        }
        
        label_13:
        label_14:
        val_3.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.specificTitlePanel.gameObject;
        if(this.groupType != 1)
        {
            goto label_16;
        }
        
        var val_6 = (this.itemType == 1) ? 1 : 0;
        if(val_5 != null)
        {
            goto label_19;
        }
        
        goto label_18;
        label_16:
        val_15 = 0;
        if(val_5 != null)
        {
            goto label_19;
        }
        
        label_18:
        label_19:
        val_5.SetActive(value:  false);
        val_16 = this.characterSelectionPanel.GetComponent<UnityEngine.CanvasGroup>();
        if(0 == val_16)
        {
                val_16 = this.characterSelectionPanel.gameObject.AddComponent<UnityEngine.CanvasGroup>();
        }
        
        val_16.alpha = (this.groupType == 1) ? 1f : 0f;
        return;
        label_5:
        var val_12 = (this.itemType == 0) ? 1 : 0;
        if(val_1 != null)
        {
            goto label_27;
        }
        
        goto label_28;
        label_8:
        var val_13 = (this.itemType == 1) ? 1 : 0;
        if(val_2 != null)
        {
            goto label_29;
        }
        
        goto label_30;
    }
    private void UpdateTypeButtonGroup()
    {
        UnityEngine.Vector3 val_3 = (this.itemType == 0) ? this.avatarTypeHolder : this.titleTypeHolder.localPosition;
        this.typeButtonGroup.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_4 = this.typeButtonGroupBG.localScale;
        this.typeButtonGroupBG.localScale = new UnityEngine.Vector3() {x = (this.itemType == 0) ? -1f : 1f, y = val_4.y, z = val_4.z};
    }
    public NetworkUI_CustomizationMenu()
    {
        this.fadeOutValue = 0.5f;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.transparent = val_1;
        mem[1152921528557018296] = val_1.g;
        mem[1152921528557018300] = val_1.b;
        mem[1152921528557018304] = val_1.a;
        this = new UnityEngine.MonoBehaviour();
    }
    private void <Start>b__35_0()
    {
        this.groupType = 0;
        this.SelectSpecificationSlot();
    }
    private void <Start>b__35_1()
    {
        this.groupType = 1;
        this.SelectSpecificationSlot();
    }
    private void <Start>b__35_2()
    {
        this.itemType = 0;
        this.SelectMainSlot();
    }
    private void <Start>b__35_3()
    {
        this.itemType = 1;
        this.SelectMainSlot();
    }

}
