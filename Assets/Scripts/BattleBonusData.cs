using UnityEngine;
[Serializable]
public class BattleBonusData
{
    // Fields
    public string item;
    public int id;
    public string bonus;
    public int value;
    
    // Methods
    public BattleBonusData()
    {
    
    }
    public BattleBonusData(string aNewItemType, int aNewId, BattleBonusType aNewBonus, int aNewValue)
    {
        this.item = aNewItemType;
        this.id = aNewId;
        BattleBonusData val_1 = this.SetBonus(aNewBonus:  aNewBonus);
        this.value = aNewValue;
    }
    public BattleBonusData SetBattleGridType()
    {
        this.item = "GRID";
        return (BattleBonusData)this;
    }
    public BattleBonusData SetBubbleType()
    {
        this.item = "BUBBLE";
        return (BattleBonusData)this;
    }
    public BattleBonusData SetSwitcherType()
    {
        this.item = "SWITCHER";
        return (BattleBonusData)this;
    }
    public BattleBonusData SetId(int aNewId)
    {
        this.id = aNewId;
        return (BattleBonusData)this;
    }
    public BattleBonusData SetBonus(BattleBonusType aNewBonus)
    {
        aNewBonus.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        this.bonus = aNewBonus.ToString();
        return (BattleBonusData)this;
    }
    public BattleBonusData SetValue(int aNewvalue)
    {
        this.value = aNewvalue;
        return (BattleBonusData)this;
    }

}
