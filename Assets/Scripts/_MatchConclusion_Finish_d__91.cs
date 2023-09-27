using UnityEngine;
private sealed class View_Core.<MatchConclusion_Finish>d__91 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_Core <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_Core.<MatchConclusion_Finish>d__91(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        View_Core val_9;
        float val_10;
        InkWars.Model.Player val_11;
        int val_13;
        val_9 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.animText_MatchConclusionPartOne.SetActive(value:  false);
        this.<>4__this.animTextPuzzleYouCracked.SetActive(value:  false);
        this.<>4__this.animExBattleVictory.SetActive(value:  false);
        this.<>4__this.SyncPlayerRings = true;
        InkWars.Model.GameResult val_2 = View_Core.Model.GameResult;
        if(val_2 == 5)
        {
            goto label_8;
        }
        
        val_10 = 0f;
        if(val_2 != 4)
        {
            goto label_9;
        }
        
        val_11 = 1;
        goto label_10;
        label_1:
        this.<>1__state = 0;
        InkWars.Model.Model_Core val_3 = View_Core.Model;
        if(val_9 == null)
        {
            goto label_12;
        }
        
        if(val_3.InkEmUp_CurrentPhase == 0)
        {
            goto label_13;
        }
        
        label_15:
        System.Collections.IEnumerator val_4 = val_9.InkEmUp_Setup();
        goto label_14;
        label_12:
        if(val_3.InkEmUp_CurrentPhase != 0)
        {
            goto label_15;
        }
        
        label_13:
        label_14:
        UnityEngine.Coroutine val_6 = val_9.StartCoroutine(routine:  val_9.TriggerPostMatchPanel());
        label_2:
        val_13 = 0;
        return (bool)val_13;
        label_8:
        val_11 = 0;
        label_10:
        if((val_9.GetPlayer(playerID:  val_11)) == null)
        {
            goto label_18;
        }
        
        val_10 = 3f;
        val_7.AnimTrigger_Lose = true;
        label_9:
        UnityEngine.WaitForSeconds val_8 = null;
        val_9 = val_8;
        val_8 = new UnityEngine.WaitForSeconds(seconds:  val_10);
        val_13 = 1;
        this.<>2__current = val_9;
        this.<>1__state = val_13;
        return (bool)val_13;
        label_18:
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
