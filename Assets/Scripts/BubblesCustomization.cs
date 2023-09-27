using UnityEngine;
public class BubblesCustomization : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI title;
    private TMPro.TextMeshProUGUI amount;
    private UnityEngine.UI.Button m_left;
    private UnityEngine.UI.Button m_right;
    private System.Collections.Generic.List<UnityEngine.UI.Image> m_stars;
    private ContainerTemplate m_template;
    private BubblesCollection m_bubblesCollection;
    private int m_tierCount;
    private UnityEngine.RectTransform m_parent;
    private System.Collections.Generic.List<UnityEngine.UI.Image> m_bubbleBluePreview;
    private UnityEngine.GameObject OfferPanel;
    private UnityEngine.UI.Image m_offerPreview;
    private TMPro.TextMeshProUGUI m_offertitle;
    private TMPro.TextMeshProUGUI m_offerDescription;
    private PurchaseBubble m_purchaseBubble;
    private UnityEngine.UI.Image m_purchasedItemsDetails;
    private TMPro.TextMeshProUGUI m_purchasedItemsDetailsTitle;
    private int m_index;
    private bool m_isChanged;
    private System.Collections.Generic.List<ContainerTemplate> m_buttonList;
    private UnityEngine.Vector2 m_prevPanelPosition;
    
    // Methods
    private void Awake()
    {
        this.m_index = 3;
        this.m_isChanged = true;
        this.m_buttonList = new System.Collections.Generic.List<ContainerTemplate>();
        UnityEngine.Vector2 val_3 = this.m_offerDescription.GetComponent<UnityEngine.RectTransform>().anchoredPosition;
        this.m_prevPanelPosition = val_3;
        mem[1152921528180850532] = val_3.y;
    }
    private void OnEnable()
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedBubble;
        BubblesData val_3 = this.m_bubblesCollection.getBubblesByFamily(family:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}), returnNullForInvalidIds:  false);
        this.m_index = 3;
        this.m_left.gameObject.SetActive(value:  (this.m_index > 0) ? 1 : 0);
        this.m_right.gameObject.SetActive(value:  (this.m_index < (this.m_tierCount - 1)) ? 1 : 0);
        this.m_isChanged = true;
        this.m_left.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BubblesCustomization::OnLeftClick()));
        this.m_right.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BubblesCustomization::OnRightClick()));
    }
    private void OnDisable()
    {
        this.m_left.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BubblesCustomization::OnLeftClick()));
        this.m_right.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BubblesCustomization::OnRightClick()));
    }
    private string GetLocalizedBubbleTitle(InkWars.Model.BubbleFamily family)
    {
        family.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        return (string)LanguageManager.GetText(key:  "LK.BubbleTitle." + family.ToString());
    }
    private void CheckforActive()
    {
        var val_3;
        System.Collections.Generic.List<ContainerTemplate> val_7;
        var val_8;
        val_7 = this.m_buttonList;
        List.Enumerator<T> val_1 = val_7.GetEnumerator();
        label_12:
        if((2099813840 & 1) == 0)
        {
            goto label_2;
        }
        
        System.Type val_4 = val_3.InitialType;
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Settings.SelectedBubble;
        if(mem[53674028] != (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited})))
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
        UnityEngine.RectTransform val_10;
        var val_50;
        UnityEngine.RectTransform val_52;
        var val_53;
        var val_54;
        int val_55;
        var val_57;
        var val_58;
        var val_59;
        float val_60;
        UnityEngine.DrivenTransformProperties val_61;
        var val_62;
        float val_63;
        var val_64;
        System.Predicate<UnityEngine.UI.Image> val_66;
        var val_67;
        var val_68;
        float val_69;
        var val_73;
        if(this.m_isChanged == false)
        {
                return;
        }
        
        .<>4__this = this;
        val_50 = null;
        val_50 = null;
        if((BubblesCustomization.<>c.<>9__26_0) == null)
        {
            goto label_5;
        }
        
        label_26:
        val_52 = public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::RemoveAll(System.Predicate<T> match);
        int val_2 = this.m_stars.RemoveAll(match:  BubblesCustomization.<>c.<>9__26_0);
        val_53 = 0;
        goto label_7;
        label_14:
        if(val_53 > this.m_index)
        {
                val_54 = 0;
        }
        else
        {
                val_54 = 1;
        }
        
        val_52 = 0;
        this.m_stars.Item[0].gameObject.SetActive(value:  true);
        val_53 = 1;
        label_7:
        if(val_53 < this.m_stars.Count)
        {
            goto label_14;
        }
        
        .bubbleData = this.m_bubblesCollection.GetBubblsByTier(tier:  this.m_index + 1);
        List.Enumerator<T> val_8 = this.m_buttonList.GetEnumerator();
        val_55 = 1152921528176374576;
        label_22:
        if((2100256512 & 1) == 0)
        {
            goto label_18;
        }
        
        UnityEngine.Object.Destroy(obj:  val_10.InitialType.gameObject);
        goto label_22;
        label_5:
        BubblesCustomization.<>c.<>9__26_0 = new System.Predicate<UnityEngine.UI.Image>(object:  BubblesCustomization.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BubblesCustomization.<>c::<Update>b__26_0(UnityEngine.UI.Image x));
        if(this.m_stars != null)
        {
            goto label_26;
        }
        
        goto label_26;
        label_18:
        val_10.Add(driver:  public System.Void List.Enumerator<ContainerTemplate>::Dispose(), rectTransform:  val_52, drivenProperties:  null);
        this.m_buttonList.Clear();
        List.Enumerator<T> val_14 = (BubblesCustomization.<>c__DisplayClass26_0)[1152921528181984160].bubbleData.GetEnumerator();
        val_57 = 1152921528181664992;
        val_58 = 0;
        val_59 = 0;
        val_60 = 0.5f;
        goto label_35;
        label_112:
        new BubblesCustomization.<>c__DisplayClass26_1() = new System.Object();
        .CS$<>8__locals1 = new BubblesCustomization.<>c__DisplayClass26_0();
        .data = val_10.InitialType;
        new BubblesCustomization.<>c__DisplayClass26_2() = new System.Object();
        .CS$<>8__locals2 = new BubblesCustomization.<>c__DisplayClass26_1();
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
        ContainerTemplate val_20 = UnityEngine.Object.Instantiate<ContainerTemplate>(original:  this.m_template, position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, rotation:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w});
        .button = val_20;
        val_20.transform.SetParent(p:  this.m_parent);
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
        (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].button.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
        (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].button.SetImage(sprite:  this.m_bubblesCollection.GetBubbleSpriteByData(data:  (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].CS$<>8__locals2.data, type:  5));
        val_61 = 0;
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  new BubblesCustomization.<>c__DisplayClass26_2(), method:  System.Void BubblesCustomization.<>c__DisplayClass26_2::<Update>b__1());
        (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction());
        (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].button.gameObject.SetActive(value:  true);
        (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].button.data = (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].CS$<>8__locals2.data;
        val_10 = 0;
        val_60 = val_60;
        UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  val_60, y:  val_60);
        (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].button.GetComponent<UnityEngine.RectTransform>().pivot = new UnityEngine.Vector2() {x = val_30.x, y = val_30.y};
        val_62 = null;
        val_63 = 1f;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_31 = DataStructs.UserDataDictionary.Settings.SelectedBubble;
        val_55 = val_31.fakeValue;
        if(val_58 != 0)
        {
                if(((BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].CS$<>8__locals2.data.family) != (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_31.currentCryptoKey, hiddenValue = val_31.hiddenValue, fakeValue = val_55, inited = val_31.inited})))
        {
            goto label_69;
        }
        
        }
        
        val_64 = null;
        val_64 = null;
        val_66 = BubblesCustomization.<>c.<>9__26_2;
        if(val_66 == null)
        {
                val_66 = null;
            val_61 = public System.Void System.Predicate<UnityEngine.UI.Image>::.ctor(object object, IntPtr method);
            val_66 = new System.Predicate<UnityEngine.UI.Image>(object:  BubblesCustomization.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BubblesCustomization.<>c::<Update>b__26_2(UnityEngine.UI.Image x));
            BubblesCustomization.<>c.<>9__26_2 = val_66;
        }
        
        val_67 = public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::RemoveAll(System.Predicate<T> match);
        int val_34 = this.m_bubbleBluePreview.RemoveAll(match:  null);
        List.Enumerator<T> val_35 = this.m_bubbleBluePreview.GetEnumerator();
        goto label_77;
        label_82:
        val_67 = 0;
        val_30.x.InitialType.sprite = this.m_bubblesCollection.GetBubbleSpriteByData(data:  (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].CS$<>8__locals2.data, type:  1);
        val_10 = 0;
        val_68 = val_58;
        val_57 = val_57;
        label_77:
        if((2100256448 & 1) != 0)
        {
            goto label_82;
        }
        
        val_59 = val_59 + 1;
        val_69 = 0;
        mem2[0] = 720;
        val_30.x.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  val_30.x, drivenProperties:  val_61);
        if( != 1)
        {
                var val_38 = (67108864 == 720) ? 1 : 0;
            val_38 = (( >= 0) ? 1 : 0) & val_38;
            val_59 =  - val_38;
        }
        
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  false);
        this.OfferPanel.gameObject.SetActive(value:  false);
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  true);
        val_55 = this.GetLocalizedBubbleTitle(family:  (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].CS$<>8__locals2.data.family);
        this.m_purchasedItemsDetailsTitle.text = val_55;
        label_69:
        if(((BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].CS$<>8__locals2.data.family) == 0)
        {
            goto label_102;
        }
        
        val_73 = null;
        val_73 = null;
        val_55 = (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].CS$<>8__locals2.data.family;
        val_61 = 0;
        if((DataStructs.UserDataDictionary.Items.GetBubbleUnlocked(id:  val_55, includeVipUnlock:  true)) == false)
        {
            goto label_108;
        }
        
        label_102:
        (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].button.GetComponent<UnityEngine.CanvasGroup>().alpha = ;
        label_108:
        this.SetupCounters();
        val_52 = public System.Void System.Collections.Generic.List<ContainerTemplate>::Add(ContainerTemplate item);
        this.m_buttonList.Add(item:  (BubblesCustomization.<>c__DisplayClass26_2)[1152921528182049696].button);
        val_58 = 53374225;
        label_35:
        if((2100256480 & 1) != 0)
        {
            goto label_112;
        }
        
        var val_46 = val_59 + 1;
        mem2[0] = 932;
        val_10.Add(driver:  public System.Void List.Enumerator<BubblesData>::Dispose(), rectTransform:  val_52, drivenProperties:  val_61);
        int val_50 = this.m_index;
        val_50 = val_50 + 1;
        val_50.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  val_52 = 0, drivenProperties:  val_61);
        this.title.text = LanguageManager.GetText(key:  "LK.Customization." + val_50.ToString());
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
        System.Collections.Generic.List<BubblesData> val_2 = this.m_bubblesCollection.GetBubblsByTier(tier:  this.m_index + 1);
        List.Enumerator<T> val_3 = val_2.GetEnumerator();
        val_9 = 0;
        goto label_9;
        label_10:
        System.Type val_4 = 0.InitialType;
        val_10 = null;
        val_10 = null;
        if((DataStructs.UserDataDictionary.Items.GetBubbleUnlocked(id:  W23, includeVipUnlock:  true)) != true)
        {
                if(DataStructs.UserDataDictionary.GameSave != null)
        {
            goto label_9;
        }
        
        }
        
        val_9 = 1;
        label_9:
        if((2100999112 & 1) != 0)
        {
            goto label_10;
        }
        
        0.Add(driver:  public System.Void List.Enumerator<BubblesData>::Dispose(), rectTransform:  1, drivenProperties:  0);
        this.amount.text = val_9 + "/"("/") + val_2.Count.ToString();
    }
    private void OnButtonClicked(BubblesCollection.BubblesData data, UnityEngine.CanvasGroup canvasGroup, int ind)
    {
        BattleBonusType val_5;
        var val_33;
        BubblesData val_34;
        var val_35;
        UnityEngine.RectTransform val_37;
        var val_38;
        var val_39;
        BubblesCustomization.<>c__DisplayClass30_0 val_1 = new BubblesCustomization.<>c__DisplayClass30_0();
        if(val_1 != null)
        {
                val_33 = val_1;
            .data = data;
            mem[1152921528183045664] = this;
        }
        else
        {
                mem[16] = this;
            val_33 = 24;
            mem[24] = data;
        }
        
        .canvasGroup = canvasGroup;
        GameAudio.PlayButtonSound();
        val_34 = 1152921505084481536;
        val_35 = null;
        val_35 = null;
        if((BubblesCustomization.<>c.<>9__30_0) == null)
        {
            goto label_7;
        }
        
        label_20:
        val_37 = public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::RemoveAll(System.Predicate<T> match);
        int val_2 = this.m_bubbleBluePreview.RemoveAll(match:  BubblesCustomization.<>c.<>9__30_0);
        List.Enumerator<T> val_3 = this.m_bubbleBluePreview.GetEnumerator();
        goto label_10;
        label_15:
        val_34 = mem[24];
        val_37 = 0;
        val_5.InitialType.sprite = this.m_bubblesCollection.GetBubbleSpriteByData(data:  val_34, type:  1);
        val_5 = 0;
        label_10:
        if((2101309840 & 1) != 0)
        {
            goto label_15;
        }
        
        val_5.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  val_37, drivenProperties:  ind);
        goto label_26;
        label_7:
        BubblesCustomization.<>c.<>9__30_0 = new System.Predicate<UnityEngine.UI.Image>(object:  BubblesCustomization.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BubblesCustomization.<>c::<OnButtonClicked>b__30_0(UnityEngine.UI.Image x));
        if(this.m_bubbleBluePreview != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_26:
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  false);
        if((data + 44) == 0)
        {
            goto label_31;
        }
        
        val_38 = null;
        val_38 = null;
        if((DataStructs.UserDataDictionary.Items.GetBubbleUnlocked(id:  data + 44, includeVipUnlock:  true)) == false)
        {
            goto label_37;
        }
        
        label_31:
        this.OfferPanel.gameObject.SetActive(value:  false);
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  true);
        this.m_purchasedItemsDetailsTitle.text = this.GetLocalizedBubbleTitle(family:  data + 44);
        val_39 = null;
        val_39 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  data + 44);
        DataStructs.UserDataDictionary.Settings.SelectedBubble = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_14.currentCryptoKey, hiddenValue = val_14.hiddenValue, fakeValue = val_14.fakeValue, inited = val_14.inited};
        this.CheckforActive();
        if(val_1 != null)
        {
            goto label_88;
        }
        
        label_89:
        label_88:
        BattleBonusType val_15 = BattleBonusConfig.GetItemBonusType(item:  "BUBBLE", id:  data + 24);
        object[] val_16 = new object[4];
        val_5 = val_15;
        val_16[0] = val_5;
        val_16[1] = BattleBonusConfig.GetItemBonusValue(item:  "BUBBLE", id:  data + 24);
        val_16[2] = BattleBonusConfig.GetBonusValueForLocalPlayer(type:  val_15);
        val_16[3] = BattleBonusConfig.GetTotlaBonusValue(type:  val_15);
        string val_20 = System.String.Format(format:  " [{0} +{1} {2}/{3}]", args:  val_16);
        this.m_purchasedItemsDetailsTitle.text = this.m_purchasedItemsDetailsTitle.text + val_20;
        this.m_offertitle.text = this.m_offertitle.text + val_20;
        return;
        label_37:
        this.OfferPanel.gameObject.SetActive(value:  false);
        this.m_purchasedItemsDetails.gameObject.SetActive(value:  true);
        this.m_purchasedItemsDetailsTitle.text = this.GetLocalizedBubbleTitle(family:  data + 44);
        UnityEngine.Vector3 val_29 = (BubblesCustomization.<>c__DisplayClass30_0)[1152921528183045648].canvasGroup.transform.position;
        this.m_purchaseBubble.Setup(pos:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, price:  mem[24] + 28.ToString(), currency:  data + 40, positionIndex:  ind, onClick:  new System.Action(object:  val_1, method:  System.Void BubblesCustomization.<>c__DisplayClass30_0::<OnButtonClicked>b__1()));
        if(val_1 != null)
        {
            goto label_88;
        }
        
        goto label_89;
    }
    public BubblesCustomization()
    {
        this.m_tierCount = 6;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.m_prevPanelPosition = val_1;
        mem[1152921528183285604] = val_1.y;
    }

}
