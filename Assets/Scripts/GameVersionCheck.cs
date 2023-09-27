using UnityEngine;
public static class GameVersionCheck
{
    // Fields
    private static UnityEngine.Events.UnityEvent OnVersionCheckDoneEvent;
    
    // Methods
    public static void CheckGameVersion(UnityEngine.Events.UnityAction OnDone, bool showLoadingWhenProc = False)
    {
        null = null;
        GameVersionCheck.OnVersionCheckDoneEvent.AddListener(call:  OnDone);
        if(GameVersionCheck.IsPlayableVersion() != false)
        {
                GameVersionCheck.OnVersionCorrect();
            return;
        }
        
        if(showLoadingWhenProc != false)
        {
                DialogManager.ShowLoading();
        }
        
        AzureRemoteConfig.FetchRemote(callback:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  0, method:  static System.Void GameVersionCheck::OnVersionFetchDone(bool success, string error)));
    }
    private static void OnVersionFetchDone(bool success, string error)
    {
        var val_2;
        DialogManager.HideLoading();
        val_2 = null;
        if(success == false)
        {
            goto label_3;
        }
        
        if(GameVersionCheck.IsPlayableVersion() == false)
        {
            goto label_6;
        }
        
        GameVersionCheck.OnVersionCorrect();
        return;
        label_3:
        GameVersionCheck.OnFetchFail();
        return;
        label_6:
        GameVersionCheck.OnVersionIncorrect();
    }
    private static bool IsPlayableVersion()
    {
        string val_1 = AzureRemoteConfig.GetString(key:  "data.active_game_version", defaultValue:  "");
        string val_2 = VersionText.GetVersionString(format:  "{0}.{1}");
        object[] val_3 = new object[2];
        if(val_3 == null)
        {
            goto label_5;
        }
        
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_1 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_3[0] = val_1;
        val_3[1] = val_2;
        UnityEngine.Debug.LogFormat(format:  "Remote ver {0}, local ver {1}", args:  val_3);
        return VersionText.SameOrHigherVersion(v1:  val_2, v2:  val_1);
    }
    private static void OnVersionCorrect()
    {
        null = null;
        GameVersionCheck.OnVersionCheckDoneEvent.Invoke();
        GameVersionCheck.OnVersionCheckDoneEvent.RemoveAllListeners();
    }
    private static void OnVersionIncorrect()
    {
        DialogPanel val_2 = DialogManager.ShowConfirmDialog(title:  "LK.UpdateGameTitle", message:  "LK.UpdateGameMessage", confirmButtonTitle:  "LK.Update", cancelButtonTitle:  0, onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  0, method:  static System.Void GameVersionCheck::OpenAppPage()), onCancelCallback:  0);
    }
    private static void OnFetchFail()
    {
        DialogPanel val_1 = DialogManager.Show(title:  "LK.CannotConnectServerTitle", message:  "LK.CannotConnectServerMessage", cancelButtonTitle:  0, onCancelCallback:  0);
    }
    private static void OpenAppPage()
    {
        UnityEngine.Application.OpenURL(url:  "https://dolcegame.com.au");
    }
    private static void SetFetchEnable(bool enable)
    {
        if(enable != false)
        {
                DialogManager.ShowLoading();
            return;
        }
        
        DialogManager.HideLoading();
    }
    private static GameVersionCheck()
    {
        GameVersionCheck.OnVersionCheckDoneEvent = new UnityEngine.Events.UnityEvent();
    }

}
