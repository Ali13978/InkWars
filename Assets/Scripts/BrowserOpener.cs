using UnityEngine;
public class BrowserOpener : MonoBehaviour
{
    // Fields
    public string pageToOpen;
    
    // Methods
    public void OnButtonClicked()
    {
        InAppBrowser.OpenURL(URL:  this.pageToOpen, displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), pageTitle = "InAppBrowser example", displayURLAsPageTitle = false, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
    }
    public void OnClearCacheClicked()
    {
        InAppBrowser.ClearCache();
    }
    public BrowserOpener()
    {
        this.pageToOpen = "http://www.google.com";
    }

}
