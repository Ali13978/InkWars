using UnityEngine;
public class PearlBuyButton : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text priceText;
    public UnityEngine.UI.Button buyButton;
    public UnityEngine.UI.Image icon;
    public UnityEngine.GameObject[] enabledOnSuccess;
    public UnityEngine.GameObject[] disabledOnSuccess;
    private Currency currency;
    private IAPItemIds item;
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt price;
    private string itemName;
    public UnityEngine.Events.UnityEvent OnPurchaseDone;
    
    // Methods
    public void Setup(string aNewItemName, IAPItemIds aNewItem, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt aNewPrice, Currency aNewCurrency)
    {
        int val_13 = aNewPrice.currentCryptoKey;
        this.itemName = aNewItemName;
        this.item = aNewItem;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13, hiddenValue = aNewPrice.hiddenValue, fakeValue = aNewPrice.fakeValue, inited = aNewPrice.inited}));
        this.price = val_2;
        mem[1152921529022463456] = val_2.fakeValue;
        mem[1152921529022463460] = val_2.inited;
        this.currency = aNewCurrency;
        this.buyButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PearlBuyButton::OnPurchaseClick()));
        this.buyButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PearlBuyButton::OnPurchaseClick()));
        string val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_13, hiddenValue = aNewPrice.hiddenValue, fakeValue = aNewPrice.fakeValue, inited = aNewPrice.inited}).ToString();
        if(this.priceText != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_15:
        if(this.priceText.Length >= 4)
        {
            goto label_11;
        }
        
        val_13 = " " + this.priceText;
        label_8:
        if((System.String.IsNullOrEmpty(value:  this.priceText)) == false)
        {
            goto label_15;
        }
        
        label_11:
        CurrencyData val_12 = CurrencyCollection.Get(cur:  this.currency);
        this.icon.sprite = val_12.icon;
    }
    private void OnPurchaseClick()
    {
        Currency val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        string val_43;
        string val_44;
        UnityEngine.Events.UnityAction val_45;
        string val_46;
        string val_47;
        string val_48;
        string val_49;
        GameAudio.PlayButtonSound();
        val_37 = this.currency;
        if(val_37 == 1)
        {
            goto label_3;
        }
        
        if(val_37 != 0)
        {
            goto label_4;
        }
        
        val_38 = null;
        val_38 = null;
        val_39 = DataStructs.UserDataDictionary.Items;
        val_40 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = val_39.Pearls;
        goto label_8;
        label_3:
        val_41 = null;
        val_41 = null;
        val_39 = DataStructs.UserDataDictionary.Items;
        val_40 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = val_39.Shells;
        label_8:
        val_37 = this.currency;
        val_42 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited});
        goto label_14;
        label_4:
        val_42 = 0;
        label_14:
        CurrencyData val_4 = CurrencyCollection.Get(cur:  val_37);
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = X22, inited = X22})) <= val_42)
        {
            goto label_19;
        }
        
        object[] val_6 = new object[1];
        val_6[0] = LanguageManager.GetText(key:  "LK.rewards." + val_4.TitleCasePluralName);
        val_43 = LanguageManager.GetTextFormat(key:  "LK.Buy.InsufficientMsg1", list:  val_6);
        object[] val_11 = new object[1];
        val_11[0] = LanguageManager.GetText(key:  "LK.rewards." + val_4.TitleCasePluralName);
        object[] val_16 = new object[1];
        val_16[0] = LanguageManager.GetText(key:  "LK.rewards." + val_4.TitleCasePluralName);
        val_44 = LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close");
        UnityEngine.Events.UnityAction val_22 = null;
        val_45 = val_22;
        val_22 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PearlBuyButton::OnGetPearls());
        val_46 = val_43;
        val_47 = LanguageManager.GetTextFormat(key:  "LK.Buy.InsufficientMsg2", list:  val_11);
        val_48 = LanguageManager.GetTextFormat(key:  "LK.Buy.InsufficientMsg3", list:  val_16);
        goto label_35;
        label_19:
        object[] val_23 = new object[4];
        if((System.String.IsNullOrEmpty(value:  this.itemName)) == false)
        {
            goto label_36;
        }
        
        val_49 = LanguageManager.GetText(key:  "LK.BuyButton.MsgThisItem");
        if(val_23 != null)
        {
            goto label_39;
        }
        
        goto label_38;
        label_36:
        val_49 = this.itemName;
        if(val_23 != null)
        {
            goto label_39;
        }
        
        label_38:
        label_39:
        val_23[0] = val_49;
        val_23[1] = "<br>";
        val_23[2] = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = 78406864, inited = true}).ToString();
        val_23[3] = LanguageManager.GetText(key:  "LK.rewards." + val_4.TitleCasePluralName);
        val_43 = LanguageManager.GetText(key:  "LK.Customikzation.PurchaseConfirm1");
        val_44 = LanguageManager.GetText(key:  "LK.MenuTitle.Logout.Cancel");
        UnityEngine.Events.UnityAction val_35 = null;
        val_45 = val_35;
        val_35 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PearlBuyButton::OnPurchase());
        val_46 = val_43;
        val_47 = LanguageManager.GetTextFormat(key:  "LK.BuyButton.Msg", list:  val_23);
        val_48 = LanguageManager.GetText(key:  "LK.Buy");
        label_35:
        DialogPanel val_36 = DialogManager.ShowConfirmDialog(title:  val_46, message:  val_47, confirmButtonTitle:  val_48, cancelButtonTitle:  val_44, onConfirmCallback:  val_35, onCancelCallback:  0);
    }
    private void OnGetPearls()
    {
        GameAudio.PlayButtonSound();
        ExpressPurchaseCurrencyCanvas.Show(currency:  this.currency);
    }
    private void OnPurchase()
    {
        var val_9;
        var val_10;
        var val_11;
        if(this.currency == 1)
        {
            goto label_1;
        }
        
        if(this.currency != 0)
        {
            goto label_9;
        }
        
        val_9 = null;
        val_9 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Items.Pearls;
        int val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = val_1.fakeValue, inited = val_1.inited});
        val_3 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) - val_3;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_3);
        DataStructs.UserDataDictionary.Items.Pearls = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
        goto label_9;
        label_1:
        val_10 = null;
        val_10 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.Shells;
        int val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = val_5.fakeValue, inited = val_5.inited});
        val_7 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited})) - val_7;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_7);
        DataStructs.UserDataDictionary.Items.Shells = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_8.currentCryptoKey, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, inited = val_8.inited};
        label_9:
        UnityIAPHandler.OnPurchaseComplete(id:  this.item, isRestoreMode:  false, onDone:  0);
        GameAudio.PlayPurchaseSound();
        val_11 = null;
        val_11 = null;
        GGPPurchasingManager.OnPurchaseSuccess.Invoke(arg0:  this.item);
        this.OnPurchaseDone.Invoke();
        this.OnPurchaseDone.SetGameObjectsEnable(objs:  this.enabledOnSuccess, enable:  true);
        this.OnPurchaseDone.SetGameObjectsEnable(objs:  this.disabledOnSuccess, enable:  false);
    }
    private void SetGameObjectsEnable(UnityEngine.GameObject[] objs, bool enable)
    {
        UnityEngine.GameObject val_3;
        if(objs == null)
        {
                return;
        }
        
        if(objs.Length < 1)
        {
                return;
        }
        
        do
        {
            val_3 = objs[0];
            if(0 != val_3)
        {
                val_3.SetActive(value:  enable);
        }
        
        }
        while((0 + 1) < objs.Length);
    
    }
    public PearlBuyButton()
    {
        this.OnPurchaseDone = new UnityEngine.Events.UnityEvent();
    }

}
