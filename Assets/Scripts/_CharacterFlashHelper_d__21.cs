using UnityEngine;
private sealed class RevengeAnimationController.<CharacterFlashHelper>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.Color firstColor;
    public RevengeAnimationController <>4__this;
    public float duration;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RevengeAnimationController.<CharacterFlashHelper>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RevengeAnimationController val_8;
        InkWars.Model.Player val_9;
        int val_10;
        val_8 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Debug.Log(message:  "CHARACTER FLASH HELPER - Start - "("CHARACTER FLASH HELPER - Start - ") + this.firstColor);
        val_9 = this.<>4__this.m_PlayerControllerReference.FlashPlayer;
        val_9.color = new UnityEngine.Color() {r = this.firstColor, g = V9.16B, b = V10.16B, a = V11.16B};
        this.<>4__this.m_PlayerControllerReference.FlashPlayer.Flash();
        UnityEngine.WaitForSeconds val_4 = null;
        val_8 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  this.duration);
        val_10 = 1;
        this.<>2__current = val_8;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Debug.Log(message:  "CHARACTER FLASH HELPER - End");
        if(val_8 == null)
        {
            goto label_13;
        }
        
        val_8.StopFlash();
        if((this.<>4__this.m_PlayerControllerReference) != null)
        {
            goto label_24;
        }
        
        label_25:
        label_24:
        InkWars.Model.Model_Player val_5 = this.<>4__this.m_PlayerControllerReference.PlayerModel;
        val_9 = val_5.ID;
        InkWars.Model.Model_Player val_6 = this.<>4__this + 40.PlayerModel;
        InkWars.Model.Model_Player val_7 = this.<>4__this + 40.PlayerModel;
        this.<>4__this.m_PlayerControllerReference.OnBubbleSwitch(playerId:  val_9, loadedBubble:  val_6.LoadedBubble, spareBubble:  val_7.SpareBubble, manualSwitch:  false);
        val_8.StopAllCoroutines();
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_13:
        0.StopFlash();
        if(53212264 != 0)
        {
            goto label_24;
        }
        
        goto label_25;
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
