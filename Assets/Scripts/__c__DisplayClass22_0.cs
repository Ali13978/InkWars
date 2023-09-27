using UnityEngine;
private sealed class BattleEnhancerCollection.<>c__DisplayClass22_0
{
    // Fields
    public InkWars.Model.BattleEnhancerType type;
    
    // Methods
    public BattleEnhancerCollection.<>c__DisplayClass22_0()
    {
    
    }
    internal bool <GetIsDebuffType>b__0(BattleEnhancerCollection.BattleEnhancerAssets x)
    {
        if(x == null)
        {
                return false;
        }
        
        return (bool)(this.type == x.type) ? 1 : 0;
    }

}
