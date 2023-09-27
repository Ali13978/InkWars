using UnityEngine;
private class AndroidNativeFunctions.ShowAlertInputListener : AndroidJavaProxy
{
    // Fields
    private UnityEngine.Events.UnityAction<DialogInterface, string> action;
    private UnityEngine.AndroidJavaObject editText;
    
    // Methods
    public AndroidNativeFunctions.ShowAlertInputListener(UnityEngine.Events.UnityAction<DialogInterface, string> a, UnityEngine.AndroidJavaObject et)
    {
        this.action = a;
        this.editText = et;
    }
    public void onClick(UnityEngine.AndroidJavaObject obj, int which)
    {
        this.action.Invoke(arg0:  which, arg1:  this.editText.Call<UnityEngine.AndroidJavaObject>(methodName:  "getText", args:  System.Array.Empty<System.Object>()).Call<System.String>(methodName:  "toString", args:  System.Array.Empty<System.Object>()));
    }

}
