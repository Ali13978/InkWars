using UnityEngine;
public abstract class CustomItemGroupBase
{
    // Fields
    public const int INVALID_ID = -1;
    
    // Properties
    public abstract CustomizationButtonGroupCtrl.CustomizationGroup groupType { get; }
    
    // Methods
    public abstract CustomizationButtonGroupCtrl.CustomizationGroup get_groupType(); // 0
    public abstract UnityEngine.Sprite GetPreviewSprites(int id, int subItemId = 0); // 0
    public abstract bool IsItemUnlocked(int id); // 0
    public abstract bool IsItemUnlockedByVIP(int id); // 0
    public abstract bool IsItemUnlockedByCurrency(int id); // 0
    public abstract bool IsItemEquiped(int id); // 0
    public abstract bool IsShowInSelectionGrid(int id); // 0
    public abstract string GetItemName(int id); // 0
    public abstract UnityEngine.Sprite GetThumbnailsSprite(int id); // 0
    public abstract bool IsValidId(int id); // 0
    public abstract InkWars.Model.CustomizationTier GetItemTier(int id); // 0
    public abstract Currency GetCurrency(int id); // 0
    public abstract int GetCurrencyPrice(int id); // 0
    public abstract void SetUnlock(int id, bool unlock); // 0
    public abstract int GetVIPLevel(int id); // 0
    public abstract BattleBonusType GetBattleBonusType(int id); // 0
    public abstract int GetBattleBonusValue(int id); // 0
    public abstract int GetEquippedItemId(); // 0
    public abstract void SetEquip(int id); // 0
    public abstract bool IsDefaultUnlocked(int id); // 0
    protected CustomItemGroupBase()
    {
    
    }

}
