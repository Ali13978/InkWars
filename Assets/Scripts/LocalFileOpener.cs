using UnityEngine;
public class LocalFileOpener : MonoBehaviour
{
    // Fields
    public string pathToFile;
    public string htmlToLoad;
    
    // Methods
    public void OnButtonClicked()
    {
        InAppBrowser.OpenLocalFile(filePath:  this.pathToFile, displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), pageTitle = "Local File Example", displayURLAsPageTitle = false, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
    }
    public void OnHTMLClicked()
    {
        InAppBrowser.LoadHTML(HTML:  this.htmlToLoad, options:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), pageTitle = "HTML Example", displayURLAsPageTitle = false, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
    }
    public LocalFileOpener()
    {
        this.pathToFile = "/LocalSite/index.html";
        this.htmlToLoad = "<p>Hello HTML!</p>";
    }

}
