using UnityEngine;
public class InAppBrowser
{
    // Methods
    private static InAppBrowser.DisplayOptions CreateDefaultOptions()
    {
        DisplayOptions val_0;
        val_0.historyButtonsSpacing = 0;
        mem[1152921526121460753] = 0;
        val_0.barBackgroundColor = 0;
        val_0.browserBackgroundColor = 0;
        val_0.insets.top = 0;
        val_0.insets.left = 0;
        val_0.insets.right = 0;
        val_0.insets.bottom = 0;
        val_0.pageTitle = 0;
        val_0.displayURLAsPageTitle = true;
        mem[1152921526121460737] = 0;
        mem[1152921526121460721] = 0;
        val_0.hidesTopBar = 0;
        val_0.pinchAndZoomEnabled = false;
        val_0.shouldUsePlaybackCategory = false;
        val_0.shouldStickToPortrait = false;
        val_0.shouldStickToLandscape = false;
        val_0.androidBackButtonCustomBehaviour = false;
        val_0.mixedContentCompatibilityMode = false;
        val_0.webContentsDebuggingEnabled = false;
        val_0.shouldUseWideViewPort = false;
        return val_0;
    }
    private static string PathCombine(string path1, string path2)
    {
        System.Char[] val_6;
        string val_7;
        var val_8;
        val_7 = path2;
        if((System.IO.Path.IsPathRooted(path:  val_7)) == false)
        {
                return System.IO.Path.Combine(path1:  path1, path2:  val_7 = val_7.TrimStart(trimChars:  char[] val_2 = new char[1]).TrimStart(trimChars:  char[] val_4 = new char[1]));
        }
        
        val_8 = null;
        val_8 = null;
        val_2[0] = System.IO.Path.DirectorySeparatorChar;
        val_6 = val_4;
        val_6[0] = System.IO.Path.AltDirectorySeparatorChar;
        return System.IO.Path.Combine(path1:  path1, path2:  val_7);
    }
    public static void OpenURL(string URL)
    {
        InAppBrowser.AndroidInAppBrowser.OpenURL(URL:  URL, displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), displayURLAsPageTitle = true, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
    }
    public static void OpenLocalFile(string fileName)
    {
        InAppBrowser.AndroidInAppBrowser.OpenURL(URL:  fileName, displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), displayURLAsPageTitle = true, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
    }
    public static void LoadHTML(string HTML)
    {
        InAppBrowser.AndroidInAppBrowser.LoadHTML(HTML:  HTML, displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), displayURLAsPageTitle = true, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
    }
    public static bool IsInAppBrowserOpened()
    {
        return InAppBrowser.AndroidInAppBrowser.IsInAppBrowserOpened();
    }
    public static void OpenURL(string URL, InAppBrowser.DisplayOptions displayOptions)
    {
        InAppBrowser.AndroidInAppBrowser.OpenURL(URL:  URL, displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), displayURLAsPageTitle = false, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
    }
    public static void OpenLocalFile(string filePath, InAppBrowser.DisplayOptions displayOptions)
    {
        InAppBrowser.AndroidInAppBrowser.OpenURL(URL:  filePath, displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), displayURLAsPageTitle = false, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
    }
    public static void LoadHTML(string HTML, InAppBrowser.DisplayOptions options)
    {
        InAppBrowser.AndroidInAppBrowser.LoadHTML(HTML:  HTML, displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), displayURLAsPageTitle = false, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
    }
    public static void CloseBrowser()
    {
        InAppBrowser.AndroidInAppBrowser.CloseBrowser();
    }
    public static void ExecuteJS(string JSCommand)
    {
        InAppBrowser.AndroidInAppBrowser.ExecuteJS(JSCommand:  JSCommand);
    }
    public static bool CanGoBack()
    {
        return InAppBrowser.AndroidInAppBrowser.CanGoBack();
    }
    public static bool CanGoForward()
    {
        return InAppBrowser.AndroidInAppBrowser.CanGoForward();
    }
    public static void GoBack()
    {
        InAppBrowser.AndroidInAppBrowser.GoBack();
    }
    public static void GoForward()
    {
        InAppBrowser.AndroidInAppBrowser.GoForward();
    }
    public static void ClearCache()
    {
        InAppBrowser.AndroidInAppBrowser.ClearCache();
    }
    public InAppBrowser()
    {
    
    }

}
