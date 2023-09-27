using UnityEngine;
private sealed class QuickPlayCanvas.<>c__DisplayClass19_0
{
    // Fields
    public bool isLoginMode;
    public UnityEngine.Events.UnityAction <>9__1;
    
    // Methods
    public QuickPlayCanvas.<>c__DisplayClass19_0()
    {
    
    }
    internal void <CheckGameVersionThenGoToServerSelection>b__0(bool success, string info)
    {
        UnityEngine.Events.UnityAction val_2;
        if(success != false)
        {
                val_2 = this.<>9__1;
            if(val_2 == null)
        {
                UnityEngine.Events.UnityAction val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void QuickPlayCanvas.<>c__DisplayClass19_0::<CheckGameVersionThenGoToServerSelection>b__1());
            this.<>9__1 = val_2;
        }
        
            GameVersionCheck.CheckGameVersion(OnDone:  val_1, showLoadingWhenProc:  false);
            return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "OfflineTitleScreen");
    }
    internal void <CheckGameVersionThenGoToServerSelection>b__1()
    {
        ServerSelectionPanel.Show(isLoginMode:  this.isLoginMode);
    }

}
