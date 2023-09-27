using UnityEngine;
private sealed class View_Core.<TriggerPostMatchPanel>d__92 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_Core <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_Core.<TriggerPostMatchPanel>d__92(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        View_Core val_42;
        View_Objects val_43;
        View_Objects val_44;
        View_Objects val_45;
        var val_46;
        int val_47;
        var val_54;
        var val_56;
        val_42 = this.<>4__this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        val_43 = this.<>4__this.LeftPlayer;
        val_44 = val_43;
        if(val_43 != null)
        {
            goto label_3;
        }
        
        val_44 = this.<>4__this.LeftPlayer;
        if(val_44 == null)
        {
            goto label_7;
        }
        
        label_3:
        if((this.<>4__this.LeftPlayer.ScoreCalculated) == (this.<>4__this.LeftPlayer.ScoreDisplay))
        {
            goto label_5;
        }
        
        val_43 = this.<>4__this.RightPlayer;
        val_45 = val_43;
        if(val_43 != null)
        {
            goto label_6;
        }
        
        val_45 = this.<>4__this.RightPlayer;
        if(val_45 == null)
        {
            goto label_7;
        }
        
        label_6:
        if((this.<>4__this.RightPlayer.ScoreCalculated) != (this.<>4__this.RightPlayer.ScoreDisplay))
        {
            goto label_8;
        }
        
        label_5:
        InkWars.Model.Model_Events.Instance.Event_OnBeforePostMatch();
        val_46 = null;
        val_46 = null;
        val_47 = 0;
        if((Character_GlobalInfo.gameMode - 1) > 9)
        {
                return (bool)val_47;
        }
        
        var val_42 = 40825400 + ((Character_GlobalInfo.gameMode - 1)) << 2;
        val_42 = val_42 + 40825400;
        goto (40825400 + ((Character_GlobalInfo.gameMode - 1)) << 2 + 40825400);
        label_1:
        if((this.<>1__state) != 0)
        {
            goto label_78;
        }
        
        this.<>1__state = 0;
        if((View_Core.Model.GameResult - 2) > 4)
        {
            goto label_20;
        }
        
        var val_43 = 40825440 + ((val_8 - 2)) << 2;
        val_43 = val_43 + 40825440;
        goto (40825440 + ((val_8 - 2)) << 2 + 40825440);
        label_8:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_47 = 1;
        return (bool)val_47;
        label_20:
        val_43 = 0;
        if(Character_GlobalInfo.IsFirstBossFightMatch() != true)
        {
                val_54 = null;
            val_54 = null;
            if(val_42 == null)
        {
                val_54 = null;
        }
        
            val_43 = mem[Character_GlobalInfo.gameMode == 0x5 ? this.<>4__this.AnimTextSprite_PlayerOneWins : this.<>4__this.AnimTextSprite_YouWin];
            val_43 = (Character_GlobalInfo.gameMode == 5) ? this.<>4__this.AnimTextSprite_PlayerOneWins : this.<>4__this.AnimTextSprite_YouWin;
            val_54 = null;
            GameAudio.SwitchMusicOneShot(clip:  (Character_GlobalInfo.gameMode == 2) ? this.<>4__this.audio_AdventureGameCleared : this.<>4__this.audio_MatchOutcomeWin, forcePlay:  false);
        }
        
        this.<>4__this.animText_MatchConclusionPartTwo.GetComponent<UnityEngine.SpriteRenderer>().sprite = ;
        val_56 = null;
        val_56 = null;
        GameMode val_44 = Character_GlobalInfo.gameMode;
        val_44 = val_44 - 3;
        if(val_44 > 7)
        {
            goto label_87;
        }
        
        var val_45 = 40825460 + ((Character_GlobalInfo.gameMode - 3)) << 2;
        val_45 = val_45 + 40825460;
        goto (40825460 + ((Character_GlobalInfo.gameMode - 3)) << 2 + 40825460);
        label_87:
        if(Character_GlobalInfo.IsFirstBossFightMatch() != true)
        {
                val_43 = View_Core.Model;
            if(val_43.GameResult != 6)
        {
                val_43 = View_Core.Model;
            if(val_43.GameResult != 3)
        {
                this.<>4__this.PlayerWinner.AnimTrigger_Win = true;
        }
        
        }
        
        }
        
        UnityEngine.WaitForSeconds val_29 = null;
        val_42 = val_29;
        val_29 = new UnityEngine.WaitForSeconds(seconds:  4f);
        val_47 = 1;
        this.<>2__current = val_42;
        this.<>1__state = val_47;
        return (bool)val_47;
        label_78:
        val_47 = 0;
        return (bool)val_47;
        label_7:
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
