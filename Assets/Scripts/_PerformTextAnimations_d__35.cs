using UnityEngine;
private sealed class GameOverPanelSummary.<PerformTextAnimations>d__35 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameOverPanelSummary <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameOverPanelSummary.<PerformTextAnimations>d__35(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        DataUIRef val_10;
        TMPro.TextMeshProUGUI val_11;
        DataUIRef val_12;
        int val_13;
        DataUIRef val_14;
        DataUIRef val_15;
        if((this.<>1__state) == 2)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_9;
        }
        
        this.<>1__state = 0;
        UnityEngine.Coroutine val_3 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.PlayCountingSound(_delay:  this.<>4__this.m_CountingClip.length));
        val_10 = this.<>4__this.m_DataReferences;
        if(val_10 == null)
        {
            goto label_5;
        }
        
        val_11 = this.<>4__this.m_DataReferences.PlayerPointsTotalScoreText;
        val_12 = val_10;
        goto label_15;
        label_0:
        this.<>1__state = 0;
        if(((this.<>4__this.m_PPSaved) != false) && ((this.<>4__this.m_BPSaved) != false))
        {
                UnityEngine.Coroutine val_5 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.OnSummaryAnimationEnd());
        }
        
        label_9:
        val_13 = 0;
        return (bool)val_13;
        label_1:
        this.<>1__state = 0;
        val_14 = this.<>4__this.m_DataReferences;
        if(val_14 == null)
        {
            goto label_12;
        }
        
        val_11 = this.<>4__this.m_DataReferences.BattlePointsTotalScoreText;
        val_15 = val_14;
        goto label_17;
        label_5:
        val_12 = this.<>4__this.m_DataReferences;
        val_11 = this.<>4__this.m_DataReferences.PlayerPointsTotalScoreText;
        if(val_12 == null)
        {
            goto label_14;
        }
        
        val_10 = val_12;
        goto label_15;
        label_12:
        val_15 = this.<>4__this.m_DataReferences;
        val_11 = this.<>4__this.m_DataReferences.BattlePointsTotalScoreText;
        if(val_15 == null)
        {
            goto label_16;
        }
        
        val_14 = val_15;
        goto label_17;
        label_16:
        val_14 = this.<>4__this.m_DataReferences;
        if(val_14 == null)
        {
            goto label_20;
        }
        
        label_17:
        this.<>2__current = this.<>4__this.StartCoroutine(routine:  this.<>4__this.SubtractText(_totalPointsText:  val_11, _earnedPointsText:  this.<>4__this.m_DataReferences.BattlePointsEarnedScoreText, _totalPoints:  this.<>4__this.m_OriginalBP, _earnedPoints:  this.<>4__this.m_DataReferences.BattlePointsEarnedScore, _overwritePP:  false, _subtract:  this.<>4__this.PlayerLost));
        this.<>1__state = 2;
        val_13 = 1;
        return (bool)val_13;
        label_14:
        val_10 = this.<>4__this.m_DataReferences;
        if(val_10 == null)
        {
            goto label_20;
        }
        
        label_15:
        val_13 = 1;
        this.<>2__current = this.<>4__this.StartCoroutine(routine:  this.<>4__this.SubtractText(_totalPointsText:  val_11, _earnedPointsText:  this.<>4__this.m_DataReferences.PlayerPointsEarnedScoreText, _totalPoints:  this.<>4__this.m_OriginalPP, _earnedPoints:  this.<>4__this.m_DataReferences.PlayerPointsEarnedScore, _overwritePP:  true, _subtract:  this.<>4__this.PlayerLost));
        this.<>1__state = val_13;
        return (bool)val_13;
        label_20:
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
