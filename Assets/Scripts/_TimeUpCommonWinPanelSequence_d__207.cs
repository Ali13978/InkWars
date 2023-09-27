using UnityEngine;
private sealed class LineController.<TimeUpCommonWinPanelSequence>d__207 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    public GameResult gameResult;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<TimeUpCommonWinPanelSequence>d__207(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_3;
        int val_4;
        val_3 = this;
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
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        GameOverPanel.ShowBanner();
        goto label_5;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.lifeHandler.SetActive(value:  true);
        if((this.<>4__this.modeName) == 5)
        {
                this.<>4__this.PopPVPWinPanel(gameResult:  this.gameResult);
            this.<>4__this.LeaderboardUpdate(index:  0);
            this.<>4__this.LeaderboardUpdate(index:  3);
            this.<>4__this.LeaderboardUpdate(index:  4);
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
            this.<>1__state = 2;
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_3 = this.<>4__this.win_Panel;
        val_3.SetActive(value:  true);
        TimeTracker.AssignRewardTime();
        label_5:
        UnityEngine.Time.timeScale = 0f;
        label_3:
        val_4 = 0;
        return (bool)val_4;
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
