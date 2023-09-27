using UnityEngine;
private class AndroidNativeFunctions.ShowAlertListener : AndroidJavaProxy
{
    // Fields
    private UnityEngine.Events.UnityAction<DialogInterface> action;
    
    // Methods
    public AndroidNativeFunctions.ShowAlertListener(UnityEngine.Events.UnityAction<DialogInterface> a)
    {
        this.action = a;
    }
    public void onClick(UnityEngine.AndroidJavaObject obj, int which)
    {
        this.action.Invoke(arg0:  which);
    }

}
