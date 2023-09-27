using UnityEngine;
[Serializable]
public class BubblesCollection.BubblesData
{
    // Fields
    public InkWars.Model.CustomizationTier tier;
    public int level;
    public int id;
    public int price;
    public InkWars.Model.BattleEnhancerType battleEnhancerOffer;
    public int offerCount;
    public Currency currency;
    public InkWars.Model.BubbleFamily family;
    
    // Methods
    public BubblesCollection.BubblesData()
    {
        var val_2;
        this.battleEnhancerOffer = 3;
        this.currency = 1;
        val_2 = null;
        val_2 = null;
        BubblesCollection.m_id = BubblesCollection.m_id + 1;
        this.id = BubblesCollection.m_id;
    }

}
