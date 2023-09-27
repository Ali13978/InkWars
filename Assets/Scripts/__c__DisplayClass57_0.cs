using UnityEngine;
private sealed class View_Bubble.<>c__DisplayClass57_0
{
    // Fields
    public InkWars.Model.BubbleTypes type;
    public string customAnimKey;
    
    // Methods
    public View_Bubble.<>c__DisplayClass57_0()
    {
    
    }
    internal bool <PlayEffects>b__0(BubbleEffectData x)
    {
        if(x.bubbleType != this.type)
        {
                return false;
        }
        
        if((System.String.IsNullOrWhiteSpace(value:  this.customAnimKey)) == false)
        {
                return System.String.op_Equality(a:  x.customAnimKey, b:  this.customAnimKey);
        }
        
        return false;
    }
    internal bool <PlayEffects>b__1(BubbleEffectData x)
    {
        if(x.bubbleType != 0)
        {
                return false;
        }
        
        if((System.String.IsNullOrWhiteSpace(value:  this.customAnimKey)) == false)
        {
                return System.String.op_Equality(a:  x.customAnimKey, b:  this.customAnimKey);
        }
        
        return false;
    }
    internal bool <PlayEffects>b__2(BubbleEffectData x)
    {
        if(x.bubbleType != this.type)
        {
                return false;
        }
        
        return System.String.IsNullOrWhiteSpace(value:  x.customAnimKey);
    }

}
