using UnityEngine;
private sealed class SwitcherCustomization.<>c__DisplayClass31_1
{
    // Fields
    public PurchaseAndEquipDialog dialog;
    public SwitcherCustomization.<>c__DisplayClass31_0 CS$<>8__locals1;
    
    // Methods
    public SwitcherCustomization.<>c__DisplayClass31_1()
    {
    
    }
    internal void <OnButtonClicked>b__1()
    {
        var val_5;
        SwitcherCustomization.<>c__DisplayClass31_0 val_6;
        val_5 = null;
        val_5 = null;
        DataStructs.UserDataDictionary.Items.SetSwitcherUnlocked(id:  this.CS$<>8__locals1.data.id, unlocked:  true);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.CS$<>8__locals1.data.id);
        DataStructs.UserDataDictionary.Settings.SelectedSwitcher = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        this.CS$<>8__locals1.canvasGroup.alpha = 1f;
        this.CS$<>8__locals1.<>4__this.OfferPanel.gameObject.SetActive(value:  false);
        this.CS$<>8__locals1.<>4__this.m_purchasedItemsDetails.gameObject.SetActive(value:  true);
        val_6 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != null)
        {
            goto label_23;
        }
        
        val_6 = this.CS$<>8__locals1;
        if(val_6 == null)
        {
            goto label_24;
        }
        
        label_23:
        this.CS$<>8__locals1.<>4__this.m_purchasedItemsDetailsTitle.text = 0.GetLocalizedTitle(key:  this.CS$<>8__locals1.data.image);
        this.CS$<>8__locals1.<>4__this.SetupCounters();
        this.CS$<>8__locals1.<>4__this.CheckforActive();
        this.dialog.Close();
        return;
        label_24:
    }

}
