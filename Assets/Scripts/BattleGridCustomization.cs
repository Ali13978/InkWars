using UnityEngine;
public class BattleGridCustomization : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI title;
    private TMPro.TextMeshProUGUI amount;
    private UnityEngine.UI.Button m_left;
    private UnityEngine.UI.Button m_right;
    private System.Collections.Generic.List<UnityEngine.UI.Image> m_stars;
    private ContainerTemplate m_template;
    private BattleGridCollection m_battleGridCollection;
    private int m_tierCount;
    private UnityEngine.RectTransform m_parent;
    private UnityEngine.UI.Image m_battleGridPreview;
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
        return LanguageManager.GetText(key:  "LK.BattleGridTitle." + key);
    }
    private void Awake()
    {
        this.m_index = 3;
        this.m_isChanged = true;
        this.m_buttonList = new System.Collections.Generic.List<ContainerTemplate>();
        UnityEngine.Vector2 val_3 = this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        this.m_prevPanelPosition = val_3;
        mem[1152921528175782820] = val_3.y;
    }
    private void OnEnable()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedBattleGrid;
        BGData val_3 = this.m_battleGridCollection.GetBattleGridByID(_id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}), returnNullForInvalidIds:  false);
        this.m_index = 3;
        this.m_left.gameObject.SetActive(value:  (this.m_index > 0) ? 1 : 0);
        this.m_right.gameObject.SetActive(value:  (this.m_index < (this.m_tierCount - 1)) ? 1 : 0);
        this.m_isChanged = true;
        this.m_left.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleGridCustomization::OnLeftClick()));
        this.m_right.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleGridCustomization::OnRightClick()));
    }
    private void OnDisable()
    {
        this.m_left.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleGridCustomization::OnLeftClick()));
        this.m_right.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleGridCustomization::OnRightClick()));
    }
    private void Start()
    {
    
    }
    private void CheckforActive()
    {
        var val_3;
        System.Collections.Generic.List<ContainerTemplate> val_7;
        var val_8;
        val_7 = this.m_buttonList;
        List.Enumerator<T> val_1 = val_7.GetEnumerator();
        label_12:
        if((2094709152 & 1) == 0)
        {
            goto label_2;
        }
        
        System.Type val_4 = val_3.InitialType;
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Settings.SelectedBattleGrid;
        if(mem[53674020] != (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited})))
        {
            goto label_10;
        }
        
        val_4.SetActive(set:  true);
        goto label_12;
        label_10:
        val_4.SetActive(set:  false);
        goto label_12;
        label_2:
        val_3.Add(driver:  public System.Void List.Enumerator<ContainerTemplate>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    private void Update()
    {
        UnityEngine.RectTransform val_12;
        var val_68;
        var val_70;
        var val_71;
        System.Collections.Generic.List<BGData> val_72;
        var val_73;
        var val_74;
        UnityEngine.RectTransform val_76;
        var val_77;
        var val_78;
        float val_79;
        float val_81;
        UnityEngine.DrivenTransformProperties val_82;
        var val_83;
        float val_84;
        var val_85;
        var val_86;
        if(this.m_isChanged == false)
        {
                return;
        }
        
        BattleGridCustomization.<>c__DisplayClass27_0 val_1 = new BattleGridCustomization.<>c__DisplayClass27_0();
        .<>4__this = this;
        val_68 = null;
        val_68 = null;
        if((BattleGridCustomization.<>c.<>9__27_0) == null)
        {
            goto label_5;
        }
        
        label_21:
        int val_2 = this.m_stars.RemoveAll(match:  BattleGridCustomization.<>c.<>9__27_0);
        val_70 = 0;
        goto label_7;
        label_14:
        if(val_70 > this.m_index)
        {
                val_71 = 0;
        }
        else
        {
                val_71 = 1;
        }
        
        this.m_stars.Item[0].gameObject.SetActive(value:  true);
        val_70 = 1;
        label_7:
        if(val_70 < this.m_stars.Count)
        {
            goto label_14;
        }
        
        val_72 = this.m_battleGridCollection.GetBattleGridsByTier(type:  this.m_index + 1);
        if(val_1 == null)
        {
            goto label_16;
        }
        
        val_73 = val_1;
        .bgData = val_72;
        goto label_17;
        label_5:
        BattleGridCustomization.<>c.<>9__27_0 = new System.Predicate<UnityEngine.UI.Image>(object:  BattleGridCustomization.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleGridCustomization.<>c::<Update>b__27_0(UnityEngine.UI.Image x));
        if(this.m_stars != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_16:
        val_73 = 16;
        mem[16] = val_72;
        val_72 = mem[16];
        label_17:
        val_74 = null;
        val_74 = null;
        if((BattleGridCustomization.<>c.<>9__27_1) == null)
        {
            goto label_24;
        }
        
        label_35:
        val_76 = public System.Int32 System.Collections.Generic.List<BGData>::RemoveAll(System.Predicate<T> match);
        int val_9 = val_72.RemoveAll(match:  BattleGridCustomization.<>c.<>9__27_1);
        List.Enumerator<T> val_10 = this.m_buttonList.GetEnumerator();
        label_31:
        if((2095370496 & 1) == 0)
        {
            goto label_27;
        }
        
        UnityEngine.Object.Destroy(obj:  val_12.InitialType.gameObject);
        goto label_31;
        label_24:
        BattleGridCustomization.<>c.<>9__27_1 = new System.Predicate<BGData>(object:  BattleGridCustomization.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleGridCustomization.<>c::<Update>b__27_1(BattleGridCollection.BGData x));
        if(val_72 != 0)
        {
            goto label_35;
        }
        
        goto label_35;
        label_27:
        val_12.Add(driver:  public System.Void List.Enumerator<ContainerTemplate>::Dispose(), rectTransform:  val_76, drivenProperties:  null);
        this.m_buttonList.Clear();
        List.Enumerator<T> val_16 = val_73.GetEnumerator();
        val_77 = 1152921528176568496;
        val_78 = 1152921505084055552;
        val_79 = 0.5f;
        goto label_44;
        label_177:
        new BattleGridCustomization.<>c__DisplayClass27_1() = new System.Object();
        .CS$<>8__locals1 = val_1;
        .data = val_12.InitialType;
        new BattleGridCustomization.<>c__DisplayClass27_2() = new System.Object();
        .CS$<>8__locals2 = new BattleGridCustomization.<>c__DisplayClass27_1();
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.identity;
        ContainerTemplate val_22 = UnityEngine.Object.Instantiate<ContainerTemplate>(original:  this.m_template, position:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, rotation:  new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w});
        .button = val_22;
        val_22.transform.SetParent(p:  this.m_parent);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.one;
        val_81 = val_25.y;
        (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].button.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_25.x, y = val_81, z = val_25.z};
        (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].button.datab = (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data;
        (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].button.GetComponent<UnityEngine.UI.Image>().sprite = 0.GetBattleGridTileSpriteByData(data:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data);
        val_82 = 0;
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  new BattleGridCustomization.<>c__DisplayClass27_2(), method:  System.Void BattleGridCustomization.<>c__DisplayClass27_2::<Update>b__2());
        (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction());
        (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].button.gameObject.SetActive(value:  true);
        val_12 = 0;
        val_79 = val_79;
        UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  val_79, y:  val_79);
        (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].button.GetComponent<UnityEngine.RectTransform>().pivot = new UnityEngine.Vector2() {x = val_33.x, y = val_33.y};
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  false);
        val_83 = null;
        val_84 = 1f;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_35 = DataStructs.UserDataDictionary.Settings.SelectedBattleGrid;
        if(0 != 0)
        {
                if(((BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.id) != (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_35.currentCryptoKey, hiddenValue = val_35.hiddenValue, fakeValue = val_35.fakeValue, inited = val_35.inited})))
        {
            goto label_121;
        }
        
        }
        
        this.m_battleGridPreview.sprite = 0.GetBattleGridSpriteByData(data:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data);
        val_12 = 0;
        this.m_battleGridPreview.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if(((BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.id) < 3)
        {
            goto label_88;
        }
        
        val_85 = null;
        val_85 = null;
        val_82 = 0;
        if((DataStructs.UserDataDictionary.Items.GetBattleGridUnlocked(id:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.id, includeVipUnlock:  true)) == false)
        {
            goto label_94;
        }
        
        label_88:
        if(((BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.id) == 0)
        {
            goto label_97;
        }
        
        this.OfferPanel.gameObject.SetActive(value:  false);
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  true);
        this.m_purchasedItemsDetailsTitle.text = this.GetLocalizedTitle(key:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.image);
        goto label_121;
        label_97:
        this.OfferPanel.gameObject.SetActive(value:  true);
        this.m_offertitle.text = this.GetLocalizedTitle(key:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.image);
        this.m_offerPreview.gameObject.SetActive(value:  false);
        this.m_offerDescription.text = this.GetLocalizedTitle(key:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.image);
        UnityEngine.Vector2 val_48 = this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        val_12 = 0;
        UnityEngine.Vector2 val_49 = new UnityEngine.Vector2(x:  0f, y:  val_48.y);
        this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_49.x, y = val_49.y};
        this.m_offerDescription.alignment = 2;
        goto label_121;
        label_94:
        this.OfferPanel.gameObject.SetActive(value:  true);
        this.m_offertitle.text = this.GetLocalizedTitle(key:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.image);
        this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = this.m_prevPanelPosition, y = val_81};
        this.m_offerDescription.alignment = 2;
        this.m_offerPreview.gameObject.SetActive(value:  true);
        this.m_offerPreview.sprite = BattleEnhancerCollection.GetIcon(type:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.battleEnhancerOffer, isOpponent:  false);
        (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.battleEnhancerOffer.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  val_82);
        mem2[0] = null;
        val_82 = 0;
        object[] val_58 = new object[6];
        val_58[0] = "<size=100%>";
        val_58[1] = (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.offerCount.ToString();
        val_58[2] = "x ";
        val_58[3] = " <size=60%>[Lv ";
        val_58[4] = (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.level.ToString();
        val_58[5] = "]";
        this.m_offerDescription.text = LanguageManager.GetTextFormat(key:  "LK.Customization.En." + (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.battleEnhancerOffer.ToString().Replace(oldValue:  "_", newValue:  "")((BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.battleEnhancerOffer.ToString().Replace(oldValue:  "_", newValue:  "")), list:  val_58);
        label_121:
        val_78 = 1152921505084055552;
        if(((BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.id) < 3)
        {
            goto label_167;
        }
        
        val_86 = null;
        val_86 = null;
        val_82 = 0;
        val_78 = 1152921505084055552;
        if((DataStructs.UserDataDictionary.Items.GetBattleGridUnlocked(id:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].CS$<>8__locals2.data.id, includeVipUnlock:  true)) == false)
        {
            goto label_173;
        }
        
        label_167:
        (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].button.GetComponent<UnityEngine.CanvasGroup>().alpha = ;
        label_173:
        val_76 = public System.Void System.Collections.Generic.List<ContainerTemplate>::Add(ContainerTemplate item);
        this.m_buttonList.Add(item:  (BattleGridCustomization.<>c__DisplayClass27_2)[1152921528177163680].button);
        val_77 = X27;
        label_44:
        if((2095370464 & 1) != 0)
        {
            goto label_177;
        }
        
        val_12.Add(driver:  public System.Void List.Enumerator<BGData>::Dispose(), rectTransform:  val_76, drivenProperties:  val_82);
        this.SetupCounters();
        int val_67 = this.m_index;
        val_67 = val_67 + 1;
        val_67.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_76 = 0, drivenProperties:  val_82);
        this.title.text = LanguageManager.GetText(key:  "LK.Customization." + val_67.ToString());
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
        var val_12;
        var val_13;
        System.Predicate<BGData> val_15;
        UnityEngine.RectTransform val_16;
        UnityEngine.DrivenTransformProperties val_17;
        object val_18;
        var val_19;
        System.Collections.Generic.List<BGData> val_2 = this.m_battleGridCollection.GetBattleGridsByTier(type:  this.m_index + 1);
        val_12 = 1152921505084108800;
        val_13 = null;
        val_13 = null;
        val_15 = BattleGridCustomization.<>c.<>9__30_0;
        if(val_15 == null)
        {
            goto label_4;
        }
        
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_9:
        val_16 = public System.Int32 System.Collections.Generic.List<BGData>::RemoveAll(System.Predicate<T> match);
        int val_3 = val_2.RemoveAll(match:  val_15);
        goto label_6;
        label_4:
        System.Predicate<BGData> val_4 = null;
        val_15 = val_4;
        val_17 = public System.Void System.Predicate<BGData>::.ctor(object object, IntPtr method);
        val_4 = new System.Predicate<BGData>(object:  BattleGridCustomization.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleGridCustomization.<>c::<SetupCounters>b__30_0(BattleGridCollection.BGData x));
        BattleGridCustomization.<>c.<>9__30_0 = val_15;
        if(val_2 != null)
        {
            goto label_9;
        }
        
        label_5:
        val_16 = public System.Int32 System.Collections.Generic.List<BGData>::RemoveAll(System.Predicate<T> match);
        int val_5 = val_2.RemoveAll(match:  val_4);
        label_6:
        List.Enumerator<T> val_6 = val_2.GetEnumerator();
        val_18 = 0;
        goto label_16;
        label_17:
        System.Type val_7 = 0.InitialType;
        val_19 = null;
        val_19 = null;
        val_16 = 1;
        val_17 = 0;
        bool val_8 = DataStructs.UserDataDictionary.Items.GetBattleGridUnlocked(id:  1152921505084108800, includeVipUnlock:  true);
        val_18 = 1;
        label_16:
        if((2096331256 & 1) != 0)
        {
            goto label_17;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<BGData>::Dispose(), rectTransform:  val_16, drivenProperties:  val_17);
        this.amount.text = val_18 + "/"("/") + val_2.Count.ToString();
    }
    private void OnButtonClicked(BattleGridCollection.BGData data, UnityEngine.CanvasGroup canvasGroup, int ind)
    {
        BGData val_45;
        var val_46;
        var val_47;
        BattleGridCustomization.<>c__DisplayClass31_0 val_1 = new BattleGridCustomization.<>c__DisplayClass31_0();
        if(val_1 != null)
        {
                val_45 = val_1;
            .data = data;
            mem[1152921528178475248] = this;
        }
        else
        {
                mem[16] = this;
            val_45 = 24;
            mem[24] = data;
        }
        
        .canvasGroup = canvasGroup;
        GameAudio.PlayButtonSound();
        this.m_battleGridPreview.sprite = 0.GetBattleGridSpriteByData(data:  val_45);
        this.m_battleGridPreview.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  false);
        if((data + 36) < 3)
        {
            goto label_11;
        }
        
        val_46 = null;
        val_46 = null;
        if((DataStructs.UserDataDictionary.Items.GetBattleGridUnlocked(id:  data + 36, includeVipUnlock:  true)) == false)
        {
            goto label_16;
        }
        
        label_11:
        UnityEngine.GameObject val_5 = this.OfferPanel.gameObject;
        if(val_5 == null)
        {
            goto label_19;
        }
        
        if((data + 36) == 0)
        {
            goto label_20;
        }
        
        label_26:
        val_5.SetActive(value:  false);
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  true);
        this.m_purchasedItemsDetailsTitle.text = this.GetLocalizedTitle(key:  data + 24);
        goto label_25;
        label_19:
        if((data + 36) != 0)
        {
            goto label_26;
        }
        
        label_20:
        val_5.SetActive(value:  true);
        this.m_offertitle.text = this.GetLocalizedTitle(key:  data + 24);
        this.m_offerPreview.gameObject.SetActive(value:  false);
        this.m_offerDescription.text = this.GetLocalizedTitle(key:  data + 24);
        UnityEngine.Vector2 val_13 = this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  0f, y:  val_13.y);
        this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
        this.m_offerDescription.alignment = 2;
        label_25:
        val_47 = null;
        val_47 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  data + 36);
        DataStructs.UserDataDictionary.Settings.SelectedBattleGrid = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_15.fakeValue, inited = val_15.inited};
        this.CheckforActive();
        goto label_44;
        label_16:
        this.OfferPanel.gameObject.SetActive(value:  true);
        this.m_offertitle.text = this.GetLocalizedTitle(key:  data + 24);
        this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition = new UnityEngine.Vector2() {x = this.m_prevPanelPosition, y = V9.16B};
        this.m_offerPreview.gameObject.SetActive(value:  true);
        this.m_offerPreview.sprite = BattleEnhancerCollection.GetIcon(type:  data + 40, isOpponent:  false);
        this.m_offerDescription.alignment = 2;
        BGData val_45 = mem[24];
        val_45 = val_45 + 40;
        val_45.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  0);
        mem2[0] = null;
        object[] val_24 = new object[6];
        val_24[0] = "<size=100%>";
        val_24[1] = mem[24] + 44.ToString();
        val_24[2] = "x ";
        val_24[3] = " <size=60%>[Lv ";
        val_24[4] = mem[24] + 20.ToString();
        val_24[5] = "]";
        this.m_offerDescription.text = LanguageManager.GetTextFormat(key:  "LK.Customization.En." + val_45.ToString().Replace(oldValue:  "_", newValue:  "")(val_45.ToString().Replace(oldValue:  "_", newValue:  "")), list:  val_24);
        UnityEngine.Vector3 val_31 = (BattleGridCustomization.<>c__DisplayClass31_0)[1152921528178475232].canvasGroup.transform.position;
        this.m_purchaseBubble.Setup(pos:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, price:  mem[24] + 32.ToString(), currency:  data + 48, positionIndex:  ind, onClick:  new System.Action(object:  val_1, method:  System.Void BattleGridCustomization.<>c__DisplayClass31_0::<OnButtonClicked>b__0()));
        label_44:
        BattleBonusType val_35 = BattleBonusConfig.GetItemBonusType(item:  "GRID", id:  data + 36);
        object[] val_36 = new object[4];
        val_36[0] = val_35;
        val_36[1] = BattleBonusConfig.GetItemBonusValue(item:  "GRID", id:  data + 36);
        val_36[2] = BattleBonusConfig.GetBonusValueForLocalPlayer(type:  val_35);
        val_36[3] = BattleBonusConfig.GetTotlaBonusValue(type:  val_35);
        string val_40 = System.String.Format(format:  " [{0} +{1} {2}/{3}]", args:  val_36);
        this.m_purchasedItemsDetailsTitle.text = this.m_purchasedItemsDetailsTitle.text + val_40;
        this.m_offertitle.text = this.m_offertitle.text + val_40;
    }
    public BattleGridCustomization()
    {
        this.m_tierCount = 6;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.m_prevPanelPosition = val_1;
        mem[1152921528178809444] = val_1.y;
    }

}
