using UnityEngine;
private sealed class BattleEnhancerCollection.<>c__DisplayClass21_0
{
    // Fields
    public InkWars.Model.BattleEnhancerState state;
    
    // Methods
    public BattleEnhancerCollection.<>c__DisplayClass21_0()
    {
    
    }
    internal bool <GetSFX>b__0(BattleEnhancerCollection.BattleEnhancerSFX x)
    {
        if(x == null)
        {
                return false;
        }
        
        return (bool)(this.state == x.state) ? 1 : 0;
    }

}
