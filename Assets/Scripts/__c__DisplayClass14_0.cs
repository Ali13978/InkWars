using UnityEngine;
private sealed class BattleEnhancerShopTypeToggleGroup.<>c__DisplayClass14_0
{
    // Fields
    public InkWars.Model.BattleEnhancerType type;
    
    // Methods
    public BattleEnhancerShopTypeToggleGroup.<>c__DisplayClass14_0()
    {
    
    }
    internal bool <Select>b__0(BattleEnhancerShopTypeToggle x)
    {
        var val_3;
        if(0 != x)
        {
                var val_2 = (this.type == x.enhancerType) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }

}
