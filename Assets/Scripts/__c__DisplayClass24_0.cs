using UnityEngine;
private sealed class BattleEnhancerCollection.<>c__DisplayClass24_0
{
    // Fields
    public InkWars.Model.BattleEnhancerType type;
    
    // Methods
    public BattleEnhancerCollection.<>c__DisplayClass24_0()
    {
    
    }
    internal bool <GetAllPriceDataByType>b__0(BattleEnhancerCollection.BattleEnhancerPriceData x)
    {
        if(x == null)
        {
                return false;
        }
        
        return (bool)(this.type == x.enhancerType) ? 1 : 0;
    }

}
