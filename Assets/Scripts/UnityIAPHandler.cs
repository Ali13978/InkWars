using UnityEngine;
public static class UnityIAPHandler
{
    // Methods
    public static void OnPurchaseComplete(string sku, bool isRestoreMode = False, System.Action onDone)
    {
        UnityIAPHandler.OnPurchaseComplete(id:  IapItemInfo.GetIAPItemIdsFromString(id:  sku), isRestoreMode:  isRestoreMode, onDone:  onDone);
    }
    public static void OnPurchaseComplete(IAPItemIds id, bool isRestoreMode = False, System.Action onDone)
    {
        IAPItemIds val_12;
        IAPItemIds val_13;
        System.Action val_14;
        var val_20;
        val_12 = id;
        UnityIAPHandler.<>c__DisplayClass1_0 val_1 = new UnityIAPHandler.<>c__DisplayClass1_0();
        if(val_1 != null)
        {
                val_13 = val_1;
            .id = val_12;
            val_14 = 1152921529103683920;
            mem[1152921529103683928] = onDone;
        }
        else
        {
                val_13 = 16;
            mem[16] = val_12;
            val_14 = 24;
            mem[24] = onDone;
            val_12 = mem[16];
        }
        
        if((val_12 - 1) > 67)
        {
            goto label_3;
        }
        
        var val_12 = 40824876 + ((id - 1)) << 2;
        val_12 = val_12 + 40824876;
        goto (40824876 + ((id - 1)) << 2 + 40824876);
        label_24:
        if((UnityIAPHandler.UnlockCharacterByIapId(aNewId:  val_13, isRestoreMode:  isRestoreMode)) == false)
        {
            goto label_32;
        }
        
        if(isRestoreMode == false)
        {
            goto label_22;
        }
        
        goto label_32;
        label_3:
        if((val_12 - 151) > 24)
        {
            goto label_24;
        }
        
        var val_13 = 40825148 + ((id - 151)) << 2;
        val_13 = val_13 + 40825148;
        goto (40825148 + ((id - 151)) << 2 + 40825148);
        label_22:
        val_20 = null;
        val_20 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = DataStructs.UserDataDictionary.Stats.ItemsBougth;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_10.currentCryptoKey, hiddenValue = val_10.hiddenValue, fakeValue = val_10.fakeValue, inited = val_10.inited});
        val_12 = val_11.currentCryptoKey;
        DataStructs.UserDataDictionary.Stats.ItemsBougth = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_12, hiddenValue = val_11.hiddenValue, fakeValue = val_11.fakeValue, inited = val_11.inited};
        label_32:
        MainThreadDispatcher.Invoke(action:  val_14, delay:  0f);
    }
    private static bool UnlockCharacterByIapId(IAPItemIds aNewId, bool isRestoreMode)
    {
        UnityEngine.Object val_5;
        var val_6;
        var val_7;
        val_5 = isRestoreMode;
        .aNewId = aNewId;
        if(val_5 == true)
        {
            goto label_2;
        }
        
        val_5 = CharacterDataManager.Find(match:  new System.Predicate<CharacterData>(object:  new UnityIAPHandler.<>c__DisplayClass2_0(), method:  System.Boolean UnityIAPHandler.<>c__DisplayClass2_0::<UnlockCharacterByIapId>b__0(CharacterData x)));
        if(0 != val_5)
        {
            goto label_7;
        }
        
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_7:
        val_7 = null;
        val_7 = null;
        DataStructs.UserDataDictionary.Items.SetCharacterUnlock(id:  val_3.characterId, unlocked:  true, displayAvatarUnlockPopup:  true);
        val_5 = val_3.characterId;
        IAPCharacterPromoGift.ApplyGift(character:  val_5);
        val_6 = 1;
        return (bool)val_6;
    }

}
