using UnityEngine;
private sealed class powerUpsScene.<>c__DisplayClass42_0
{
    // Fields
    public powerUpsScene <>4__this;
    public PurchaseAndEquipDialog dialog;
    
    // Methods
    public powerUpsScene.<>c__DisplayClass42_0()
    {
    
    }
    internal void <Button1>b__0()
    {
        var val_15;
        int val_16;
        var val_17;
        var val_18;
        var val_19;
        GameAudio.PlayButtonSound();
        val_15 = null;
        val_15 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.ItemsBougth;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
        val_16 = val_2.currentCryptoKey;
        DataStructs.UserDataDictionary.Stats.ItemsBougth = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited};
        GameAudio.PlayPurchaseSound();
        if((this.<>4__this.selectedPowerUpType) == 3)
        {
            goto label_10;
        }
        
        if((this.<>4__this.selectedPowerUpType) == 2)
        {
            goto label_11;
        }
        
        if((this.<>4__this.selectedPowerUpType) != 1)
        {
            goto label_28;
        }
        
        val_17 = null;
        val_17 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Items.StunnerBall;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  (this.<>4__this.quantity) + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_3.currentCryptoKey, hiddenValue = val_3.hiddenValue, fakeValue = val_3.fakeValue, inited = val_3.inited})));
        val_16 = val_6.currentCryptoKey;
        DataStructs.UserDataDictionary.Items.StunnerBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited};
        goto label_28;
        label_10:
        val_18 = null;
        val_18 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Items.ColorEraserBall;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  (this.<>4__this.quantity) + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_7.fakeValue, inited = val_7.inited})));
        val_16 = val_10.currentCryptoKey;
        DataStructs.UserDataDictionary.Items.ColorEraserBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16, hiddenValue = val_10.hiddenValue, fakeValue = val_10.fakeValue, inited = val_10.inited};
        goto label_28;
        label_11:
        val_19 = null;
        val_19 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_11 = DataStructs.UserDataDictionary.Items.IronBall;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  (this.<>4__this.quantity) + (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_11.currentCryptoKey, hiddenValue = val_11.hiddenValue, fakeValue = val_11.fakeValue, inited = val_11.inited})));
        val_16 = val_14.currentCryptoKey;
        DataStructs.UserDataDictionary.Items.IronBall = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_16, hiddenValue = val_14.hiddenValue, fakeValue = val_14.fakeValue, inited = val_14.inited};
        label_28:
        this.<>4__this.SetPowerCount();
        this.dialog.Close();
    }

}
