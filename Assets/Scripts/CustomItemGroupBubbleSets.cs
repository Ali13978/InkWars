using UnityEngine;
public class CustomItemGroupBubbleSets : CustomItemGroupBase
{
    // Properties
    public override CustomizationButtonGroupCtrl.CustomizationGroup groupType { get; }
    
    // Methods
    public override CustomizationButtonGroupCtrl.CustomizationGroup get_groupType()
    {
        return 4;
    }
    public override UnityEngine.Sprite GetPreviewSprites(int id, int subItemId = 0)
    {
        BubblesCollection val_1 = BubblesCollection.instance;
        if(val_1 != null)
        {
                return val_1.GetBubbleSpriteByFamilyAndType(family:  id, type:  subItemId);
        }
        
        return val_1.GetBubbleSpriteByFamilyAndType(family:  id, type:  subItemId);
    }
    public override bool IsItemUnlocked(int id)
    {
        null = null;
        if((DataStructs.UserDataDictionary.Items.GetBubbleUnlocked(id:  id, includeVipUnlock:  true)) != false)
        {
                return true;
        }
    
    }
    public override bool IsItemUnlockedByVIP(int id)
    {
        return VIP.IsBubbleSetUnlockedByVip(bubbleId:  id);
    }
    public override bool IsItemUnlockedByCurrency(int id)
    {
        null = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                return DataStructs.UserDataDictionary.Items.GetBubbleUnlocked(id:  id, includeVipUnlock:  false);
        }
        
        return DataStructs.UserDataDictionary.Items.GetBubbleUnlocked(id:  id, includeVipUnlock:  false);
    }
    public override bool IsItemEquiped(int id)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedBubble;
        return (bool)((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) == id) ? 1 : 0;
    }
    public override bool IsShowInSelectionGrid(int id)
    {
        return true;
    }
    public override string GetItemName(int id)
    {
        id.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        return (string)LanguageManager.GetText(key:  "LK.BubbleTitle." + id.ToString());
    }
    public override UnityEngine.Sprite GetThumbnailsSprite(int id)
    {
        goto typeof(CustomItemGroupBubbleSets).__il2cppRuntimeField_178;
    }
    public override bool IsValidId(int id)
    {
        return (bool)((BubblesCollection.instance.getBubblesByFamily(family:  id, returnNullForInvalidIds:  true)) != 0) ? 1 : 0;
    }
    public override InkWars.Model.CustomizationTier GetItemTier(int id)
    {
        if((BubblesCollection.instance.getBubblesByFamily(family:  id, returnNullForInvalidIds:  false)) != null)
        {
                return (InkWars.Model.CustomizationTier)val_2.tier;
        }
        
        return (InkWars.Model.CustomizationTier)val_2.tier;
    }
    public override Currency GetCurrency(int id)
    {
        if((BubblesCollection.instance.getBubblesByFamily(family:  id, returnNullForInvalidIds:  false)) != null)
        {
                return (Currency)val_2.currency;
        }
        
        return (Currency)val_2.currency;
    }
    public override int GetCurrencyPrice(int id)
    {
        if((BubblesCollection.instance.getBubblesByFamily(family:  id, returnNullForInvalidIds:  false)) != null)
        {
                return (int)val_2.price;
        }
        
        return (int)val_2.price;
    }
    public override void SetUnlock(int id, bool unlock)
    {
        null = null;
        unlock = unlock;
        DataStructs.UserDataDictionary.Items.SetBubbleUnlocked(id:  id, unlocked:  unlock);
    }
    public override int GetVIPLevel(int id)
    {
        var val_2;
        var val_3;
        val_2 = 0;
        label_4:
        if((VIP.CheckBubbleSetCouldBeUnlockedByVip(bubbleId:  id, vipLevel:  val_2 + 1)) == true)
        {
            goto label_3;
        }
        
        val_2 = val_2 + 1;
        if(val_2 <= 3)
        {
            goto label_4;
        }
        
        val_3 = 0;
        return (int)val_3;
        label_3:
        val_3 = val_2 + 1;
        return (int)val_3;
    }
    public override BattleBonusType GetBattleBonusType(int id)
    {
        return BattleBonusConfig.GetItemBonusType(item:  "BUBBLE", id:  id);
    }
    public override int GetBattleBonusValue(int id)
    {
        return BattleBonusConfig.GetItemBonusValue(item:  "BUBBLE", id:  id);
    }
    public override int GetEquippedItemId()
    {
        null = null;
        DataStructs.UserDataDictionary.Items.TrySetToDefaultBattleBubble();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedBubble;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    public override void SetEquip(int id)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  id);
        DataStructs.UserDataDictionary.Settings.SelectedBubble = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
    }
    public override bool IsDefaultUnlocked(int id)
    {
        return (bool)(id == 0) ? 1 : 0;
    }
    public CustomItemGroupBubbleSets()
    {
        val_1 = new System.Object();
    }

}
