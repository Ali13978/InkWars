using UnityEngine;
public class BattleBonusCollection : ScriptableObject
{
    // Fields
    private System.Collections.Generic.List<BattleBonusSpriteData> spriteList;
    
    // Methods
    public static BattleBonusCollection Get()
    {
        return UnityEngine.Resources.Load<BattleBonusCollection>(path:  "NetworkDataCollection/BattleBonusCollection");
    }
    public UnityEngine.Sprite GetSpriteByType(BattleBonusType type)
    {
        UnityEngine.Sprite val_4;
        .type = type;
        if((this.spriteList.Find(match:  new System.Predicate<BattleBonusSpriteData>(object:  new BattleBonusCollection.<>c__DisplayClass2_0(), method:  System.Boolean BattleBonusCollection.<>c__DisplayClass2_0::<GetSpriteByType>b__0(BattleBonusSpriteData x)))) == null)
        {
                return val_4;
        }
        
        val_4 = val_3.sprite;
        return val_4;
    }
    public BattleBonusCollection()
    {
        this.spriteList = new System.Collections.Generic.List<BattleBonusSpriteData>();
    }

}
