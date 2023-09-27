using UnityEngine;
private sealed class BattleEnhancerList.<>c__DisplayClass5_0
{
    // Fields
    public InkWars.Model.BattleEnhancerType type;
    public int level;
    
    // Methods
    public BattleEnhancerList.<>c__DisplayClass5_0()
    {
    
    }
    internal bool <GetCount>b__0(BattleEnhancerItem x)
    {
        var val_2;
        if(x.enhancerType == this.type)
        {
                var val_1 = (x.level == this.level) ? 1 : 0;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }

}
