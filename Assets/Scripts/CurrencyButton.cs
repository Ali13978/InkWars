using UnityEngine;
public class CurrencyButton : MonoBehaviour
{
    // Fields
    public Currency currencyType;
    public bool enableExpressPurchase;
    private TMPro.TextMeshProUGUI countTxt;
    private UnityEngine.UI.Button btn;
    
    // Methods
    private void OnEnable()
    {
        var val_10;
        var val_11;
        var val_12;
        UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
        this.btn = val_1;
        if(0 != val_1)
        {
                this.btn.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CurrencyButton::OnClick()));
            this.btn.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CurrencyButton::OnClick()));
        }
        
        if(this.currencyType == 2)
        {
                val_10 = null;
            val_10 = null;
            GGPPurchasingManager.OnPurchaseSuccess.AddListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void CurrencyButton::OnGGPPurchaseSuccess(IAPItemIds item)));
        }
        
        this.UpdateCountText();
        val_11 = null;
        val_11 = null;
        DataStructs.UserDataDictionary.OnCurrencyChanged.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CurrencyButton::UpdateCountText()));
        val_12 = null;
        val_12 = null;
        CryptoCurrency.OnCryptoCurrencyChanged.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CurrencyButton::UpdateCountText()));
    }
    private void OnDisable()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        DataStructs.UserDataDictionary.OnCurrencyChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CurrencyButton::UpdateCountText()));
        val_5 = null;
        val_5 = null;
        CryptoCurrency.OnCryptoCurrencyChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CurrencyButton::UpdateCountText()));
        if(this.currencyType != 2)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void CurrencyButton::OnGGPPurchaseSuccess(IAPItemIds item)));
    }
    private void OnGGPPurchaseSuccess(IAPItemIds item)
    {
        var val_3;
        MMOCClientUser val_1 = MMOCUser.current;
        val_3 = null;
        val_3 = null;
        if((CurrencyButton.<>c.<>9__6_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        val_1.GetUserProfile(onGetUserProfileDone:  CurrencyButton.<>c.<>9__6_0);
        return;
        label_3:
        CurrencyButton.<>c.<>9__6_0 = new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  CurrencyButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Void CurrencyButton.<>c::<OnGGPPurchaseSuccess>b__6_0(MMOCClientUser.MMOCUserProfile profile));
        if(val_1 != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void UpdateCountText()
    {
        TMPro.TextMeshProUGUI val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        string val_15;
        var val_16;
        val_10 = this;
        if(0 == this.countTxt)
        {
                return;
        }
        
        if(this.currencyType == 2)
        {
            goto label_4;
        }
        
        if(this.currencyType == 1)
        {
            goto label_5;
        }
        
        if(this.currencyType != 0)
        {
                return;
        }
        
        val_10 = this.countTxt;
        val_11 = null;
        val_11 = null;
        val_12 = DataStructs.UserDataDictionary.Items;
        val_13 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = val_12.Pearls;
        goto label_10;
        label_4:
        val_14 = null;
        decimal val_3 = CryptoCurrency.CryptoCurency;
        decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, d2:  new System.Decimal());
        decimal val_5 = System.Math.Truncate(d:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
        decimal val_6 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, d2:  new System.Decimal());
        val_10 = System.String.Format(format:  "{0:0.00}", arg0:  val_6);
        val_15 = val_10;
        goto label_18;
        label_5:
        val_10 = this.countTxt;
        val_16 = null;
        val_16 = null;
        val_12 = DataStructs.UserDataDictionary.Items;
        val_13 = 0;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_8 = val_12.Shells;
        label_10:
        val_15 = val_8.currentCryptoKey.ToString();
        label_18:
        val_10.text = val_15;
    }
    private void OnClick()
    {
        if(this.enableExpressPurchase == false)
        {
                return;
        }
        
        GameAudio.PlayButtonSound();
        ExpressPurchaseCurrencyCanvas.Show(currency:  this.currencyType);
    }
    public CurrencyButton()
    {
        this.enableExpressPurchase = true;
    }

}
