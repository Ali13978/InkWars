using UnityEngine;
private sealed class GameOverPanelSummary.<OnSummaryAnimationEnd>d__36 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameOverPanelSummary <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameOverPanelSummary.<OnSummaryAnimationEnd>d__36(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GameOverPanelSummary val_13;
        UnityEngine.AudioSource val_14;
        int val_15;
        var val_16;
        var val_17;
        val_13 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        val_14 = this.<>4__this.m_AudioSource;
        if(0 != val_14)
        {
                val_14 = this.<>4__this.m_AudioSource;
            val_14.Stop();
        }
        
        this.<>4__this.m_IsAnimating = false;
        UnityEngine.WaitForSeconds val_2 = null;
        val_13 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_15 = 1;
        this.<>2__current = val_13;
        this.<>1__state = val_15;
        return (bool)val_15;
        label_1:
        this.<>1__state = 0;
        val_14 = 1152921504858337280;
        if(0 == (this.<>4__this.rankController))
        {
            goto label_13;
        }
        
        val_16 = null;
        val_16 = null;
        if(DebugUserSettingPanel.MatchBeginRankPopup == 3)
        {
            goto label_36;
        }
        
        object[] val_4 = new object[1];
        val_17 = null;
        val_17 = null;
        val_4[0] = DebugUserSettingPanel.MatchEndRank;
        UnityEngine.Debug.LogFormat(format:  "MATCH END RANK: {0}", args:  val_4);
        val_14 = DebugUserSettingPanel.MatchEndRank;
        bool val_7 = this.<>4__this.rankController.CheckForNewRank(_forceRank:  (val_14 != 0) ? 1 : 0, _forceRankUp:  (val_14 == 1) ? 1 : 0);
        goto label_36;
        label_2:
        this.<>1__state = 0;
        val_14 = GameAudio.sound;
        UnityEngine.AudioSource val_9 = val_14.PlayOneShot(clip:  this.<>4__this.m_CountingDoneClip, volume:  1f);
        UnityEngine.WaitForSeconds val_10 = null;
        val_13 = val_10;
        val_10 = new UnityEngine.WaitForSeconds(seconds:  0.4f);
        this.<>2__current = val_13;
        this.<>1__state = 2;
        val_15 = 1;
        return (bool)val_15;
        label_13:
        UnityEngine.Debug.LogError(message:  "Cannot find RankingController");
        GameOverPanel val_11 = UnityEngine.Object.FindObjectOfType<GameOverPanel>();
        if(0 != val_11)
        {
                val_11.ShowButtonGroup();
        }
        
        label_36:
        val_13.HidePointPanels();
        label_3:
        val_15 = 0;
        return (bool)val_15;
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
