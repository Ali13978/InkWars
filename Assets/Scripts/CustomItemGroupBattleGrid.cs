using UnityEngine;
public class CustomItemGroupBattleGrid : CustomItemGroupBase
{
    // Properties
    public override CustomizationButtonGroupCtrl.CustomizationGroup groupType { get; }
    
    // Methods
    public override CustomizationButtonGroupCtrl.CustomizationGroup get_groupType()
    {
        return 1;
    }
    public override UnityEngine.Sprite GetPreviewSprites(int id, int subItemId = 0)
    {
        BattleGridCollection val_1 = BattleGridCollection.instance;
        if(val_1 != null)
        {
                return val_1.GetBattleGridSpriteByID(id:  id);
        }
        
        return val_1.GetBattleGridSpriteByID(id:  id);
    }
    public override bool IsItemUnlocked(int id)
    {
        null = null;
        if((DataStructs.UserDataDictionary.Items.GetBattleGridUnlocked(id:  id, includeVipUnlock:  true)) != false)
        {
                return true;
        }
    
    }
    public override bool IsItemUnlockedByVIP(int id)
    {
        return VIP.IsBattleGridUnlockedByVip(gridId:  id);
    }
    public override bool IsItemUnlockedByCurrency(int id)
    {
        null = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                return DataStructs.UserDataDictionary.Items.GetBattleGridUnlocked(id:  id, includeVipUnlock:  false);
        }
        
        return DataStructs.UserDataDictionary.Items.GetBattleGridUnlocked(id:  id, includeVipUnlock:  false);
    }
    public override bool IsItemEquiped(int id)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedBattleGrid;
        return (bool)((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited})) == id) ? 1 : 0;
    }
    public override bool IsShowInSelectionGrid(int id)
    {
        if(id != 1)
        {
                return (bool)((id & 4294967294) != 2) ? 1 : 0;
        }
        
        return false;
    }
    public override string GetItemName(int id)
    {
        if((BattleGridCollection.instance.GetBattleGridByID(_id:  id, returnNullForInvalidIds:  false)) == null)
        {
                return "???";
        }
        
        return LanguageManager.GetText(key:  "LK.BattleGridTitle." + val_2.image);
    }
    public override UnityEngine.Sprite GetThumbnailsSprite(int id)
    {
        BattleGridCollection val_1 = BattleGridCollection.instance;
        if(val_1 != null)
        {
                return val_1.GetBattleGridTileSpriteByID(id:  id);
        }
        
        return val_1.GetBattleGridTileSpriteByID(id:  id);
    }
    public override bool IsValidId(int id)
    {
        return (bool)((BattleGridCollection.instance.GetBattleGridByID(_id:  id, returnNullForInvalidIds:  true)) != 0) ? 1 : 0;
    }
    public override InkWars.Model.CustomizationTier GetItemTier(int id)
    {
        if((BattleGridCollection.instance.GetBattleGridByID(_id:  id, returnNullForInvalidIds:  false)) != null)
        {
                return (InkWars.Model.CustomizationTier)val_2.type;
        }
        
        return (InkWars.Model.CustomizationTier)val_2.type;
    }
    public override Currency GetCurrency(int id)
    {
        if((BattleGridCollection.instance.GetBattleGridByID(_id:  id, returnNullForInvalidIds:  false)) != null)
        {
                return (Currency)val_2.currency;
        }
        
        return (Currency)val_2.currency;
    }
    public override int GetCurrencyPrice(int id)
    {
        if((BattleGridCollection.instance.GetBattleGridByID(_id:  id, returnNullForInvalidIds:  false)) != null)
        {
                return (int)val_2.price;
        }
        
        return (int)val_2.price;
    }
    public override void SetUnlock(int id, bool unlock)
    {
        null = null;
        unlock = unlock;
        DataStructs.UserDataDictionary.Items.SetBattleGridUnlocked(id:  id, unlocked:  unlock);
    }
    public override int GetVIPLevel(int id)
    {
        var val_2;
        var val_3;
        val_2 = 0;
        label_4:
        if((VIP.CheckBattleGridCouldBeUnlockedByVip(gridId:  id, vipLevel:  val_2 + 1)) == true)
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
        return BattleBonusConfig.GetItemBonusType(item:  "GRID", id:  id);
    }
    public override int GetBattleBonusValue(int id)
    {
        return BattleBonusConfig.GetItemBonusValue(item:  "GRID", id:  id);
    }
    public override int GetEquippedItemId()
    {
        null = null;
        DataStructs.UserDataDictionary.Items.TrySetToDefaultBattleGrid();
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Settings.SelectedBattleGrid;
        return CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited});
    }
    public override void SetEquip(int id)
    {
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  id);
        DataStructs.UserDataDictionary.Settings.SelectedBattleGrid = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
    }
    public override bool IsDefaultUnlocked(int id)
    {
        if(id == 0)
        {
                return true;
        }
        
        return (bool)((id - 1) < 2) ? 1 : 0;
    }
    public CustomItemGroupBattleGrid()
    {
        val_1 = new System.Object();
    }

}
