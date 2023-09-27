using UnityEngine;
public class InAppBrowserBridge : MonoBehaviour
{
    // Fields
    public InAppBrowserBridge.BrowserLoadingCallback onJSCallback;
    public InAppBrowserBridge.BrowserLoadingCallback onBrowserFinishedLoading;
    public InAppBrowserBridge.BrowserLoadingCallback onBrowserStartedLoading;
    public InAppBrowserBridge.BrowserLoadingWithErrorCallback onBrowserFinishedLoadingWithError;
    public UnityEngine.Events.UnityEvent onBrowserClosed;
    public UnityEngine.Events.UnityEvent onAndroidBackButtonPressed;
    
    // Methods
    private void OnBrowserJSCallback(string callback)
    {
        UnityEngine.Debug.Log(message:  "InAppBrowser: JS Message: "("InAppBrowser: JS Message: ") + callback);
        this.onJSCallback.Invoke(arg0:  callback);
    }
    private void OnBrowserFinishedLoading(string url)
    {
        UnityEngine.Debug.Log(message:  "InAppBrowser: FinishedLoading "("InAppBrowser: FinishedLoading ") + url);
        this.onBrowserFinishedLoading.Invoke(arg0:  url);
    }
    private void OnBrowserStartedLoading(string url)
    {
        UnityEngine.Debug.Log(message:  "InAppBrowser: StartedLoading "("InAppBrowser: StartedLoading ") + url);
        this.onBrowserStartedLoading.Invoke(arg0:  url);
    }
    private void OnBrowserFinishedLoadingWithError(string urlAndError)
    {
        int val_6;
        UnityEngine.Debug.Log(message:  "InAppBrowser: FinishedLoading With Error "("InAppBrowser: FinishedLoading With Error ") + urlAndError);
        char[] val_2 = new char[1];
        val_2[0] = ',';
        System.String[] val_3 = urlAndError.Split(separator:  val_2);
        UnityEngine.Debug.Log(message:  "URL:"("URL:") + val_3[0]);
        UnityEngine.Debug.Log(message:  "ERROR:"("ERROR:") + val_3[1]);
        val_6 = val_3.Length;
        if(val_6 == 0)
        {
                val_6 = val_3.Length;
        }
        
        this.onBrowserFinishedLoadingWithError.Invoke(arg0:  val_3[0], arg1:  val_3[1]);
    }
    private void OnBrowserClosed()
    {
        UnityEngine.Debug.Log(message:  "InAppBrowser: Closed");
        this.onBrowserClosed.Invoke();
    }
    private void OnAndroidBackButtonPressed()
    {
        UnityEngine.Debug.Log(message:  "InAppBrowser: Android back button pressed");
        this.onAndroidBackButtonPressed.Invoke();
    }
    public InAppBrowserBridge()
    {
        this.onJSCallback = new InAppBrowserBridge.BrowserLoadingCallback();
        this.onBrowserFinishedLoading = new InAppBrowserBridge.BrowserLoadingCallback();
        this.onBrowserStartedLoading = new InAppBrowserBridge.BrowserLoadingCallback();
        this.onBrowserFinishedLoadingWithError = new InAppBrowserBridge.BrowserLoadingWithErrorCallback();
        this.onBrowserClosed = new UnityEngine.Events.UnityEvent();
        this.onAndroidBackButtonPressed = new UnityEngine.Events.UnityEvent();
    }

}
