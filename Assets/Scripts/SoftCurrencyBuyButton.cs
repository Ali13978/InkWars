using UnityEngine;
public class SoftCurrencyBuyButton : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Button buyButton;
    public bool confirmPurchase;
    public UnityEngine.GameObject[] enabledOnSuccess;
    public UnityEngine.GameObject[] disabledOnSuccess;
    public UnityEngine.UI.Text priceText;
    public TMPro.TextMeshProUGUI priceTextMesh;
    public UnityEngine.UI.Image icon;
    private Currency currency;
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt price;
    private string itemName;
    private System.Action onPurchaseDoneAction;
    private SoftCurrencyBuyButton.CustomCanBuyFunc customBuyCheck;
    private System.Action onCustomBuyCheckFailAction;
    private string title;
    private string message;
    
    // Methods
    public void Setup(string aNewItemName, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt aNewPrice, Currency aNewCurrency, System.Action purchaseDoneCallback, string customTitle, string customMessage)
    {
        TMPro.TextMeshProUGUI val_18;
        UnityEngine.UI.Image val_19;
        this.itemName = aNewItemName;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewPrice.currentCryptoKey, hiddenValue = aNewPrice.hiddenValue, fakeValue = aNewPrice.fakeValue, inited = aNewPrice.inited}));
        this.price = val_2;
        mem[1152921529029284716] = val_2.fakeValue;
        mem[1152921529029284720] = val_2.inited;
        this.currency = aNewCurrency;
        this.title = customTitle;
        this.message = customMessage;
        this.buyButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SoftCurrencyBuyButton::OnPurchaseClick()));
        this.buyButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SoftCurrencyBuyButton::OnPurchaseClick()));
        if(0 == this.priceText)
        {
            goto label_16;
        }
        
        string val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewPrice.currentCryptoKey, hiddenValue = aNewPrice.hiddenValue, fakeValue = aNewPrice.fakeValue, inited = aNewPrice.inited}).ToString();
        if(this.priceText != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_20:
        if(this.priceText.Length >= 4)
        {
            goto label_16;
        }
        
        string val_11 = " " + this.priceText;
        label_13:
        if((System.String.IsNullOrEmpty(value:  this.priceText)) == false)
        {
            goto label_20;
        }
        
        label_16:
        val_18 = this.priceTextMesh;
        if(0 != val_18)
        {
                val_18 = this.priceTextMesh;
            val_18.text = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = aNewPrice.currentCryptoKey, hiddenValue = aNewPrice.hiddenValue, fakeValue = aNewPrice.fakeValue, inited = aNewPrice.inited}).ToString();
        }
        
        val_19 = this.icon;
        if(0 != val_19)
        {
                CurrencyData val_17 = CurrencyCollection.Get(cur:  this.currency);
            val_19 = this.icon;
            val_19.sprite = val_17.icon;
        }
        
        this.onPurchaseDoneAction = purchaseDoneCallback;
    }
    public void SetCustomCanBuyCheck(SoftCurrencyBuyButton.CustomCanBuyFunc aNewCustomBuyCheckFunc, System.Action OnCustomBuyCheckFail)
    {
        this.customBuyCheck = aNewCustomBuyCheckFunc;
        this.onCustomBuyCheckFailAction = OnCustomBuyCheckFail;
    }
    private void OnPurchaseClick()
    {
        object val_48;
        Currency val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        string val_54;
        var val_55;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_56;
        UnityEngine.Events.UnityAction val_57;
        string val_58;
        string val_59;
        string val_60;
        string val_61;
        object val_62;
        val_48 = this;
        GameAudio.PlayButtonSound();
        if(this.customBuyCheck != null)
        {
                if((this.customBuyCheck.Invoke() != true) && (this.onCustomBuyCheckFailAction != null))
        {
                this.onCustomBuyCheckFailAction.Invoke();
            return;
        }
        
        }
        
        val_49 = this.currency;
        if(val_49 == 1)
        {
            goto label_7;
        }
        
        if(val_49 != 0)
        {
            goto label_8;
        }
        
        val_50 = null;
        val_50 = null;
        val_51 = DataStructs.UserDataDictionary.Items;
        val_52 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = val_51.Pearls;
        goto label_12;
        label_7:
        val_53 = null;
        val_53 = null;
        val_51 = DataStructs.UserDataDictionary.Items;
        val_52 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = val_51.Shells;
        label_12:
        val_49 = this.currency;
        val_54 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited});
        goto label_18;
        label_8:
        val_54 = 0;
        label_18:
        CurrencyData val_5 = CurrencyCollection.Get(cur:  val_49);
        val_55 = 1152921505062117376;
        val_56 = this.price;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_56, hiddenValue = val_56, fakeValue = X22, inited = X22})) <= val_54)
        {
            goto label_23;
        }
        
        object[] val_7 = new object[1];
        val_7[0] = LanguageManager.GetText(key:  "LK.rewards." + val_5.TitleCasePluralName);
        val_54 = LanguageManager.GetTextFormat(key:  "LK.Buy.InsufficientMsg1", list:  val_7);
        object[] val_12 = new object[1];
        val_12[0] = LanguageManager.GetText(key:  "LK.rewards." + val_5.TitleCasePluralName);
        object[] val_17 = new object[1];
        val_17[0] = LanguageManager.GetText(key:  "LK.rewards." + val_5.TitleCasePluralName);
        val_55 = 1152921504859136000;
        val_56 = LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close");
        UnityEngine.Events.UnityAction val_23 = null;
        val_57 = val_23;
        val_23 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SoftCurrencyBuyButton::OnGetMoreCurrency());
        UnityEngine.Events.UnityAction val_24 = null;
        val_48 = val_24;
        val_24 = new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void GameAudio::PlayButtonSound());
        val_58 = val_54;
        val_59 = LanguageManager.GetTextFormat(key:  "LK.Buy.InsufficientMsg2", list:  val_12);
        val_60 = LanguageManager.GetTextFormat(key:  "LK.Buy.InsufficientMsg3", list:  val_17);
        goto label_39;
        label_23:
        if(this.confirmPurchase == false)
        {
            goto label_40;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.title)) == false)
        {
            goto label_41;
        }
        
        val_54 = LanguageManager.GetText(key:  "LK.Customikzation.PurchaseConfirm1");
        goto label_42;
        label_40:
        this.OnPurchase();
        return;
        label_41:
        val_54 = this.title;
        label_42:
        if((System.String.IsNullOrEmpty(value:  this.message)) != false)
        {
                string[] val_28 = new string[7];
            val_28[0] = "Buy ";
            val_61 = val_48;
            val_28[1] = ((System.String.IsNullOrEmpty(value:  this.itemName)) != true) ? " this item " : (this.itemName);
            val_28[2] = "<br>with ";
            val_28[3] = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = X24, inited = X24}).ToString();
            val_28[4] = " ";
            val_28[5] = val_5.pluralName;
            val_28[6] = "?";
            string val_33 = +val_28;
        }
        else
        {
                val_61 = this.itemName;
        }
        
        object[] val_34 = new object[4];
        if((System.String.IsNullOrEmpty(value:  mem[this.itemName])) == false)
        {
            goto label_71;
        }
        
        val_62 = LanguageManager.GetText(key:  "LK.BuyButton.MsgThisItem");
        if(val_34 != null)
        {
            goto label_74;
        }
        
        goto label_73;
        label_71:
        val_62 = mem[this.itemName];
        if(val_34 != null)
        {
            goto label_74;
        }
        
        label_73:
        label_74:
        val_34[0] = val_62;
        val_34[1] = "<br>";
        val_34[2] = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = 1152921505062117376, inited = false}).ToString();
        val_34[3] = LanguageManager.GetText(key:  "LK.rewards." + val_5.TitleCasePluralName);
        val_55 = 1152921504859136000;
        val_56 = LanguageManager.GetText(key:  "LK.MenuTitle.Logout.Cancel");
        UnityEngine.Events.UnityAction val_45 = null;
        val_57 = val_45;
        val_45 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SoftCurrencyBuyButton::OnPurchase());
        UnityEngine.Events.UnityAction val_46 = null;
        val_48 = val_46;
        val_46 = new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void GameAudio::PlayButtonSound());
        val_58 = val_54;
        val_59 = LanguageManager.GetTextFormat(key:  "LK.BuyButton.Msg", list:  val_34);
        val_60 = LanguageManager.GetText(key:  "LK.Buy");
        label_39:
        DialogPanel val_47 = DialogManager.ShowConfirmDialog(title:  val_58, message:  val_59, confirmButtonTitle:  val_60, cancelButtonTitle:  val_56, onConfirmCallback:  val_45, onCancelCallback:  val_46);
    }
    private void OnGetMoreCurrency()
    {
        GameAudio.PlayButtonSound();
        ExpressPurchaseCurrencyCanvas.Show(currency:  this.currency);
    }
    private void OnPurchase()
    {
        var val_9;
        int val_10;
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
        val_10 = val_4.currentCryptoKey;
        DataStructs.UserDataDictionary.Items.Pearls = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, inited = val_4.inited};
        goto label_9;
        label_1:
        val_11 = null;
        val_11 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.Shells;
        int val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = val_5.fakeValue, inited = val_5.inited});
        val_7 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited})) - val_7;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  val_7);
        val_10 = val_8.currentCryptoKey;
        DataStructs.UserDataDictionary.Items.Shells = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10, hiddenValue = val_8.hiddenValue, fakeValue = val_8.fakeValue, inited = val_8.inited};
        label_9:
        if(this.onPurchaseDoneAction != null)
        {
                this.onPurchaseDoneAction.Invoke();
        }
        
        GameAudio.PlayPurchaseSound();
        this.SetGameObjectsEnable(objs:  this.enabledOnSuccess, enable:  true);
        this.SetGameObjectsEnable(objs:  this.disabledOnSuccess, enable:  false);
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
    public SoftCurrencyBuyButton()
    {
        this.confirmPurchase = true;
    }

}
