using UnityEngine;
[Serializable]
public class PlayerBuff.BuffData
{
    // Fields
    public BattleBonusType bonusType;
    public int value;
    
    // Methods
    public PlayerBuff.BuffData(BattleBonusType aNewType)
    {
        this.bonusType = 17;
        this.bonusType = aNewType;
    }
    public PlayerBuff.BuffData(BattleBonusType aNewType, int aNewValue)
    {
        this.bonusType = 17;
        this.bonusType = aNewType;
        this.value = aNewValue;
    }

}
