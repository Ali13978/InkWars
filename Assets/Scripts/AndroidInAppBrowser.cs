using UnityEngine;
private class InAppBrowser.AndroidInAppBrowser
{
    // Methods
    public static void OpenURL(string URL, InAppBrowser.DisplayOptions displayOptions)
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        object[] val_3 = new object[3];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        val_3[1] = URL;
        val_3[2] = InAppBrowser.AndroidInAppBrowser.CreateJavaDisplayOptions(displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), displayURLAsPageTitle = false, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
        InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper().CallStatic(methodName:  "OpenInAppBrowser", args:  val_3);
    }
    public static void GoForward(string URL, InAppBrowser.DisplayOptions displayOptions)
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        object[] val_3 = new object[2];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        val_3[1] = InAppBrowser.AndroidInAppBrowser.CreateJavaDisplayOptions(displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), displayURLAsPageTitle = false, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
        InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper().CallStatic(methodName:  "GoForward", args:  val_3);
    }
    public static void LoadHTML(string HTML, InAppBrowser.DisplayOptions displayOptions)
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        object[] val_3 = new object[3];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        val_3[1] = HTML;
        val_3[2] = InAppBrowser.AndroidInAppBrowser.CreateJavaDisplayOptions(displayOptions:  new DisplayOptions() {insets = new InAppBrowser.EdgeInsets(), displayURLAsPageTitle = false, hidesTopBar = false, pinchAndZoomEnabled = false, shouldUsePlaybackCategory = false, shouldStickToPortrait = false, shouldStickToLandscape = false, androidBackButtonCustomBehaviour = false, mixedContentCompatibilityMode = false, webContentsDebuggingEnabled = false, shouldUseWideViewPort = false, hidesDefaultSpinner = false, hidesHistoryButtons = false, setLoadWithOverviewMode = false});
        InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper().CallStatic(methodName:  "LoadHTML", args:  val_3);
    }
    public static void CloseBrowser()
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper().CallStatic(methodName:  "CloseInAppBrowser", args:  val_3);
    }
    public static void ExecuteJS(string JSCommand)
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        object[] val_3 = new object[2];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        val_3[1] = JSCommand;
        InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper().CallStatic(methodName:  "SendJSMessage", args:  val_3);
    }
    public static void ClearCache()
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper().CallStatic(methodName:  "ClearCache", args:  val_3);
    }
    public static bool IsInAppBrowserOpened()
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        UnityEngine.AndroidJavaObject val_2 = InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper();
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        if(val_2 != null)
        {
                return val_2.CallStatic<System.Boolean>(methodName:  "IsInAppBrowserOpened", args:  val_3);
        }
        
        return val_2.CallStatic<System.Boolean>(methodName:  "IsInAppBrowserOpened", args:  val_3);
    }
    private static UnityEngine.AndroidJavaObject GetCurrentUnityActivity()
    {
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
        if(val_1 != null)
        {
                return val_1.GetStatic<System.Object>(fieldName:  "currentActivity");
        }
        
        return val_1.GetStatic<System.Object>(fieldName:  "currentActivity");
    }
    private static UnityEngine.AndroidJavaObject GetInAppBrowserHelper()
    {
        return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaClass(className:  "inappbrowser.kokosoft.com.Helper");
    }
    public static bool CanGoForward()
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        UnityEngine.AndroidJavaObject val_2 = InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper();
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        if(val_2 != null)
        {
                return val_2.CallStatic<System.Boolean>(methodName:  "CanGoForward", args:  val_3);
        }
        
        return val_2.CallStatic<System.Boolean>(methodName:  "CanGoForward", args:  val_3);
    }
    public static bool CanGoBack()
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        UnityEngine.AndroidJavaObject val_2 = InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper();
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        if(val_2 != null)
        {
                return val_2.CallStatic<System.Boolean>(methodName:  "CanGoBack", args:  val_3);
        }
        
        return val_2.CallStatic<System.Boolean>(methodName:  "CanGoBack", args:  val_3);
    }
    public static void GoBack()
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper().CallStatic(methodName:  "GoBack", args:  val_3);
    }
    public static void GoForward()
    {
        UnityEngine.AndroidJavaObject val_1 = InAppBrowser.AndroidInAppBrowser.GetCurrentUnityActivity();
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_1;
        InAppBrowser.AndroidInAppBrowser.GetInAppBrowserHelper().CallStatic(methodName:  "GoForward", args:  val_3);
    }
    private static UnityEngine.AndroidJavaObject CreateJavaDisplayOptions(InAppBrowser.DisplayOptions displayOptions)
    {
        UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "inappbrowser.kokosoft.com.DisplayOptions", args:  System.Array.Empty<System.Object>());
        if(displayOptions.pageTitle != null)
        {
                val_2.Set<System.String>(fieldName:  "pageTitle", val:  displayOptions.pageTitle);
        }
        
        if(displayOptions.backButtonText != null)
        {
                val_2.Set<System.String>(fieldName:  "backButtonText", val:  displayOptions.backButtonText);
        }
        
        if(displayOptions.barBackgroundColor != null)
        {
                val_2.Set<System.String>(fieldName:  "barBackgroundColor", val:  displayOptions.barBackgroundColor);
        }
        
        if(displayOptions.textColor != null)
        {
                val_2.Set<System.String>(fieldName:  "textColor", val:  displayOptions.textColor);
        }
        
        if(displayOptions.browserBackgroundColor != null)
        {
                val_2.Set<System.String>(fieldName:  "browserBackgroundColor", val:  displayOptions.browserBackgroundColor);
        }
        
        if(displayOptions.loadingIndicatorColor != null)
        {
                val_2.Set<System.String>(fieldName:  "loadingIndicatorColor", val:  displayOptions.loadingIndicatorColor);
        }
        
        val_2.Set<System.Boolean>(fieldName:  "displayURLAsPageTitle", val:  (displayOptions.displayURLAsPageTitle == true) ? 1 : 0);
        val_2.Set<System.Boolean>(fieldName:  "hidesTopBar", val:  (displayOptions.hidesTopBar == true) ? 1 : 0);
        val_2.Set<System.Boolean>(fieldName:  "pinchAndZoomEnabled", val:  (displayOptions.pinchAndZoomEnabled == true) ? 1 : 0);
        val_2.Set<System.Boolean>(fieldName:  "androidBackButtonCustomBehaviour", val:  (displayOptions.androidBackButtonCustomBehaviour == true) ? 1 : 0);
        val_2.Set<System.Boolean>(fieldName:  "mixedContentCompatibilityMode", val:  (displayOptions.mixedContentCompatibilityMode == true) ? 1 : 0);
        val_2.Set<System.Boolean>(fieldName:  "webContentsDebuggingEnabled", val:  (displayOptions.webContentsDebuggingEnabled == true) ? 1 : 0);
        val_2.Set<System.Boolean>(fieldName:  "hidesDefaultSpinner", val:  (displayOptions.hidesDefaultSpinner == true) ? 1 : 0);
        val_2.Set<System.Boolean>(fieldName:  "shouldUseWideViewPort", val:  (displayOptions.shouldUseWideViewPort == true) ? 1 : 0);
        val_2.Set<System.Boolean>(fieldName:  "hidesHistoryButtons", val:  (displayOptions.hidesHistoryButtons == true) ? 1 : 0);
        val_2.Set<System.Boolean>(fieldName:  "setLoadWithOverviewMode", val:  (displayOptions.setLoadWithOverviewMode == true) ? 1 : 0);
        if(displayOptions.titleFontSize != null)
        {
                val_2.Set<System.Int32>(fieldName:  "titleFontSize", val:  System.Int32.Parse(s:  displayOptions.titleFontSize));
        }
        
        if(displayOptions.historyButtonsFontSize != null)
        {
                val_2.Set<System.Int32>(fieldName:  "historyButtonsFontSize", val:  System.Int32.Parse(s:  displayOptions.historyButtonsFontSize));
        }
        
        if(displayOptions.historyButtonsSpacing != null)
        {
                val_2.Set<System.Int32>(fieldName:  "historyButtonsSpacing", val:  System.Int32.Parse(s:  displayOptions.historyButtonsSpacing));
        }
        
        if(displayOptions.titleLeftRightPadding != null)
        {
                val_2.Set<System.Int32>(fieldName:  "titleLeftRightPadding", val:  System.Int32.Parse(s:  displayOptions.titleLeftRightPadding));
        }
        
        if(displayOptions.backButtonFontSize != null)
        {
                val_2.Set<System.Int32>(fieldName:  "backButtonFontSize", val:  System.Int32.Parse(s:  displayOptions.backButtonFontSize));
        }
        
        if(displayOptions.backButtonLeftRightMargin != null)
        {
                val_2.Set<System.Int32>(fieldName:  "backButtonLeftRightMargin", val:  System.Int32.Parse(s:  displayOptions.backButtonLeftRightMargin));
        }
        
        val_2.Set<System.Int32>(fieldName:  "paddingTop", val:  displayOptions.insets.top);
        val_2.Set<System.Int32>(fieldName:  "paddingBottom", val:  displayOptions.insets.bottom);
        val_2.Set<System.Int32>(fieldName:  "paddingLeft", val:  displayOptions.insets.left);
        val_2.Set<System.Int32>(fieldName:  "paddingRight", val:  displayOptions.insets.right);
        return val_2;
    }
    public InAppBrowser.AndroidInAppBrowser()
    {
    
    }

}
