using UnityEngine;
public class JSExecute : MonoBehaviour
{
    // Fields
    public string javaScriptCode;
    
    // Methods
    private void Start()
    {
        InAppBrowserBridge val_1 = UnityEngine.Object.FindObjectOfType<InAppBrowserBridge>();
        val_1.onJSCallback.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void JSExecute::OnMessageFromJS(string jsMessage)));
    }
    private void OnMessageFromJS(string jsMessage)
    {
        if((jsMessage.Equals(value:  "ping")) == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Ping message received!");
        InAppBrowser.ExecuteJS(JSCommand:  this.javaScriptCode);
    }
    public JSExecute()
    {
        this.javaScriptCode = "alert(\'pong!\')";
    }

}
