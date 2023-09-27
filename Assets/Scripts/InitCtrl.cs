using UnityEngine;
public class InitCtrl : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI stateTxt;
    private static bool checkFireBaseDone;
    private static bool fetchRemoteConfigDone;
    private float interval;
    private int loadingTextDotCount;
    
    // Methods
    private void UpdateLoadingText()
    {
        int val_4 = this.loadingTextDotCount;
        if(val_4 >= 1)
        {
                var val_4 = 0;
            do
        {
            string val_1 = "Entering Octopia" + ".";
            val_4 = this.loadingTextDotCount;
            val_4 = val_4 + 1;
        }
        while(val_4 < val_4);
        
        }
        
        this.loadingTextDotCount = ((val_4 + 1) > 3) ? 1 : (val_4 + 1);
    }
    private void LogDiff(string info)
    {
        UnityEngine.Debug.Log(message:  "============>> "("============>> ") + info);
        this.stateTxt.text = info;
    }
    private System.Collections.IEnumerator Start()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InitCtrl.<Start>d__7();
    }
    private void OnConnectionTestResult(bool isConnect, string info)
    {
        if(isConnect != false)
        {
                AzureRemoteConfig.FetchRemote(callback:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  this, method:  System.Void InitCtrl::OnFetchRemoteConfigDone(bool success, string info)));
            return;
        }
        
        DialogManager.Show(title:  "Init Scene", message:  "Not connected to internet", cancelButtonTitle:  0, onCancelCallback:  0).GoToOfflineMode();
    }
    private void OnFetchRemoteConfigDone(bool success, string info)
    {
        if(success != false)
        {
                VIPCollection.SetupVIPFromRemoteConfig();
            BattleBonusConfig.FetchBonus(OnDone:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InitCtrl::<OnFetchRemoteConfigDone>b__9_0()));
            return;
        }
        
        DialogManager.Show(title:  "Init Scene", message:  "Fetch remote config failed. Go to offline mode", cancelButtonTitle:  0, onCancelCallback:  0).GoToOfflineModeWithRedirectMsg();
    }
    private void OnGameVersionCheckPass()
    {
        GameServerManager.FetchGameServerIP(OnDone:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InitCtrl::OnServerListLoaded()), showLoadingWhenProc:  false);
    }
    private void OnServerListLoaded()
    {
        BattleBonusConfig.FetchBonus(OnDone:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InitCtrl::OnBattleBonusLoaded()));
    }
    private void OnBattleBonusLoaded()
    {
        NFUser.UpdateServerTime();
        NFServerTime.WaitUntilServerTimeActive(callback:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InitCtrl::TryAutoLogin()));
    }
    private void TryAutoLogin()
    {
        bool val_2 = NFUser.current.TryLoadFromDevice();
        if(val_2 != false)
        {
                NFUser.current.clientUser.IWRefresh(callback:  new UnityEngine.Events.UnityAction<RefreshDataResponse>(object:  this, method:  System.Void InitCtrl::<TryAutoLogin>b__13_0(NFClientUser.RefreshDataResponse res)));
            return;
        }
        
        val_2.GoToQuickPlay();
    }
    private void GoToFetchData()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "FetchData");
    }
    private void GoToOfflineMode()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "OfflineTitleScreen");
    }
    private void GoToOfflineModeWithRedirectMsg()
    {
        DialogManager.Show(title:  "LK.Error", message:  "LK.Error.RedirectToOfflineMode", cancelButtonTitle:  0, onCancelCallback:  0).GoToOfflineMode();
    }
    private void GoToQuickPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "QuickPlay");
    }
    public InitCtrl()
    {
        this.interval = 3f;
        this.loadingTextDotCount = 1;
    }
    private static InitCtrl()
    {
    
    }
    private void <OnFetchRemoteConfigDone>b__9_0()
    {
        GameVersionCheck.CheckGameVersion(OnDone:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void InitCtrl::OnGameVersionCheckPass()), showLoadingWhenProc:  false);
    }
    private void <TryAutoLogin>b__13_0(NFClientUser.RefreshDataResponse res)
    {
        if(res.IsSuccess != false)
        {
                IWServerDB_Cache.EnableSaveRoutine(enable:  true);
            this.GoToFetchData();
            return;
        }
        
        NFUser val_2 = NFUser.current;
        val_2.loginUserInfo.Clear();
        val_2.loginUserInfo.GoToQuickPlay();
    }

}
