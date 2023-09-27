using UnityEngine;
private sealed class LoadingScreenController.<>c__DisplayClass17_0
{
    // Fields
    public System.Action onDone;
    
    // Methods
    public LoadingScreenController.<>c__DisplayClass17_0()
    {
    
    }
    internal void <FlyIn>b__0()
    {
        var val_1;
        if(this.onDone != null)
        {
                this.onDone.Invoke();
        }
        
        val_1 = null;
        val_1 = null;
        LoadingScreenController.OnFlyInDone.Invoke();
        LoadingScreenController.OnFlyInDone.RemoveAllListeners();
    }

}
