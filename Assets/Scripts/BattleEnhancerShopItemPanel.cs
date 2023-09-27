using UnityEngine;
public class BattleEnhancerShopItemPanel : MonoBehaviour
{
    // Fields
    private InkWars.Model.BattleEnhancerType enhancerType;
    private int level;
    private int count;
    private UnityEngine.UI.Image icon;
    private TMPro.TextMeshProUGUI levelTxt;
    private TMPro.TextMeshProUGUI timeTxt;
    private SoftCurrencyBuyButton buyButton;
    private UnityEngine.UI.Image discountIcon;
    private TMPro.TextMeshProUGUI discountTxt;
    private BattleEnhancerShopTypeToggleGroup typeSelection;
    private OptionSelectPanel countSelection;
    private BattleEnhancerShopCountPanel countPanel;
    private BattleEnhancerCollection.BattleEnhancerPriceData priceData;
    
    // Methods
    private void OnEnable()
    {
        if(0 != this.typeSelection)
        {
                this.typeSelection.OnSelectionChange.AddListener(call:  new UnityEngine.Events.UnityAction<InkWars.Model.BattleEnhancerType>(object:  this, method:  System.Void BattleEnhancerShopItemPanel::OnTypeChange(InkWars.Model.BattleEnhancerType aNewType)));
        }
        
        if(0 == this.countSelection)
        {
                return;
        }
        
        this.countSelection.OnSelectionChanged.AddListener(call:  new UnityEngine.Events.UnityAction<OptionData>(object:  this, method:  System.Void BattleEnhancerShopItemPanel::OnCountChange(OptionSelectPanel.OptionData data)));
    }
    private void OnDisable()
    {
        if(0 != this.typeSelection)
        {
                this.typeSelection.OnSelectionChange.RemoveListener(call:  new UnityEngine.Events.UnityAction<InkWars.Model.BattleEnhancerType>(object:  this, method:  System.Void BattleEnhancerShopItemPanel::OnTypeChange(InkWars.Model.BattleEnhancerType aNewType)));
        }
        
        if(0 == this.countSelection)
        {
                return;
        }
        
        this.countSelection.OnSelectionChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<OptionData>(object:  this, method:  System.Void BattleEnhancerShopItemPanel::OnCountChange(OptionSelectPanel.OptionData data)));
    }
    private void OnTypeChange(InkWars.Model.BattleEnhancerType aNewType)
    {
        this.enhancerType = aNewType;
        this.Setup(enhancerType:  aNewType, level:  this.level, count:  this.count);
    }
    private void OnCountChange(OptionSelectPanel.OptionData data)
    {
        OptionData val_2 = data;
        if(val_2 != null)
        {
                val_2 = UnityEngine.Mathf.RoundToInt(f:  data.value);
        }
        
        this.count = val_2;
        this.Setup(enhancerType:  this.enhancerType, level:  this.level, count:  val_2);
    }
    public void Setup(InkWars.Model.BattleEnhancerType enhancerType, int level, int count)
    {
        var val_24;
        if((enhancerType - 1) <= 4)
        {
                val_24 = mem[40826176 + ((enhancerType - 1)) << 2];
            val_24 = 40826176 + ((enhancerType - 1)) << 2;
        }
        else
        {
                val_24 = 10;
        }
        
        this.icon.sprite = BattleEnhancerCollection.GetIcon(type:  enhancerType, isOpponent:  false);
        this.levelTxt.text = "Lv " + level.ToString();
        object[] val_7 = new object[1];
        string val_8 = (UnityEngine.Mathf.Clamp(value:  level, min:  1, max:  6)) * 10((UnityEngine.Mathf.Clamp(value:  level, min:  1, max:  6)) * 10) + "<br>"("<br>");
        if(val_7 == null)
        {
            goto label_9;
        }
        
        if(val_8 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_8 == null)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        val_7[0] = val_8;
        this.timeTxt.text = LanguageManager.GetTextFormat(key:  "LK.Option.Time", list:  val_7);
        this.priceData = BattleEnhancerCollection.GetPriceData(type:  enhancerType, aNewLevel:  level, count:  count);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.priceData.GetPromoPrice());
        this.buyButton.Setup(aNewItemName:  System.String.Format(format:  "Lv{0} {1} x{2}", arg0:  level, arg1:  BattleEnhancerCollection.GetName(type:  enhancerType), arg2:  this.priceData.count), aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_14.currentCryptoKey, hiddenValue = val_14.hiddenValue, fakeValue = val_14.fakeValue, inited = val_14.inited}, aNewCurrency:  this.priceData.currency, purchaseDoneCallback:  new System.Action(object:  this, method:  System.Void BattleEnhancerShopItemPanel::OnPurchaseDone()), customTitle:  0, customMessage:  0);
        this.buyButton.SetCustomCanBuyCheck(aNewCustomBuyCheckFunc:  new SoftCurrencyBuyButton.CustomCanBuyFunc(object:  this, method:  System.Boolean BattleEnhancerShopItemPanel::CanBuy()), OnCustomBuyCheckFail:  new System.Action(object:  this, method:  System.Void BattleEnhancerShopItemPanel::OnCannotBuy()));
        this.discountIcon.gameObject.SetActive(value:  ((BattleBonusConfig.GetBonusValueForLocalPlayer(type:  16)) > 0) ? 1 : 0);
        object[] val_21 = new object[2];
        int val_22 = BattleBonusConfig.GetBonusValueForLocalPlayer(type:  16);
        if(val_21 == null)
        {
            goto label_27;
        }
        
        if(val_22 != 0)
        {
            goto label_28;
        }
        
        goto label_31;
        label_27:
        if(val_22 == 0)
        {
            goto label_31;
        }
        
        label_28:
        label_31:
        val_21[0] = val_22;
        val_21[1] = "<br>";
        this.discountTxt.text = LanguageManager.GetTextFormat(key:  "LK.BONUS_DISCOUNT_LABEL", list:  val_21);
    }
    private bool CanBuy()
    {
        null = null;
        return (bool)((DataStructs.UserDataDictionary.Items.GetEnhancerCount(type:  this.enhancerType, level:  this.level, defaultValue:  0)) < 9999) ? 1 : 0;
    }
    private void OnCannotBuy()
    {
        MaxCountDialog.Show(msg1:  System.String.Format(format:  "YOUR CURRENT {0} ARE AT MAX STOCK ({1}/{1})", arg0:  System.String.Format(format:  "Lv{0} {1}", arg0:  this.level, arg1:  BattleEnhancerCollection.GetName(type:  this.enhancerType)), arg1:  9999), msg2:  "Use them up before purchasing more!");
    }
    private void OnPurchaseDone()
    {
        null = null;
        DataStructs.UserDataDictionary.Items.AddEnhancerCount(type:  this.enhancerType, level:  this.level, count:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = this.priceData.count, hiddenValue = this.priceData.count, fakeValue = this.priceData, inited = this.priceData}));
        if(0 == this.countPanel)
        {
                return;
        }
        
        this.countPanel.Refresh();
    }
    public BattleEnhancerShopItemPanel()
    {
    
    }

}
