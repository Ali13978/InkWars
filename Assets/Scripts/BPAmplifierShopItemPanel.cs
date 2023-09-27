using UnityEngine;
public class BPAmplifierShopItemPanel : MonoBehaviour
{
    // Fields
    private InkWars.Model.BPAmplifierType amplifierType;
    private int percent;
    private int seconds;
    private UnityEngine.UI.Image icon;
    private TMPro.TextMeshProUGUI percentTxt;
    private SoftCurrencyBuyButton buyButton;
    private UnityEngine.UI.Image discountIcon;
    private TMPro.TextMeshProUGUI discountTxt;
    private BPAmplifierShopCountPanel countPanel;
    
    // Methods
    private void OnEnable()
    {
        this.Setup();
    }
    public void Setup()
    {
        object val_17;
        InkWars.Model.BPAmplifierType val_18;
        val_17 = this;
        val_18 = this.amplifierType;
        if(val_18 == 0)
        {
                return;
        }
        
        this.icon.sprite = AmplifierCollection.GetIcon(type:  val_18);
        this.percentTxt.text = this.percent.ToString();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  AmplifierCollection.GetPriceData(type:  this.amplifierType, percentage:  this.percent).GetPromoPrice());
        this.buyButton.Setup(aNewItemName:  System.String.Format(format:  "{0} {1}%", arg0:  AmplifierCollection.GetName(type:  this.amplifierType), arg1:  this.percent), aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited}, aNewCurrency:  val_3.currency, purchaseDoneCallback:  new System.Action(object:  this, method:  System.Void BPAmplifierShopItemPanel::OnPurchaseDone()), customTitle:  0, customMessage:  0);
        this.buyButton.SetCustomCanBuyCheck(aNewCustomBuyCheckFunc:  new SoftCurrencyBuyButton.CustomCanBuyFunc(object:  this, method:  System.Boolean BPAmplifierShopItemPanel::CanBuy()), OnCustomBuyCheckFail:  new System.Action(object:  this, method:  System.Void BPAmplifierShopItemPanel::OnCannotBuy()));
        this.discountIcon.gameObject.SetActive(value:  ((BattleBonusConfig.GetBonusValueForLocalPlayer(type:  17)) > 0) ? 1 : 0);
        val_17 = this.discountTxt;
        object[] val_14 = new object[2];
        val_14[0] = BattleBonusConfig.GetBonusValueForLocalPlayer(type:  17);
        val_18 = "<br>";
        val_14[1] = val_18;
        val_17.text = LanguageManager.GetTextFormat(key:  "LK.BONUS_DISCOUNT_LABEL", list:  val_14);
    }
    private bool CanBuy()
    {
        null = null;
        return (bool)(DataStructs.UserDataDictionary.Items.GetAmplifierList().Count < 8) ? 1 : 0;
    }
    private void OnCannotBuy()
    {
        MaxCountDialog.Show(msg1:  System.String.Format(format:  "YOUR CURRENT AMPLIFIER ARE AT MAX STOCK ({0}/{0})", arg0:  8), msg2:  "Use them up before purchasing more!");
    }
    private void OnPurchaseDone()
    {
        null = null;
        DataStructs.UserDataDictionary.Items.AddAmplifier(type:  this.amplifierType, level:  this.percent);
        if(0 == this.countPanel)
        {
                return;
        }
        
        this.countPanel.UpdateCount();
    }
    public BPAmplifierShopItemPanel()
    {
    
    }

}
