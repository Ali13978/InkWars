using UnityEngine;
private sealed class LoadingScreenController.<>c__DisplayClass18_0
{
    // Fields
    public LoadingScreenController <>4__this;
    public System.Action onDone;
    
    // Methods
    public LoadingScreenController.<>c__DisplayClass18_0()
    {
    
    }
    internal void <FlyOut>b__0()
    {
        var val_2;
        LoadingScreenController.isShowing = false;
        this.<>4__this.animPanel.gameObject.SetActive(value:  false);
        if(this.onDone != null)
        {
                this.onDone.Invoke();
        }
        
        val_2 = null;
        val_2 = null;
        LoadingScreenController.OnFlyOutDone.Invoke();
        LoadingScreenController.OnFlyOutDone.RemoveAllListeners();
    }

}
