using UnityEngine;
public class CustomItemButtonGroup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject currencyBuyGroup;
    private UnityEngine.GameObject vipBuyGroup;
    private UnityEngine.GameObject equipGroup;
    private SoftCurrencyBuyButton currencyBuyButton;
    private CustomItemVIPBuyButton vipBuyButton;
    private CustomItemEquipButton equipButton;
    private CustomItemVIPPromoPanel vipPromoPanel;
    
    // Methods
    public void Refresh()
    {
        int val_8;
        var val_9;
        bool val_10;
        val_8 = CustomItemSelectGrid.<selectItemId>k__BackingField;
        if(((CustomItemCanvas.<itemGroup>k__BackingField) & 1) == 0)
        {
            goto label_3;
        }
        
        this.equipGroup.SetActive(value:  false);
        this.currencyBuyGroup.SetActive(value:  false);
        this.vipBuyGroup.SetActive(value:  false);
        this.vipPromoPanel.gameObject.SetActive(value:  false);
        val_9 = this.equipGroup.gameObject;
        val_10 = 1;
        goto label_11;
        label_3:
        this.equipGroup.SetActive(value:  (CustomItemCanvas.<itemGroup>k__BackingField) & 1);
        this.currencyBuyGroup.SetActive(value:  (~(CustomItemCanvas.<itemGroup>k__BackingField)) & 1);
        if((CustomItemCanvas.<itemGroup>k__BackingField) < 1)
        {
            goto label_23;
        }
        
        CustomItemGroupBase val_7 = CustomItemCanvas.<itemGroup>k__BackingField;
        val_7 = (~val_7) & 1;
        if(this.vipBuyGroup != null)
        {
            goto label_33;
        }
        
        label_34:
        label_33:
        this.vipBuyGroup.SetActive(value:  val_7);
        val_9 = this.vipPromoPanel.gameObject;
        val_8 = this.vipBuyGroup.activeInHierarchy;
        val_10 = val_8;
        label_11:
        val_9.SetActive(value:  val_10);
        this.SetupVIPButton();
        this.SetupCurrencyBuyButton();
        this.equipButton.Refresh();
        this.vipPromoPanel.Refresh();
        return;
        label_23:
        if(this.vipBuyGroup != null)
        {
            goto label_33;
        }
        
        goto label_34;
    }
    private void SetupCurrencyBuyButton()
    {
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  CustomItemCanvas.<itemGroup>k__BackingField);
        this.currencyBuyButton.Setup(aNewItemName:  CustomItemCanvas.<itemGroup>k__BackingField, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}, aNewCurrency:  CustomItemCanvas.<itemGroup>k__BackingField, purchaseDoneCallback:  new System.Action(object:  this, method:  System.Void CustomItemButtonGroup::OnCurrencyPurchaseSeccess()), customTitle:  0, customMessage:  0);
    }
    private void OnCurrencyPurchaseSeccess()
    {
        CustomItemCanvas.selectionGrid.RefreshSelectItem();
        CustomItemCanvas.infoPanel.Refresh();
    }
    private void SetupVIPButton()
    {
        this.vipBuyButton.SetupVIPPurchase(level:  CustomItemCanvas.<itemGroup>k__BackingField);
        this.vipBuyButton.SetupSquaredIcon(iconLevel:  CustomItemCanvas.<itemGroup>k__BackingField);
    }
    public CustomItemButtonGroup()
    {
    
    }

}
