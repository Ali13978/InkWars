using UnityEngine;
private sealed class BattleEnhancerCollection.<>c__DisplayClass20_0
{
    // Fields
    public InkWars.Model.BattleEnhancerType enhancerType;
    
    // Methods
    public BattleEnhancerCollection.<>c__DisplayClass20_0()
    {
    
    }
    internal bool <GetChatBubbleBG>b__0(BattleEnhancerCollection.BattleEnhancerChatBubbleBG x)
    {
        if(x.typeList == null)
        {
                return (bool)x.typeList;
        }
        
        return x.typeList.Contains(item:  this.enhancerType);
    }

}
