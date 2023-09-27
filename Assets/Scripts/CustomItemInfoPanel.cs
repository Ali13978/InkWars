using UnityEngine;
public class CustomItemInfoPanel : MonoBehaviour
{
    // Fields
    private CustomItemBattleBonusInfoPanel battleBonusInfoPanel;
    private CustomItemPreview preview;
    private CustomItemButtonGroup buttonGroup;
    private CustomItemVIPBuyButton topVipBuyButton;
    
    // Methods
    public void Refresh()
    {
        this.battleBonusInfoPanel.Refresh();
        this.buttonGroup.Refresh();
        this.preview.Refresh();
        this.SetupTopVipButton();
    }
    private void SetupTopVipButton()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        this.topVipBuyButton.gameObject.SetActive(value:  VIP.isVipActived);
        if(VIP.isVipActived == false)
        {
            goto label_5;
        }
        
        val_12 = null;
        val_12 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Items.VipLevel;
        val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited});
        if(this.topVipBuyButton != null)
        {
            goto label_13;
        }
        
        goto label_12;
        label_5:
        val_13 = 0;
        if(this.topVipBuyButton != null)
        {
            goto label_13;
        }
        
        label_12:
        label_13:
        this.topVipBuyButton.SetupLongIcon(iconLevel:  0);
        val_14 = null;
        val_14 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Items.VipLevel;
        int val_11 = val_7.fakeValue;
        val_11 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_11, inited = val_7.inited})) + 1;
        this.topVipBuyButton.SetupVIPPurchase(level:  val_11);
        if(VIP.isVipActived == false)
        {
            goto label_22;
        }
        
        val_15 = VIP.canUpgrade;
        if(this.topVipBuyButton != null)
        {
            goto label_27;
        }
        
        goto label_26;
        label_22:
        val_15 = 0;
        if(this.topVipBuyButton != null)
        {
            goto label_27;
        }
        
        label_26:
        label_27:
        this.topVipBuyButton.SetButtonEnable(enable:  false);
    }
    public CustomItemInfoPanel()
    {
    
    }

}
