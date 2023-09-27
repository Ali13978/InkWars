using UnityEngine;
private sealed class LineControllerP2.<showStartText>d__84 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineControllerP2 <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineControllerP2.<showStartText>d__84(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BattleVSGates val_4;
        int val_5;
        val_4 = this;
        if((this.<>1__state) < 2)
        {
                this.<>1__state = 0;
            if(NetworkDelayOverlay.IsWaiting != false)
        {
                val_5 = 1;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
            this.<>4__this.textAreYouReady.SetActive(value:  true);
            this.<>4__this.textGameOn.SetActive(value:  true);
            val_4 = BattleVSGates.instance;
            if(val_4 == 0)
        {
                MusicTitlePopup.GameplayStart_FadeOutCalled();
        }
        
        }
        
        val_5 = 0;
        return (bool)val_5;
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
