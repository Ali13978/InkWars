using UnityEngine;
private sealed class Model_Player.<>c__DisplayClass94_0
{
    // Fields
    public System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> matchingBubbleList;
    
    // Methods
    public Model_Player.<>c__DisplayClass94_0()
    {
    
    }
    internal bool <NonMatchingBubble>b__0(InkWars.Model.BubbleTypes p)
    {
        if(this.matchingBubbleList != null)
        {
                return this.matchingBubbleList.Contains(item:  p);
        }
        
        return this.matchingBubbleList.Contains(item:  p);
    }

}
