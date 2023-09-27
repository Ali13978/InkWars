using UnityEngine;
public class DataFetchCtrl : MonoBehaviour
{
    // Fields
    public static bool isNewUser;
    private TMPro.TextMeshProUGUI stateText;
    private LoadingBar loadingBar;
    private UnityEngine.AudioClip bgm;
    private const string nextScene = "Menu_Title_Screen";
    private const string prevScene = "SignIn";
    
    // Methods
    private void Awake()
    {
        GameAudio.SwitchMusic(clip:  this.bgm, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        this.StartDataRetrieval();
    }
    public void Enter(System.Action onDone)
    {
        .onDone = onDone;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.1f);
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.stateText.transform, endValue:  0f, duration:  0.3f)), ease:  27));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.loadingBar.transform, endValue:  0f, duration:  0.3f)), ease:  27), delay:  0.15f));
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  new DataFetchCtrl.<>c__DisplayClass7_0(), method:  System.Void DataFetchCtrl.<>c__DisplayClass7_0::<Enter>b__0()));
    }
    private void StartDataRetrieval()
    {
        this.SetText(info:  "0%");
        DataStructs.UserDataDictionary.DownloadData(onAllDone:  new System.Action(object:  this, method:  System.Void DataFetchCtrl::OnAllDataDownloaded()), onProcess:  new System.Action<System.Single, System.Exception>(object:  this, method:  System.Void DataFetchCtrl::OnDataDownloadStep(float process, System.Exception exc)), onFailed:  new System.Action<System.String>(object:  this, method:  System.Void DataFetchCtrl::onDataDownloadFailed(string msg)));
        this.Enter(onDone:  0);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.DataFetchTimeoutMonitor(timeOutTime:  30));
        this.OnDataDownloadStep(process:  0.1f, exc:  0);
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.LoadNextAsync());
    }
    private void onDataDownloadFailed(string msg)
    {
        var val_3;
        UnityEngine.Events.UnityAction val_5;
        val_3 = null;
        val_3 = null;
        val_5 = DataFetchCtrl.<>c.<>9__9_0;
        if(val_5 == null)
        {
                UnityEngine.Events.UnityAction val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.Events.UnityAction(object:  DataFetchCtrl.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DataFetchCtrl.<>c::<onDataDownloadFailed>b__9_0());
            DataFetchCtrl.<>c.<>9__9_0 = val_5;
        }
        
        DialogPanel val_2 = DialogManager.Show(title:  "Error on loading. Returning to offline mode", message:  msg, cancelButtonTitle:  "OK", onCancelCallback:  val_1);
    }
    private void OnDataDownloadStep(float process, System.Exception exc)
    {
        object val_6;
        object val_7;
        val_6 = this;
        val_7 = "FetchUserData step " + process.ToString();
        UnityEngine.Debug.Log(message:  val_7);
        if(exc != null)
        {
                UnityEngine.Debug.LogException(exception:  exc);
            UnityEngine.Events.UnityAction val_3 = null;
            val_7 = val_3;
            val_3 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void DataFetchCtrl::MoveToBack());
            DialogPanel val_4 = DialogManager.Show(title:  "Error", message:  exc, cancelButtonTitle:  "Back", onCancelCallback:  val_3);
            return;
        }
        
        float val_6 = 100f;
        val_6 = process * val_6;
        val_6 = val_6 * 0.7f;
        val_6 = UnityEngine.Mathf.CeilToInt(f:  val_6);
        this.loadingBar.percent = (float)val_6;
    }
    private void OnAllDataDownloaded()
    {
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        DataStructs.Settings val_56;
        var val_57;
        NFUser val_1 = NFUser.current;
        if((System.String.IsNullOrEmpty(value:  val_1.loginUserInfo.password)) != true)
        {
                NFUser val_4 = NFUser.current;
            val_44 = 1152921505062596608;
            val_45 = null;
            val_45 = null;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Inequality(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_4.loginUserInfo.password), b:  DataStructs.UserDataDictionary.Settings.Password)) != false)
        {
                val_46 = null;
            val_46 = null;
            NFUser val_9 = NFUser.current;
            DataStructs.UserDataDictionary.Settings.Password = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_9.loginUserInfo.password);
        }
        
        }
        
        NFUser val_12 = NFUser.current;
        if(val_12.loginUserInfo.isFacebookAccount != false)
        {
                NFUser val_14 = NFUser.current;
            if((System.String.IsNullOrEmpty(value:  val_14.loginUserInfo.account)) != true)
        {
                NFUser val_17 = NFUser.current;
            val_44 = 1152921505062596608;
            val_47 = null;
            val_47 = null;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Inequality(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_17.loginUserInfo.account), b:  DataStructs.UserDataDictionary.Settings.FacebookID)) != false)
        {
                val_48 = null;
            val_48 = null;
            NFUser val_22 = NFUser.current;
            DataStructs.UserDataDictionary.Settings.FacebookID = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_22.loginUserInfo.account);
        }
        
        }
        
        }
        
        NFUser val_25 = NFUser.current;
        if(val_25.loginUserInfo.isGGPAccount == false)
        {
            goto label_64;
        }
        
        val_49 = null;
        val_49 = null;
        if((System.String.IsNullOrEmpty(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName))) == false)
        {
            goto label_64;
        }
        
        SignUpInstructionController.SetupNewUserData();
        goto label_73;
        label_64:
        val_44 = 1152921505151520768;
        val_50 = null;
        val_50 = null;
        if((System.String.IsNullOrEmpty(value:  CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName))) != false)
        {
                NFUser val_33 = NFUser.current;
            string val_34 = val_33.loginUserInfo.account;
            val_51 = null;
            val_51 = null;
            DataStructs.UserDataDictionary.Settings.UserName = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  ((System.String.IsNullOrEmpty(value:  val_34)) != true) ? "Player" : (val_34));
            this.loadingBar.percent = 80f;
            val_52 = null;
            val_52 = null;
            DataStructs.UserDataDictionary.Settings.UserFlag = 5;
            this.loadingBar.percent = 90f;
        }
        
        label_73:
        this.loadingBar.percent = 90f;
        GameAudio.ResetMusicSettingsByUserData();
        GameAudio.ResetSoundSettingByUserData();
        val_53 = null;
        val_53 = null;
        if(DataStructs.UserDataDictionary.Settings.HasSetupLanguage() != true)
        {
                val_54 = null;
            val_54 = null;
            DataStructs.UserDataDictionary.Settings.Language = LanguageManager.currentLanguage;
        }
        
        val_55 = null;
        val_56 = LanguageManager.currentLanguage;
        val_55 = null;
        if(val_56 != DataStructs.UserDataDictionary.Settings.Language)
        {
                val_57 = null;
            val_57 = null;
            val_56 = DataStructs.UserDataDictionary.Settings;
            bool val_43 = LanguageManager.SetLanguage(language:  val_56.Language);
        }
        
        VIP.Init();
    }
    private void MoveToNext()
    {
        this.MoveToScene(sceneName:  "Menu_Title_Screen");
    }
    private void MoveToBack()
    {
        this.MoveToScene(sceneName:  "SignIn");
    }
    private void MoveToScene(string sceneName)
    {
        UnityEngine.Transform[] val_1 = new UnityEngine.Transform[2];
        UnityEngine.Transform val_2 = this.loadingBar.transform;
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(val_2 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_2 == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = val_2;
        val_1[1] = this.stateText.transform;
        bool val_4 = AnimToScene.ScaleOutThenLoad(sceneName:  sceneName, objectListToScaleOut:  val_1, ease:  26, duration:  0.5f, beforeSceneActive:  0);
    }
    private System.Collections.IEnumerator DataFetchTimeoutMonitor(int timeOutTime = 30)
    {
        DataFetchCtrl.<DataFetchTimeoutMonitor>d__15 val_1 = new DataFetchCtrl.<DataFetchTimeoutMonitor>d__15(<>1__state:  0);
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .timeOutTime = timeOutTime;
        return (System.Collections.IEnumerator)val_1;
    }
    private void Update()
    {
        this.SetText(info:  (int)this.loadingBar.animatedPercentage.ToString() + "%"("%"));
    }
    private System.Collections.IEnumerator LoadNextAsync()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DataFetchCtrl.<LoadNextAsync>d__17(<>1__state:  0);
    }
    private void SetText(string info)
    {
        this.stateText.text = info;
    }
    private void FakeLoad()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.FakeLoadProcess());
    }
    private System.Collections.IEnumerator FakeLoadProcess()
    {
        .<>4__this = this;
        return (System.Collections.IEnumerator)new DataFetchCtrl.<FakeLoadProcess>d__20(<>1__state:  0);
    }
    public DataFetchCtrl()
    {
    
    }
    private static DataFetchCtrl()
    {
    
    }
    private void <DataFetchTimeoutMonitor>b__15_0()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DataFetchTimeoutMonitor(timeOutTime:  15));
    }

}
