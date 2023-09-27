using UnityEngine;
public class BattleEnhancerLevelPanel : MonoBehaviour
{
    // Fields
    public InkWars.Model.BattleEnhancerType enhancerType;
    public int level;
    private TMPro.TextMeshProUGUI levelText;
    private TMPro.TextMeshProUGUI countText;
    private SoftCurrencyBuyButton addButton;
    private UnityEngine.UI.Button equipButton;
    private UnityEngine.UI.Image activeIcon;
    private UnityEngine.Color activeColor;
    private UnityEngine.UI.Image activeSprite;
    private UnityEngine.UI.Image inActiveSprite;
    private TMPro.TextMeshProUGUI timeText;
    private bool isActivedItem;
    private static UnityEngine.Events.UnityEvent OnEquipStateChangedEvent;
    
    // Methods
    public void Setup(InkWars.Model.BattleEnhancerType aNewType, int aNewLevelStartFrom1)
    {
        var val_28;
        var val_29;
        this.enhancerType = aNewType;
        this.level = aNewLevelStartFrom1;
        val_28 = 1152921504858337280;
        if(0 != this.addButton)
        {
                BattleEnhancerPriceData val_4 = BattleEnhancerCollection.GetPriceData(type:  this.enhancerType, aNewLevel:  this.level, count:  1);
            object[] val_5 = new object[4];
            val_5[0] = this.level;
            val_5[1] = LanguageManager.GetText(key:  "Lk.BattleEnhancer." + this.enhancerType);
            val_5[2] = val_4.GetPromoPrice().ToString();
            val_5[3] = LanguageManager.GetText(key:  "LK.rewards." + CurrencyCollection.Get(cur:  val_4.currency).TitleCasePluralName(CurrencyCollection.Get(cur:  val_4.currency).TitleCasePluralName));
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_4.GetPromoPrice());
            this.addButton.Setup(aNewItemName:  System.String.Format(format:  "Lv{0} {1}", arg0:  this.level, arg1:  BattleEnhancerCollection.GetName(type:  this.enhancerType)), aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16.currentCryptoKey, hiddenValue = val_16.hiddenValue, fakeValue = val_16.fakeValue, inited = val_16.inited}, aNewCurrency:  val_4.currency, purchaseDoneCallback:  new System.Action(object:  this, method:  System.Void BattleEnhancerLevelPanel::OnPurchaseDone()), customTitle:  LanguageManager.GetText(key:  "LK.Customization.PurchaseMsg"), customMessage:  LanguageManager.GetTextFormat(key:  "LK.BattleEnahncer.BuyNowMsg", list:  val_5));
            this.addButton.SetCustomCanBuyCheck(aNewCustomBuyCheckFunc:  new SoftCurrencyBuyButton.CustomCanBuyFunc(object:  this, method:  System.Boolean BattleEnhancerLevelPanel::CanAdd()), OnCustomBuyCheckFail:  new System.Action(object:  this, method:  System.Void BattleEnhancerLevelPanel::OnCannotBuy()));
            val_28 = 1152921504858337280;
        }
        
        if(0 != this.equipButton)
        {
                this.equipButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerLevelPanel::OnEquipClick()));
            this.equipButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerLevelPanel::OnEquipClick()));
        }
        
        this.isActivedItem = false;
        this.OnEquipStateChanged();
        val_29 = null;
        val_29 = null;
        BattleEnhancerLevelPanel.OnEquipStateChangedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerLevelPanel::OnEquipStateChanged()));
        BattleEnhancerLevelPanel.OnEquipStateChangedEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerLevelPanel::OnEquipStateChanged()));
        this.RefreshText();
    }
    private void OnPurchaseDone()
    {
        null = null;
        DataStructs.UserDataDictionary.Items.AddEnhancerCount(type:  this.enhancerType, level:  this.level, count:  1);
        this.RefreshText();
        this.OnEquipClick();
    }
    private bool CanAdd()
    {
        null = null;
        return (bool)((DataStructs.UserDataDictionary.Items.GetEnhancerCount(type:  this.enhancerType, level:  this.level, defaultValue:  0)) < 9999) ? 1 : 0;
    }
    private void OnCannotBuy()
    {
        MaxCountDialog.Show(msg1:  System.String.Format(format:  "YOUR CURRENT {0} ARE AT MAX STOCK ({1}/{1})", arg0:  System.String.Format(format:  "Lv{0} {1}", arg0:  this.level, arg1:  BattleEnhancerCollection.GetName(type:  this.enhancerType)), arg1:  9999), msg2:  "Use them up before purchasing more!");
    }
    private void OnEquipStateChanged()
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedBattleEnhancer;
        BattleEnhancerItem val_3 = BattleEnhancerItem.FromInt(number:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}));
        if(val_3.enhancerType == this.enhancerType)
        {
                var val_4 = (val_3.level == this.level) ? 1 : 0;
        }
        else
        {
                val_7 = 0;
        }
        
        bool val_6 = this.isActivedItem;
        val_6 = val_6 ^ 1;
        val_6 = val_7 & val_6;
        if(val_6 == false)
        {
            goto label_9;
        }
        
        this.isActivedItem = true;
        if(this.activeSprite != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        this.activeIcon.sprite = this.activeSprite.sprite;
        return;
        label_9:
        if(val_7 != 0)
        {
                return;
        }
        
        this.isActivedItem = false;
        if(this.inActiveSprite != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    public void RefreshText()
    {
        TMPro.TextMeshProUGUI val_12;
        var val_13;
        var val_14;
        val_12 = this;
        if(this.enhancerType == 1)
        {
            goto label_1;
        }
        
        val_13 = 6;
        if((this.enhancerType == 2) || (this.enhancerType == 5))
        {
            goto label_4;
        }
        
        var val_1 = (this.enhancerType == 4) ? 8 : 10;
        goto label_4;
        label_1:
        val_13 = 8;
        label_4:
        this.timeText.text = (UnityEngine.Mathf.Clamp(value:  this.level, min:  1, max:  6)) * val_13.ToString();
        if(0 != this.levelText)
        {
                this.levelText.text = "Lv " + this.level.ToString();
        }
        
        val_14 = null;
        val_14 = null;
        if(0 == this.countText)
        {
                return;
        }
        
        val_12 = this.countText;
        val_12.text = "x" + DataStructs.UserDataDictionary.Items.GetEnhancerCount(type:  this.enhancerType, level:  this.level, defaultValue:  0).ToString()(DataStructs.UserDataDictionary.Items.GetEnhancerCount(type:  this.enhancerType, level:  this.level, defaultValue:  0).ToString());
    }
    private void OnAddButtonClick()
    {
        if(0 == this.addButton)
        {
                return;
        }
        
        this.addButton.buyButton.onClick.Invoke();
    }
    private void OnEquipClick()
    {
        var val_15;
        int val_16;
        GameAudio.PlayButtonSound();
        BattleEnhancerAssets val_1 = BattleEnhancerCollection.Get(type:  this.enhancerType);
        val_15 = null;
        val_15 = null;
        int val_2 = DataStructs.UserDataDictionary.Items.GetEnhancerCount(type:  this.enhancerType, level:  this.level, defaultValue:  0);
        if(val_2 == 0)
        {
            goto label_8;
        }
        
        if(this.isActivedItem == false)
        {
            goto label_9;
        }
        
        val_16 = 0;
        goto label_10;
        label_8:
        object[] val_4 = new object[2];
        val_4[0] = LanguageManager.GetText(key:  "Lk.BattleEnhancer." + this.enhancerType).ToUpper();
        val_4[1] = this.level.ToString();
        BattleEnhancerDialog.Show(title:  LanguageManager.GetText(key:  "LK.BattleEnahncer.TopUpNowTitle"), name:  LanguageManager.GetTextFormat(key:  "LK.BattleEnahncer.TopUpNowTitle2", list:  val_4), message:  LanguageManager.GetText(key:  "LK.BattleEnahncer.TopUpNow"), yellowButtonTitle:  LanguageManager.GetText(key:  "LK.Yes"), grayButtonTitle:  LanguageManager.GetText(key:  "LK.No"), onYellowButton:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerLevelPanel::OnAddButtonClick()), onGrayButton:  0);
        return;
        label_9:
        InkWars.Model.BattleEnhancerType val_14 = this.enhancerType;
        val_14 = val_14 * 1000000;
        val_16 = val_14 + (this.level * 10000);
        label_10:
        val_2.ApplyEquip(id:  val_16);
    }
    private void ApplyEquip(int id)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  id);
        DataStructs.UserDataDictionary.Settings.SelectedBattleEnhancer = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        val_3 = null;
        val_3 = null;
        BattleEnhancerLevelPanel.OnEquipStateChangedEvent.Invoke();
        if(id == 0)
        {
                return;
        }
        
        BattleEnhancerInventory.Hide();
    }
    public BattleEnhancerLevelPanel()
    {
        this.level = 1;
        UnityEngine.Color val_1 = UnityEngine.Color.green;
        this.activeColor = val_1;
        mem[1152921528877390300] = val_1.g;
        mem[1152921528877390304] = val_1.b;
        mem[1152921528877390308] = val_1.a;
    }
    private static BattleEnhancerLevelPanel()
    {
        BattleEnhancerLevelPanel.OnEquipStateChangedEvent = new UnityEngine.Events.UnityEvent();
    }

}
