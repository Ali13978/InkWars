using UnityEngine;
private sealed class BattleEnhancerCollection.<>c__DisplayClass23_0
{
    // Fields
    public InkWars.Model.BattleEnhancerType type;
    public int aNewLevel;
    public int count;
    
    // Methods
    public BattleEnhancerCollection.<>c__DisplayClass23_0()
    {
    
    }
    internal bool <GetPriceData>b__0(BattleEnhancerCollection.BattleEnhancerPriceData x)
    {
        int val_3;
        var val_4;
        val_3 = x;
        if(((val_3 != null) && (this.type == x.enhancerType)) && (this.aNewLevel == x.level))
        {
                var val_2 = (this.count == (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = x.count, hiddenValue = x.count, fakeValue = val_3, inited = val_3}))) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }

}
