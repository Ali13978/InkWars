using UnityEngine;
private sealed class RevengeAnimationController.<FlashHelper>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public RevengeAnimationController <>4__this;
    private int <animationIndex>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RevengeAnimationController.<FlashHelper>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_11;
        RevengeAnimationController val_12;
        float val_13;
        int val_14;
        Data val_16;
        val_11 = this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        val_12 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>4__this.m_Data.IsFlashing) == false)
        {
            goto label_4;
        }
        
        if((this.<>4__this.m_Data.IsFlashing) == false)
        {
            goto label_6;
        }
        
        if(((this.<animationIndex>5__2) & 1) != 0)
        {
            goto label_8;
        }
        
        this.<>4__this.m_Data.BackgroundMaterial.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = this.<>4__this.m_RevengeCharacterInformationDB.m_Gradients.Yellow.TopColor, g = V9.16B, b = V10.16B, a = V11.16B});
        val_12 = this.<>4__this.m_RevengeCharacterInformationDB.m_Gradients.Yellow;
        if(val_12 != null)
        {
            goto label_38;
        }
        
        label_39:
        label_38:
        this.<>4__this.m_Data.BackgroundMaterial.SetColor(name:  "_Color2", value:  new UnityEngine.Color() {r = this.<>4__this.m_RevengeCharacterInformationDB.m_Gradients.Yellow.BottomColor, g = V9.16B, b = V10.16B, a = V11.16B});
        int val_11 = this.<animationIndex>5__2;
        val_13 = this.delay;
        val_11 = val_11 + 1;
        this.<animationIndex>5__2 = val_11;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_13);
        this.<>1__state = 2;
        val_14 = 1;
        return (bool)val_14;
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_32;
        }
        
        this.<animationIndex>5__2 = 0;
        this.<>1__state = 0;
        val_13 = this.delay;
        val_14 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_13);
        this.<>1__state = val_14;
        return (bool)val_14;
        label_4:
        val_11 = "Shot PLAYER BUBBLE: "("Shot PLAYER BUBBLE: ") + this.<>4__this.m_PlayerBubble(this.<>4__this.m_PlayerBubble);
        UnityEngine.Debug.Log(message:  val_11);
        InkWars.Model.BubbleTypes val_12 = this.<>4__this.m_PlayerBubble;
        val_12 = val_12 - 8;
        if(val_12 > 8)
        {
            goto label_32;
        }
        
        var val_13 = 40836388 + ((this.<>4__this.m_PlayerBubble - 8)) << 2;
        val_13 = val_13 + 40836388;
        goto (40836388 + ((this.<>4__this.m_PlayerBubble - 8)) << 2 + 40836388);
        label_6:
        UnityEngine.Debug.Log(message:  "STOP FLASHING");
        goto label_32;
        label_8:
        this.<>4__this.m_Data.BackgroundMaterial.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = this.<>4__this.m_Data.GradientColors.TopColor, g = V9.16B, b = V10.16B, a = V11.16B});
        val_16 = this.<>4__this.m_Data;
        if((this.<>4__this.m_Data) != null)
        {
            goto label_36;
        }
        
        val_16 = this.<>4__this.m_Data;
        if(val_16 == null)
        {
            goto label_37;
        }
        
        label_36:
        if((this.<>4__this.m_Data.GradientColors) != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_32:
        val_14 = 0;
        return (bool)val_14;
        label_37:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
