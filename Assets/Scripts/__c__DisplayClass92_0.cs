using UnityEngine;
private sealed class View_Core.<>c__DisplayClass92_0
{
    // Fields
    public bool isPlayerWin;
    
    // Methods
    public View_Core.<>c__DisplayClass92_0()
    {
    
    }
    internal void <TriggerPostMatchPanel>b__2()
    {
        AdventurePostMatch.Show(isPlayerWin:  this.isPlayerWin);
    }

}
