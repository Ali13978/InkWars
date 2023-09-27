using UnityEngine;
[Serializable]
public class SwitcherCollection.SwitcherData
{
    // Fields
    public InkWars.Model.CustomizationTier type;
    public int level;
    public string image;
    public int id;
    public int price;
    public InkWars.Model.BattleEnhancerType battleEnhancerOffer;
    public int offerCount;
    public Currency currency;
    
    // Methods
    public SwitcherCollection.SwitcherData()
    {
        this.battleEnhancerOffer = 3;
        this.currency = 1;
    }

}
