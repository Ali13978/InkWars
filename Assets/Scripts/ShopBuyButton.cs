using UnityEngine;
public class ShopBuyButton : MonoBehaviour
{
    // Fields
    public IAPItemIds itemId;
    public UnityEngine.Events.UnityEvent OnPurcahseSuccessEvent;
    public bool autoAddButtonEvent;
    public bool autoSetupPrice;
    public bool enableIAPCallback;
    public UnityEngine.GameObject[] enabledOnSuccess;
    public UnityEngine.GameObject[] disabledOnSuccess;
    public UnityEngine.GameObject[] enabledOnFail;
    public UnityEngine.GameObject[] disabledOnFail;
    public bool disableGameObjectOnSuccess;
    public bool enableAdditionalPriceSetup;
    public UnityEngine.UI.Text additionalPriceText;
    public TMPro.TextMeshProUGUI additionalPriceTMText;
    private string price;
    
    // Methods
    public void ResetButton()
    {
        var val_7;
        UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
        if(0 != val_1)
        {
                val_1.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopBuyButton::OnClickBuy()));
        }
        
        val_7 = null;
        val_7 = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void ShopBuyButton::OnPurchaseDone(IAPItemIds id)));
        GGPPurchasingManager.OnPurchaseFail.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds, System.String>(object:  this, method:  System.Void ShopBuyButton::OnPurchaseNotDone(IAPItemIds id, string reason)));
        this.Refresh();
    }
    protected virtual void OnEnable()
    {
        GGPPurchasingManager.instance.InitializePurchasing();
        GGPPurchasingManager.OnInit.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void ShopBuyButton::Refresh()));
        this.Refresh();
    }
    public void Refresh()
    {
        string val_22;
        var val_23;
        var val_24;
        if(this.itemId == 0)
        {
                return;
        }
        
        val_22 = GGPPurchasingManager.instance;
        string val_2 = val_22.GetPrice(id:  this.itemId);
        this.price = val_2;
        if((System.Decimal.TryParse(s:  val_2, result: out  new System.Decimal())) != true)
        {
                DialogPanel val_5 = DialogManager.Show(title:  LanguageManager.GetText(key:  "LK.Error"), message:  "Price conversion failed", cancelButtonTitle:  0, onCancelCallback:  0);
        }
        
        System.Globalization.NumberFormatInfo val_6 = new System.Globalization.NumberFormatInfo();
        val_6.NumberDecimalDigits = 2;
        this.price = 0.ToString(format:  "N", provider:  val_6);
        if(this.autoSetupPrice != false)
        {
                if((0 != (this.GetComponentInChildren<UnityEngine.UI.Text>())) && (this.itemId != 0))
        {
                val_22 = this.price;
        }
        
        }
        
        if(this.enableAdditionalPriceSetup != false)
        {
                val_23 = 1152921504858337280;
            if((0 != this.additionalPriceText) && (this.itemId != 0))
        {
                val_22 = this.price;
        }
        
            if((0 != this.additionalPriceTMText) && (this.itemId != 0))
        {
                val_22 = this.price;
            this.additionalPriceTMText.text = val_22;
        }
        
        }
        
        if(this.enableIAPCallback != false)
        {
                val_24 = null;
            val_24 = null;
            GGPPurchasingManager.OnPurchaseSuccess.AddListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void ShopBuyButton::OnPurchaseDone(IAPItemIds id)));
            UnityEngine.Events.UnityAction<IAPItemIds, System.String> val_13 = null;
            val_22 = val_13;
            val_13 = new UnityEngine.Events.UnityAction<IAPItemIds, System.String>(object:  this, method:  System.Void ShopBuyButton::OnPurchaseNotDone(IAPItemIds id, string reason));
            GGPPurchasingManager.OnPurchaseFail.AddListener(call:  val_13);
        }
        
        if(this.autoAddButtonEvent == false)
        {
                return;
        }
        
        UnityEngine.UI.Button val_14 = this.GetComponent<UnityEngine.UI.Button>();
        if(0 == val_14)
        {
                return;
        }
        
        val_23 = 1152921504859136000;
        val_14.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopBuyButton::OnClickBuy()));
        val_14.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopBuyButton::OnClickBuy()));
        UnityEngine.Events.UnityAction val_21 = null;
        val_22 = val_21;
        val_21 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopBuyButton::OnClickBuy());
        val_14.onClick.AddListener(call:  val_21);
    }
    protected virtual void OnDisable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void ShopBuyButton::OnPurchaseDone(IAPItemIds id)));
        GGPPurchasingManager.OnPurchaseFail.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds, System.String>(object:  this, method:  System.Void ShopBuyButton::OnPurchaseNotDone(IAPItemIds id, string reason)));
        GGPPurchasingManager.OnInit.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void ShopBuyButton::Refresh()));
        UnityEngine.UI.Button val_4 = this.GetComponent<UnityEngine.UI.Button>();
        if(0 == val_4)
        {
                return;
        }
        
        val_4.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopBuyButton::OnClickBuy()));
    }
    private void OnPurchaseDone(IAPItemIds id)
    {
        if(this.itemId != id)
        {
                return;
        }
        
        this.SetGameObjectsEnable(objs:  this.disabledOnSuccess, enable:  false);
        this.SetGameObjectsEnable(objs:  this.enabledOnSuccess, enable:  true);
        this.OnPurcahseSuccessEvent.Invoke();
        if(this.disableGameObjectOnSuccess == false)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void OnPurchaseNotDone(IAPItemIds id, string reason)
    {
        if(this.itemId != id)
        {
                return;
        }
        
        if(this.itemId == 0)
        {
                return;
        }
        
        this.SetGameObjectsEnable(objs:  this.disabledOnFail, enable:  false);
        this.SetGameObjectsEnable(objs:  this.enabledOnFail, enable:  true);
        this = ???;
        goto typeof(ShopBuyButton).__il2cppRuntimeField_198;
    }
    protected virtual void OnPurchaseSuccess(IAPItemIds id)
    {
    
    }
    protected virtual void OnPruchaseFail(IAPItemIds id, string reason)
    {
    
    }
    protected virtual void OnBeforeClickBuy()
    {
    
    }
    private void OnPurchase()
    {
        GGPPurchasingManager.instance.BuyProductID(iapItemIds:  this.itemId, callback:  0);
    }
    private void OnClickBuy()
    {
        string val_2 = "Buy this item <br>with "("Buy this item <br>with ") + this.price + " SGC?"(" SGC?");
        object[] val_3 = new object[4];
        string val_4 = LanguageManager.GetText(key:  "LK.BuyButton.MsgThisItem");
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_4 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_4 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_4;
        val_3[1] = "<br>";
        val_3[2] = this.price;
        val_3[3] = "SGC";
        DialogPanel val_10 = DialogManager.ShowConfirmDialog(title:  LanguageManager.GetText(key:  "LK.Customikzation.PurchaseConfirm1"), message:  LanguageManager.GetTextFormat(key:  "LK.BuyButton.Msg", list:  val_3), confirmButtonTitle:  LanguageManager.GetText(key:  "LK.Buy"), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Logout.Cancel"), onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ShopBuyButton::OnPurchase()), onCancelCallback:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void GameAudio::PlayButtonSound()));
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
    public ShopBuyButton()
    {
        this.OnPurcahseSuccessEvent = new UnityEngine.Events.UnityEvent();
        this.autoAddButtonEvent = true;
        this.autoSetupPrice = true;
    }

}
