using UnityEngine;
private sealed class View_Core.<InkEmUp_Setup>d__124 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_Core <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_Core.<InkEmUp_Setup>d__124(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_16;
        CharAnimationController val_17;
        int val_19;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.InkEmUpBar.gameObject.SetActive(value:  true);
        InkWars.Model.Model_Core val_2 = View_Core.Model;
        this.<>4__this.InkEmUp_Player_Winner = this.<>4__this.GetPlayer(playerID:  (val_2.InkEmUp_Player.ID != 0) ? 1 : 0);
        InkWars.Model.Model_Core val_5 = View_Core.Model;
        this.<>4__this.InkEmUp_Player_Loser = this.<>4__this.GetPlayer(playerID:  (val_5.InkEmUp_Player.ID == 0) ? 1 : 0);
        this.<>4__this.InkEmUp_Player_Winner.PlayerAnimator.inkemUp = true;
        this.<>4__this.InkEmUp_AnimText_NotOverYet.SetActive(value:  true);
        this.<>4__this.InkEmUp_Player_Winner.PlayerAnimator.PlayAnimation(newAnimName:  4, forceOverride:  false);
        val_16 = null;
        val_16 = null;
        UnityEngine.Vector3 val_8 = this.<>4__this.InkEmUp_Player_Winner.CenterPoint.position;
        this.<>4__this.CreateScorePopUp(score:  InkWars.Model.Model_Constants.ScoreInkEmUp_Activated, pos:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, player:  this.<>4__this.InkEmUp_Player_Winner, sizing:  1);
        goto label_20;
        label_1:
        this.<>1__state = 0;
        label_20:
        val_17 = this.<>4__this.InkEmUp_Player_Winner.PlayerAnimator;
        if((this.<>4__this.InkEmUp_Player_Winner.PlayerAnimator.currentAnimationName) != 8)
        {
            goto label_23;
        }
        
        val_17 = GameAudio.sound;
        UnityEngine.AudioSource val_10 = val_17.PlayOneShot(clip:  this.<>4__this.InkEmUp_Audio_Vortex, volume:  1f);
        this.<>4__this.InkEmUp_InkIndex = 0;
        InkWars.Model.Model_Core val_11 = View_Core.Model;
        int val_12 = val_11.InkEmUp_Player.BubbleCount;
        this.<>4__this.InkEmUp_InkBubbles = new View_Bubble[0];
        this.<>4__this.ConvertToInkBubbles(ring:  this.<>4__this.InkEmUp_Player_Winner.InnerRing);
        this.<>4__this.ConvertToInkBubbles(ring:  this.<>4__this.InkEmUp_Player_Winner.MiddleRing);
        this.<>4__this.ConvertToInkBubbles(ring:  this.<>4__this.InkEmUp_Player_Winner.OuterRing);
        this.<>4__this.SyncPlayerRings = true;
        this.<>4__this.PlayerWinner.BridgeManager.BridgeGlow.ChangeGlow(state:  3);
        InkWars.Model.Model_Core val_14 = View_Core.Model;
        if(val_14.InkEmUp_Player.Clan > 3)
        {
            goto label_37;
        }
        
        var val_16 = 40825384 + (val_14.InkEmUp_Player.Clan) << 2;
        val_16 = val_16 + 40825384;
        goto (40825384 + (val_14.InkEmUp_Player.Clan) << 2 + 40825384);
        label_2:
        val_19 = 0;
        return (bool)val_19;
        label_23:
        val_19 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_19;
        return (bool)val_19;
        label_37:
        this.<>4__this.InkEmUp_Player_Winner.ActiveBase.gameObject.SetActive(value:  true);
        this.<>4__this.InkEmUp_Player_Winner.ActiveBase.fillAmount = 1f;
        val_19 = 0;
        this.<>4__this.InkEmUp_ModelTrigger_ConvertToInk = true;
        this.<>4__this.SyncPlayerRings = false;
        return (bool)val_19;
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
