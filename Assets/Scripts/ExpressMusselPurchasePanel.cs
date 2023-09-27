using UnityEngine;
public class ExpressMusselPurchasePanel : MonoBehaviour
{
    // Fields
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt count;
    private CodeStage.AntiCheat.ObscuredTypes.ObscuredInt price;
    private bool watchAds;
    private SoftCurrencyBuyButton buyButton;
    private UnityEngine.UI.Text countTxt;
    
    // Properties
    public string itemName { get; }
    
    // Methods
    public string get_itemName()
    {
        return this.count.ToString() + " Mussels";
    }
    public void SetupBuyPrice(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt aNewCount, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt aNewPrice)
    {
        this.watchAds = false;
        this.count = aNewCount;
        mem[1152921529013903920] = aNewCount.fakeValue;
        mem[1152921529013903924] = aNewCount.inited;
        this.price = aNewPrice;
        mem[1152921529013903936] = aNewPrice.fakeValue;
        mem[1152921529013903940] = aNewPrice.inited;
        this.buyButton.Setup(aNewItemName:  this.itemName, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, fakeValue = aNewPrice.currentCryptoKey, inited = aNewPrice.hiddenValue}, aNewCurrency:  0, purchaseDoneCallback:  new System.Action(object:  this, method:  System.Void ExpressMusselPurchasePanel::OnReward()), customTitle:  0, customMessage:  0);
        this.RefreshInfo();
    }
    public void SetupAds(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt aNewCount)
    {
        this.watchAds = true;
        this.count = aNewCount;
        mem[1152921529014028208] = aNewCount.fakeValue;
        mem[1152921529014028212] = aNewCount.inited;
        this.RefreshInfo();
    }
    private void RefreshInfo()
    {
        this.buyButton.gameObject.SetActive(value:  (this.watchAds == false) ? 1 : 0);
        string val_4 = "x" + this.count.ToString();
        if(this.countTxt == null)
        {
            
        }
    
    }
    private void OnReward()
    {
        var val_5;
        GameAudio.PlayPurchaseSound();
        MVC_MusselTracker.AddMussels(number:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.count, hiddenValue = this.count, fakeValue = -1362352496, inited = true}));
        DynamicUISingleton<ExpressMusselPurchaseCanvas>.Hide();
        val_5 = null;
        val_5 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Items.Mussels;
        if(MVC_MusselTracker.MAX_MUSSELS > (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited})))
        {
                return;
        }
        
        DialogPanel val_4 = DialogManager.Show(title:  "CONGRATULATIONS!", message:  "YOU HAVE EARNED THE MAXIMUM AMOUNT OF MUSSELS", cancelButtonTitle:  "OK", onCancelCallback:  0);
    }
    private void OnEnable()
    {
        this.SetupBuyPrice(aNewCount:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.count, hiddenValue = this.count, inited = false}, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.price, hiddenValue = this.price, inited = false});
    }
    private void OnDisable()
    {
    
    }
    public ExpressMusselPurchasePanel()
    {
    
    }

}
