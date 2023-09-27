using UnityEngine;
private sealed class MVC_Bot_Profile.<>c__DisplayClass19_1
{
    // Fields
    public string name;
    public MVC_Bot_Profile.<>c__DisplayClass19_0 CS$<>8__locals1;
    
    // Methods
    public MVC_Bot_Profile.<>c__DisplayClass19_1()
    {
    
    }
    internal bool <GetBotQueue>b__1(MVC_Bot_Profile p)
    {
        int val_3;
        var val_4;
        val_3 = p;
        if((System.String.op_Equality(a:  p.name, b:  this.name)) != false)
        {
                val_3 = p.MinimumWinsForPlay;
            var val_2 = (val_3 <= (this.CS$<>8__locals1.wins)) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }

}
