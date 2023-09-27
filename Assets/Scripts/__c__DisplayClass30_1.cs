using UnityEngine;
private sealed class BubblesCustomization.<>c__DisplayClass30_1
{
    // Fields
    public PurchaseAndEquipDialog dialog;
    public BubblesCustomization.<>c__DisplayClass30_0 CS$<>8__locals1;
    
    // Methods
    public BubblesCustomization.<>c__DisplayClass30_1()
    {
    
    }
    internal void <OnButtonClicked>b__2()
    {
        var val_4;
        BubblesCustomization.<>c__DisplayClass30_0 val_5;
        val_4 = null;
        val_4 = null;
        DataStructs.UserDataDictionary.Items.SetBubbleUnlocked(id:  this.CS$<>8__locals1.data.family, unlocked:  true);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  this.CS$<>8__locals1.data.family);
        DataStructs.UserDataDictionary.Settings.SelectedBubble = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        this.CS$<>8__locals1.<>4__this.m_purchasedItemsDetails.gameObject.SetActive(value:  true);
        val_5 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != null)
        {
            goto label_17;
        }
        
        val_5 = this.CS$<>8__locals1;
        if(val_5 == null)
        {
            goto label_18;
        }
        
        label_17:
        this.CS$<>8__locals1.<>4__this.m_purchasedItemsDetailsTitle.text = 0.GetLocalizedBubbleTitle(family:  this.CS$<>8__locals1.data.family);
        this.CS$<>8__locals1.canvasGroup.alpha = 1f;
        this.CS$<>8__locals1.<>4__this.SetupCounters();
        this.CS$<>8__locals1.<>4__this.CheckforActive();
        this.dialog.Close();
        return;
        label_18:
    }

}
