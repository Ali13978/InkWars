using UnityEngine;
public class SwitcherCustomization : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI title;
    private TMPro.TextMeshProUGUI amount;
    private UnityEngine.UI.Button m_left;
    private UnityEngine.UI.Button m_right;
    private System.Collections.Generic.List<UnityEngine.UI.Image> m_stars;
    private ContainerTemplate m_template;
    private SwitcherCollection m_switcherCollection;
    private int m_tierCount;
    private UnityEngine.RectTransform m_parent;
    private UnityEngine.UI.Image m_switcherPreview;
    private UnityEngine.GameObject OfferPanel;
    private UnityEngine.UI.Image m_offerPreview;
    private TMPro.TextMeshProUGUI m_offertitle;
    private TMPro.TextMeshProUGUI m_offerDescription;
    private UnityEngine.UI.Image m_purchasedItemsDetails;
    private TMPro.TextMeshProUGUI m_purchasedItemsDetailsTitle;
    private PurchaseBubble m_purchaseBubble;
    private int m_index;
    private bool m_isChanged;
    private System.Collections.Generic.List<ContainerTemplate> m_buttonList;
    private UnityEngine.Vector2 m_prevPanelPosition;
    
    // Methods
    private string GetLocalizedTitle(string key)
    {
        return LanguageManager.GetText(key:  "LK.SwitcherTitle." + key);
    }
    private void Awake()
    {
        this.m_index = 3;
        this.m_isChanged = true;
        this.m_buttonList = new System.Collections.Generic.List<ContainerTemplate>();
        UnityEngine.Vector2 val_3 = this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        this.m_prevPanelPosition = val_3;
        mem[1152921528206243588] = val_3.y;
    }
    private void CheckforActive()
    {
        var val_3;
        System.Collections.Generic.List<ContainerTemplate> val_7;
        var val_8;
        val_7 = this.m_buttonList;
        List.Enumerator<T> val_1 = val_7.GetEnumerator();
        label_12:
        if((2124680320 & 1) == 0)
        {
            goto label_2;
        }
        
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Settings.SelectedSwitcher;
        int val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited});
        val_3.InitialType.SetActive(set:  true);
        goto label_12;
        label_2:
        val_3.Add(driver:  public System.Void List.Enumerator<ContainerTemplate>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    private void OnEnable()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedSwitcher;
        SwitcherData val_3 = this.m_switcherCollection.GetSwitcherByID(_id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}), returnNullForInvalidIds:  false);
        this.m_index = 3;
        this.m_left.gameObject.SetActive(value:  (this.m_index > 0) ? 1 : 0);
        this.m_right.gameObject.SetActive(value:  (this.m_index < (this.m_tierCount - 1)) ? 1 : 0);
        this.m_isChanged = true;
        this.m_left.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SwitcherCustomization::OnLeftClick()));
        this.m_right.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SwitcherCustomization::OnRightClick()));
    }
    private void OnDisable()
    {
        this.m_left.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SwitcherCustomization::OnLeftClick()));
        this.m_right.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SwitcherCustomization::OnRightClick()));
    }
    private void Start()
    {
    
    }
    private void Update()
    {
        UnityEngine.RectTransform val_10;
        var val_65;
        UnityEngine.RectTransform val_67;
        var val_68;
        var val_69;
        var val_70;
        float val_71;
        var val_72;
        var val_73;
        if(this.m_isChanged == false)
        {
                return;
        }
        
        .<>4__this = this;
        val_65 = null;
        val_65 = null;
        if((SwitcherCustomization.<>c.<>9__27_0) == null)
        {
            goto label_5;
        }
        
        label_26:
        val_67 = public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::RemoveAll(System.Predicate<T> match);
        int val_2 = this.m_stars.RemoveAll(match:  SwitcherCustomization.<>c.<>9__27_0);
        val_68 = 0;
        goto label_7;
        label_14:
        if(val_68 > this.m_index)
        {
                val_69 = 0;
        }
        else
        {
                val_69 = 1;
        }
        
        val_67 = 0;
        this.m_stars.Item[0].gameObject.SetActive(value:  true);
        val_68 = 1;
        label_7:
        if(val_68 < this.m_stars.Count)
        {
            goto label_14;
        }
        
        .bgData = this.m_switcherCollection.GetSwitchersByTier(type:  this.m_index + 1);
        List.Enumerator<T> val_8 = this.m_buttonList.GetEnumerator();
        label_22:
        if((2125812320 & 1) == 0)
        {
            goto label_18;
        }
        
        UnityEngine.Object.Destroy(obj:  val_10.InitialType.gameObject);
        goto label_22;
        label_5:
        SwitcherCustomization.<>c.<>9__27_0 = new System.Predicate<UnityEngine.UI.Image>(object:  SwitcherCustomization.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SwitcherCustomization.<>c::<Update>b__27_0(UnityEngine.UI.Image x));
        if(this.m_stars != null)
        {
            goto label_26;
        }
        
        goto label_26;
        label_18:
        val_10.Add(driver:  public System.Void List.Enumerator<ContainerTemplate>::Dispose(), rectTransform:  val_67, drivenProperties:  null);
        this.m_buttonList.Clear();
        List.Enumerator<T> val_14 = (SwitcherCustomization.<>c__DisplayClass27_0)[1152921528207539968].bgData.GetEnumerator();
        var val_64 = 0;
        label_82:
        if((2125812288 & 1) == 0)
        {
            goto label_35;
        }
        
        new SwitcherCustomization.<>c__DisplayClass27_1() = new System.Object();
        .CS$<>8__locals1 = new SwitcherCustomization.<>c__DisplayClass27_0();
        .data = val_10.InitialType;
        new SwitcherCustomization.<>c__DisplayClass27_2() = new System.Object();
        .CS$<>8__locals2 = new SwitcherCustomization.<>c__DisplayClass27_1();
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
        ContainerTemplate val_20 = UnityEngine.Object.Instantiate<ContainerTemplate>(original:  this.m_template, position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, rotation:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w});
        .button = val_20;
        val_20.transform.SetParent(p:  this.m_parent);
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
        (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].button.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
        (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].button.datas = (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data;
        (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].button.SetImage(sprite:  0.GetSwitcherSpriteByData(data:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data, charATKLv:  1));
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  new SwitcherCustomization.<>c__DisplayClass27_2(), method:  System.Void SwitcherCustomization.<>c__DisplayClass27_2::<Update>b__1());
        (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction());
        (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].button.gameObject.SetActive(value:  true);
        val_10 = 0;
        UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
        (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].button.GetComponent<UnityEngine.RectTransform>().pivot = new UnityEngine.Vector2() {x = val_30.x, y = val_30.y};
        val_70 = null;
        val_71 = 1f;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_31 = DataStructs.UserDataDictionary.Settings.SelectedSwitcher;
        if((val_64 == 0) || (((SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.id) == (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_31.currentCryptoKey, hiddenValue = val_31.hiddenValue, fakeValue = val_31.fakeValue, inited = val_31.inited}))))
        {
            goto label_69;
        }
        
        label_168:
        if(((SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.id) == 0)
        {
            goto label_72;
        }
        
        val_72 = null;
        val_72 = null;
        if((DataStructs.UserDataDictionary.Items.GetSwitcherUnlocked(id:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.id, includeVipUnlock:  true)) == false)
        {
            goto label_78;
        }
        
        label_72:
        (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].button.GetComponent<UnityEngine.CanvasGroup>().alpha = ;
        label_78:
        this.m_buttonList.Add(item:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].button);
        val_64 = val_64 - 1;
        goto label_82;
        label_69:
        this.m_switcherPreview.sprite = 0.GetSwitcherSpriteByData(data:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data, charATKLv:  1);
        val_10 = 0;
        this.m_switcherPreview.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  false);
        if(((SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.id) < 1)
        {
            goto label_91;
        }
        
        val_73 = null;
        val_73 = null;
        if((DataStructs.UserDataDictionary.Items.GetSwitcherUnlocked(id:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.id, includeVipUnlock:  true)) == false)
        {
            goto label_97;
        }
        
        label_91:
        if(((SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.id) == 0)
        {
            goto label_100;
        }
        
        this.OfferPanel.gameObject.SetActive(value:  false);
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  true);
        this.m_purchasedItemsDetailsTitle.text = this.GetLocalizedTitle(key:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.image);
        goto label_168;
        label_97:
        this.OfferPanel.gameObject.SetActive(value:  true);
        this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = this.m_prevPanelPosition, y = val_23.y};
        this.m_offerDescription.alignment = 2;
        this.m_offerPreview.gameObject.SetActive(value:  true);
        this.m_offertitle.text = this.GetLocalizedTitle(key:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.image);
        this.m_offerPreview.sprite = BattleEnhancerCollection.GetIcon(type:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.battleEnhancerOffer, isOpponent:  false);
        (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.battleEnhancerOffer.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  0);
        mem2[0] = null;
        object[] val_49 = new object[6];
        val_49[0] = "<size=100%>";
        val_49[1] = (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.offerCount.ToString();
        val_49[2] = "x ";
        val_49[3] = " <size=60%>[Lv ";
        val_49[4] = (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.level.ToString();
        val_49[5] = "]";
        this.m_offerDescription.text = LanguageManager.GetTextFormat(key:  "LK.Customization.En." + (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.battleEnhancerOffer.ToString().Replace(oldValue:  "_", newValue:  "")((SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.battleEnhancerOffer.ToString().Replace(oldValue:  "_", newValue:  "")), list:  val_49);
        goto label_168;
        label_100:
        this.OfferPanel.gameObject.SetActive(value:  true);
        this.m_offertitle.text = this.GetLocalizedTitle(key:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.image);
        this.m_offerPreview.gameObject.SetActive(value:  false);
        this.m_offerDescription.text = this.GetLocalizedTitle(key:  (SwitcherCustomization.<>c__DisplayClass27_2)[1152921528207605504].CS$<>8__locals2.data.image);
        UnityEngine.Vector2 val_59 = this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        val_10 = 0;
        UnityEngine.Vector2 val_60 = new UnityEngine.Vector2(x:  0f, y:  val_59.y);
        this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_60.x, y = val_60.y};
        this.m_offerDescription.alignment = 2;
        goto label_168;
        label_35:
        val_10.Add(driver:  public System.Void List.Enumerator<SwitcherData>::Dispose(), rectTransform:  null, drivenProperties:  null);
        this.SetupCounters();
        int val_65 = this.m_index;
        val_65 = val_65 + 1;
        val_65.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_67 = 0, drivenProperties:  null);
        this.title.text = LanguageManager.GetText(key:  "LK.Customization." + val_65.ToString());
        this.CheckforActive();
        this.m_isChanged = false;
    }
    private void OnLeftClick()
    {
        int val_4;
        this.m_right.gameObject.SetActive(value:  true);
        val_4 = this.m_index;
        int val_2 = val_4 - 1;
        if()
        {
                val_4 = val_2;
            this.m_index = val_2;
            this.m_isChanged = true;
        }
        
        if(val_4 != 0)
        {
                return;
        }
        
        this.m_left.gameObject.SetActive(value:  false);
    }
    private void OnRightClick()
    {
        int val_3;
        this.m_left.gameObject.SetActive(value:  true);
        int val_3 = this.m_tierCount;
        val_3 = this.m_index;
        val_3 = val_3 - 1;
        if(val_3 < val_3)
        {
                val_3 = val_3 + 1;
            this.m_index = val_3;
            this.m_isChanged = true;
        }
        
        if(val_3 < val_3)
        {
                return;
        }
        
        this.m_right.gameObject.SetActive(value:  false);
    }
    private void SetupCounters()
    {
        object val_9;
        var val_10;
        System.Collections.Generic.List<SwitcherData> val_2 = this.m_switcherCollection.GetSwitchersByTier(type:  this.m_index + 1);
        List.Enumerator<T> val_3 = val_2.GetEnumerator();
        val_9 = 0;
        goto label_9;
        label_10:
        System.Type val_4 = 0.InitialType;
        val_10 = null;
        val_10 = null;
        bool val_5 = DataStructs.UserDataDictionary.Items.GetSwitcherUnlocked(id:  W23, includeVipUnlock:  true);
        val_9 = 1;
        label_9:
        if((2126763864 & 1) != 0)
        {
            goto label_10;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<SwitcherData>::Dispose(), rectTransform:  1, drivenProperties:  0);
        this.amount.text = val_9 + "/"("/") + val_2.Count.ToString();
    }
    private void OnButtonClicked(SwitcherCollection.SwitcherData data, UnityEngine.CanvasGroup canvasGroup, int ind)
    {
        SwitcherData val_45;
        var val_46;
        var val_47;
        SwitcherCustomization.<>c__DisplayClass31_0 val_1 = new SwitcherCustomization.<>c__DisplayClass31_0();
        if(val_1 != null)
        {
                val_45 = val_1;
            .data = data;
            mem[1152921528208903568] = this;
        }
        else
        {
                mem[16] = this;
            val_45 = 24;
            mem[24] = data;
        }
        
        .canvasGroup = canvasGroup;
        GameAudio.PlayButtonSound();
        this.m_switcherPreview.sprite = 0.GetSwitcherSpriteByData(data:  val_45, charATKLv:  1);
        this.m_switcherPreview.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  false);
        if((data + 32) < 1)
        {
            goto label_11;
        }
        
        val_46 = null;
        val_46 = null;
        if((DataStructs.UserDataDictionary.Items.GetSwitcherUnlocked(id:  data + 32, includeVipUnlock:  true)) == false)
        {
            goto label_16;
        }
        
        label_11:
        UnityEngine.GameObject val_5 = this.OfferPanel.gameObject;
        if(val_5 == null)
        {
            goto label_19;
        }
        
        if((data + 32) == 0)
        {
            goto label_20;
        }
        
        label_71:
        val_5.SetActive(value:  false);
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  true);
        this.m_purchasedItemsDetailsTitle.text = this.GetLocalizedTitle(key:  data + 24);
        goto label_25;
        label_16:
        this.OfferPanel.gameObject.SetActive(value:  true);
        this.m_offertitle.text = this.GetLocalizedTitle(key:  data + 24);
        this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = this.m_prevPanelPosition, y = V9.16B};
        this.m_offerDescription.alignment = 2;
        this.m_offerPreview.gameObject.SetActive(value:  true);
        this.m_offerPreview.sprite = BattleEnhancerCollection.GetIcon(type:  data + 40, isOpponent:  false);
        SwitcherData val_45 = mem[24];
        val_45 = val_45 + 40;
        val_45.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  0);
        mem2[0] = null;
        object[] val_16 = new object[6];
        val_16[0] = "<size=100%>";
        val_16[1] = mem[24] + 44.ToString();
        val_16[2] = "x ";
        val_16[3] = " <size=60%>[Lv ";
        val_16[4] = mem[24] + 20.ToString();
        val_16[5] = "]";
        this.m_offerDescription.text = LanguageManager.GetTextFormat(key:  "LK.Customization.En." + val_45.ToString().Replace(oldValue:  "_", newValue:  "")(val_45.ToString().Replace(oldValue:  "_", newValue:  "")), list:  val_16);
        UnityEngine.Vector3 val_23 = (SwitcherCustomization.<>c__DisplayClass31_0)[1152921528208903552].canvasGroup.transform.position;
        this.m_purchaseBubble.Setup(pos:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, price:  mem[24] + 36.ToString(), currency:  data + 48, positionIndex:  ind, onClick:  new System.Action(object:  val_1, method:  System.Void SwitcherCustomization.<>c__DisplayClass31_0::<OnButtonClicked>b__0()));
        goto label_70;
        label_19:
        if((data + 32) != 0)
        {
            goto label_71;
        }
        
        label_20:
        val_5.SetActive(value:  true);
        this.m_offertitle.text = this.GetLocalizedTitle(key:  data + 24);
        this.m_offerPreview.gameObject.SetActive(value:  false);
        this.m_offerDescription.text = this.GetLocalizedTitle(key:  data + 24);
        UnityEngine.Vector2 val_32 = this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  0f, y:  val_32.y);
        this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_33.x, y = val_33.y};
        this.m_offerDescription.alignment = 2;
        label_25:
        val_47 = null;
        val_47 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_34 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  data + 32);
        DataStructs.UserDataDictionary.Settings.SelectedSwitcher = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_34.currentCryptoKey, hiddenValue = val_34.hiddenValue, fakeValue = val_34.fakeValue, inited = val_34.inited};
        this.CheckforActive();
        label_70:
        BattleBonusType val_35 = BattleBonusConfig.GetItemBonusType(item:  "SWITCHER", id:  data + 32);
        object[] val_36 = new object[4];
        if(val_36 == null)
        {
            goto label_92;
        }
        
        if(val_35 != 0)
        {
            goto label_93;
        }
        
        goto label_96;
        label_92:
        if(val_35 == 0)
        {
            goto label_96;
        }
        
        label_93:
        label_96:
        val_36[0] = val_35;
        val_36[1] = BattleBonusConfig.GetItemBonusValue(item:  "SWITCHER", id:  data + 32);
        val_36[2] = BattleBonusConfig.GetBonusValueForLocalPlayer(type:  val_35);
        val_36[3] = BattleBonusConfig.GetTotlaBonusValue(type:  val_35);
        string val_40 = System.String.Format(format:  " [{0} +{1} {2}/{3}]", args:  val_36);
        this.m_purchasedItemsDetailsTitle.text = this.m_purchasedItemsDetailsTitle.text + val_40;
        this.m_offertitle.text = this.m_offertitle.text + val_40;
    }
    public SwitcherCustomization()
    {
        this.m_tierCount = 6;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.m_prevPanelPosition = val_1;
        mem[1152921528209237764] = val_1.y;
    }

}
