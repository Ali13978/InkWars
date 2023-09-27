using UnityEngine;
private sealed class RevengeAnimationController.<>c__DisplayClass16_1
{
    // Fields
    public bool avoid;
    public string text;
    public RevengeAnimationController.<>c__DisplayClass16_0 CS$<>8__locals1;
    
    // Methods
    public RevengeAnimationController.<>c__DisplayClass16_1()
    {
    
    }
    internal void <OnStunned>b__0()
    {
        bool val_4;
        if(this.avoid != false)
        {
                val_4 = 0;
        }
        else
        {
                this.text = ((System.String.op_Equality(a:  this.text, b:  "Double-Tap")) != true) ? "Break Stun" : "Double-Tap";
            this.CS$<>8__locals1.player.StunBreakDoubleTapTransparency.GetComponent<TMPro.TextMeshProUGUI>().text = this.text;
            val_4 = true;
        }
        
        this.avoid = val_4;
    }

}
