using UnityEngine;
public class GGPPurchasingManager
{
    // Fields
    private static GGPPurchasingManager _inst;
    private System.Collections.Generic.List<GGPPurchasingManager.GGPPurchaseItem> itemsList;
    public static GGPPurchasingManager.PurchaseSuccessEvent OnPurchaseSuccess;
    public static GGPPurchasingManager.PurchaseFailEvent OnPurchaseFail;
    public static UnityEngine.Events.UnityEvent OnRestorePurchaseStart;
    public static UnityEngine.Events.UnityEvent OnInit;
    public static GGPPurchasingManager.OnRestorePurchaseDoneEvent OnRestorePurchaseDone;
    private bool _isPurchasing;
    
    // Properties
    public static GGPPurchasingManager instance { get; }
    
    // Methods
    public static GGPPurchasingManager get_instance()
    {
        GGPPurchasingManager val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(GGPPurchasingManager._inst == null)
        {
                GGPPurchasingManager val_1 = null;
            val_2 = val_1;
            val_1 = new GGPPurchasingManager();
            val_4 = null;
            val_4 = null;
            GGPPurchasingManager._inst = val_2;
            val_3 = null;
        }
        
        val_3 = null;
        return (GGPPurchasingManager)GGPPurchasingManager._inst;
    }
    public static bool IsAailableToPurchase(string id)
    {
        if((GGPPurchasingManager.instance.GetProduct(id:  id)) == null)
        {
                return (bool)(val_2.purchased != true) ? 1 : 0;
        }
        
        return (bool)(val_2.purchased != true) ? 1 : 0;
    }
    public void UpdateProducts()
    {
        NFUser.current.clientUser.GetProductList(callback:  new UnityEngine.Events.UnityAction<BestHTTP.HTTPRequest, BestHTTP.HTTPResponse>(object:  this, method:  System.Void GGPPurchasingManager::<UpdateProducts>b__15_0(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse res)));
    }
    public void InitializePurchasing()
    {
        if(this.IsInitialized() != false)
        {
                return;
        }
        
        this.UpdateProducts();
    }
    public bool IsInitialized()
    {
        return (bool)(this.itemsList.Count > 0) ? 1 : 0;
    }
    public void BuyProductID(int skuIndex)
    {
        this.BuyProductId(id:  IapItemInfo.GetPlatformIdFromNumberbasedKey(sku:  skuIndex));
    }
    public void BuyProductID(IAPItemIds iapItemIds, UnityEngine.Events.UnityAction<string, bool> callback)
    {
        this.BuyProductId(id:  IapItemInfo.GetPlatformId(id:  iapItemIds, isGGPPurchase:  false));
    }
    public string GetPrice(IAPItemIds id)
    {
        var val_8;
        var val_9;
        val_8 = this;
        if((this.GetProduct(id:  IapItemInfo.GetPlatformId(id:  id, isGGPPurchase:  false))) == null)
        {
                return (string)val_9;
        }
        
        val_9 = val_2.price;
        val_8 = ???;
        goto typeof(System.String).__il2cppRuntimeField_158;
    }
    private GGPPurchasingManager.GGPPurchaseItem GetProduct(string id)
    {
        System.RuntimeTypeHandle val_4;
        string val_5;
        var val_6;
        val_5 = id;
        List.Enumerator<T> val_1 = this.itemsList.GetEnumerator();
        label_5:
        if(((-1970006312) & 1) == 0)
        {
            goto label_2;
        }
        
        val_6 = 0.InitialType;
        val_4 = val_2._impl;
        if((val_4.Equals(value:  val_5)) == false)
        {
            goto label_5;
        }
        
        goto label_6;
        label_2:
        val_6 = 0;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<GGPPurchaseItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
        return (GGPPurchaseItem);
    }
    private void BuyProductId(string id)
    {
        System.Runtime.CompilerServices.AsyncVoidMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();
    }
    public void RestorePurchases()
    {
        var val_5;
        var val_6;
        if(this.IsInitialized() != false)
        {
                val_5 = null;
            val_5 = null;
            GGPPurchasingManager.OnRestorePurchaseStart.Invoke();
            UnityEngine.Debug.Log(message:  "RestorePurchases FAIL. Not supported on this platform. Current = "("RestorePurchases FAIL. Not supported on this platform. Current = ") + UnityEngine.Application.platform);
            this.RestoreAllPurchasedItems();
            GGPPurchasingManager.OnRestorePurchaseDone.Invoke(arg0:  true);
            return;
        }
        
        UnityEngine.Debug.Log(message:  "RestorePurchases FAIL. Not initialized.");
        DialogPanel val_4 = DialogManager.Show(title:  "Error", message:  "Restore Purchases FAIL. IAP Not initialized.", cancelButtonTitle:  "Close", onCancelCallback:  0);
        val_6 = null;
        val_6 = null;
        GGPPurchasingManager.OnRestorePurchaseDone.Invoke(arg0:  false);
    }
    private void RestoreAllPurchasedItems()
    {
        List.Enumerator<T> val_1 = this.itemsList.GetEnumerator();
        label_7:
        if(((-1969561240) & 1) == 0)
        {
            goto label_2;
        }
        
        System.Type val_2 = 0.InitialType;
        if(0 == 0)
        {
            goto label_7;
        }
        
        UnityIAPHandler.OnPurchaseComplete(sku:  val_2._impl, isRestoreMode:  true, onDone:  0);
        UnityEngine.Debug.Log(message:  "Restore item " + val_2._impl);
        goto label_7;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<GGPPurchaseItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public GGPPurchasingManager()
    {
        this.itemsList = new System.Collections.Generic.List<GGPPurchaseItem>();
    }
    private static GGPPurchasingManager()
    {
        GGPPurchasingManager.OnPurchaseSuccess = new GGPPurchasingManager.PurchaseSuccessEvent();
        GGPPurchasingManager.OnPurchaseFail = new GGPPurchasingManager.PurchaseFailEvent();
        GGPPurchasingManager.OnRestorePurchaseStart = new UnityEngine.Events.UnityEvent();
        GGPPurchasingManager.OnInit = new UnityEngine.Events.UnityEvent();
        GGPPurchasingManager.OnRestorePurchaseDone = new GGPPurchasingManager.OnRestorePurchaseDoneEvent();
    }
    private void <UpdateProducts>b__15_0(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse res)
    {
        GGPPurchasingManager val_22;
        System.Collections.Generic.IEnumerator<T> val_24;
        var val_27;
        var val_29;
        val_22 = this;
        if(res == null)
        {
            goto label_1;
        }
        
        if(res.IsSuccess == false)
        {
            goto label_2;
        }
        
        label_9:
        var val_18 = 0;
        val_18 = val_18 + 1;
        goto label_8;
        label_1:
        if(0.IsSuccess == true)
        {
            goto label_9;
        }
        
        label_2:
        UnityEngine.Debug.Log(message:  "OnInitializeFailed InitializationFailureReason:"("OnInitializeFailed InitializationFailureReason:") + res.Message);
        return;
        label_8:
        val_24 = Newtonsoft.Json.Linq.JObject.Parse(json:  res.DataAsText).GetValue(propertyName:  "products").GetEnumerator();
        label_27:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_24.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        T val_13 = val_24.Current;
        new GGPPurchasingManager.GGPPurchaseItem() = new System.Object();
        if(new GGPPurchasingManager.GGPPurchaseItem() != null)
        {
                .price = val_13;
            .quantity = val_13;
            .expires = val_13;
            .id = val_13;
            .name = val_13;
            .purchased = val_13 & 1;
        }
        else
        {
                mem[16] = val_13;
            mem[24] = val_13;
            mem[40] = val_13;
            mem[48] = val_13 & 1;
            .quantity = val_13;
            mem[56] = val_13;
        }
        
        .app_id = val_13;
        mem[1152921528407537632].Add(item:  new GGPPurchasingManager.GGPPurchaseItem());
        goto label_27;
        label_17:
        val_27 = 0;
        if(val_24 == null)
        {
            
        }
        else
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_24.Dispose();
        }
        
        val_29 = null;
        val_29 = null;
        GGPPurchasingManager.OnInit.Invoke();
        this.RestoreAllPurchasedItems();
    }

}
