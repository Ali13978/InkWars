using UnityEngine;
private sealed class BattleEnhancerCollection.<>c__DisplayClass16_0
{
    // Fields
    public InkWars.Model.BattleEnhancerType type;
    
    // Methods
    public BattleEnhancerCollection.<>c__DisplayClass16_0()
    {
    
    }
    internal bool <GetDesc>b__0(BattleEnhancerCollection.BattleEnhancerAssets x)
    {
        if(x == null)
        {
                return false;
        }
        
        return (bool)(x.type == this.type) ? 1 : 0;
    }

}
