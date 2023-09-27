using UnityEngine;
private class AndroidNativeFunctions.ShowAlertListListener : AndroidJavaProxy
{
    // Fields
    private string[] list;
    private UnityEngine.Events.UnityAction<string> action;
    
    // Methods
    public AndroidNativeFunctions.ShowAlertListListener(UnityEngine.Events.UnityAction<string> w, string[] a)
    {
        this.list = a;
        this.action = w;
    }
    public void onClick(UnityEngine.AndroidJavaObject obj, int which)
    {
        this.action.Invoke(arg0:  this.list[(long)which]);
    }

}
