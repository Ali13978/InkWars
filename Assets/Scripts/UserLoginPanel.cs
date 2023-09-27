using UnityEngine;
public class UserLoginPanel : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button loginButton;
    private UnityEngine.UI.Button createAccountButton;
    private UnityEngine.UI.Button exitButton;
    public string username;
    
    // Properties
    public bool enableExitButton { get; set; }
    
    // Methods
    public bool get_enableExitButton()
    {
        UnityEngine.GameObject val_1 = this.exitButton.gameObject;
        if(val_1 != null)
        {
                return val_1.activeInHierarchy;
        }
        
        return val_1.activeInHierarchy;
    }
    public void set_enableExitButton(bool value)
    {
        this.exitButton.gameObject.SetActive(value:  value);
    }
    public void onValueChange(int val)
    {
        this.username = (val == 0) ? "tournamenttester2@yopmail.com" : ((val == 1) ? "tournamenttester1@yopmail.com" : "invalid username");
    }
    private void Awake()
    {
        this.loginButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UserLoginPanel::GGModeClicked()));
    }
    private void OnEnable()
    {
        var val_4;
        this.username = "tournamenttester1@yopmail.com";
        this.Show();
        if(0 == (this.exitButton.GetComponent<ButtonToScene>()))
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_1.nextScene = (Character_GlobalInfo.isOfflineMode == true) ? "OfflineTitleScreen" : "QuickPlay";
    }
    public void Show()
    {
        this.SetPanelEnable(enable:  false);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.3f), ease:  27), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void UserLoginPanel::<Show>b__10_0()));
    }
    private void Close(System.Action onDone)
    {
        UserLoginPanel.<>c__DisplayClass11_0 val_1 = new UserLoginPanel.<>c__DisplayClass11_0();
        if(val_1 != null)
        {
                .onDone = onDone;
        }
        else
        {
                mem[16] = onDone;
        }
        
        .<>4__this = this;
        GameAudio.PlayButtonSound();
        this.SetPanelEnable(enable:  false);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.3f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void UserLoginPanel.<>c__DisplayClass11_0::<Close>b__0()));
    }
    private void GGModeClicked()
    {
        DialogManager.ShowLoading();
        MMOCUser.current.GetUserProfile(onGetUserProfileDone:  new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  this, method:  System.Void UserLoginPanel::<GGModeClicked>b__12_0(MMOCClientUser.MMOCUserProfile profile)));
    }
    private void OnLoginMMOCDone()
    {
        this.LoginNFServer(createAccountIfUserNotExist:  false);
        GameAudio.PlayButtonSound();
    }
    private void LoginNFServer(bool createAccountIfUserNotExist)
    {
        NFUser val_2 = NFUser.current;
        NFUser val_4 = NFUser.current;
        NFUser.current.LoginNFServer(userNameTxt:  val_2.loginUserInfo.account, passwordTxt:  val_4.loginUserInfo.password, createAccountIfUserNotExist:  createAccountIfUserNotExist, OnLoginStepDone:  new System.Action(object:  this, method:  System.Void UserLoginPanel::OnLoginStepDone()), OnNFLoginSuccess:  new System.Action(object:  this, method:  System.Void UserLoginPanel::OnNFLoginSuccess()), OnNFLoginFail:  new System.Action<LoginDataResponse>(object:  0, method:  public static System.Void UserLoginPanel::OnLoginFail(NFClientUser.LoginDataResponse resp)));
    }
    public static void OnLoginFail(NFClientUser.LoginDataResponse resp)
    {
        if(resp != null)
        {
                if(true != 404)
        {
                return;
        }
        
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "OfflineTitleScreen");
    }
    private void OnLoginStepDone()
    {
    
    }
    private void OnFirebaseLoginSuccess()
    {
        this.LoginNFServer(createAccountIfUserNotExist:  false);
    }
    private void OnNFLoginSuccess()
    {
        DialogManager.ShowLoading();
        NFUser val_1 = NFUser.current;
        NFUser val_3 = NFUser.current;
        NFUser val_5 = NFUser.current;
        NFUser val_7 = NFUser.current;
        NFUser val_9 = NFUser.current;
        NFUser val_11 = NFUser.current;
        GameServerInfo val_14 = NFUser.current.Server;
        NFUser.SaveToDevice(userName:  val_1.loginUserInfo.account, aNewPassword:  val_3.loginUserInfo.password, jwt:  val_5.loginUserInfo.userJWT, ggpJwt:  val_7.loginUserInfo.ggpJWT, ggpJwtType:  val_9.loginUserInfo.ggpJwtType, refreshCode:  val_11.loginUserInfo.refreshCode, aNewServerId:  val_14.id);
        NFUser.UpdateServerTime();
        NFServerTime.WaitUntilServerTimeActive(callback:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UserLoginPanel::<OnNFLoginSuccess>b__18_0()));
    }
    private void ShakeInputFiled(UnityEngine.UI.InputField input)
    {
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOShakeAnchorPos(target:  input.GetComponent<UnityEngine.RectTransform>(), duration:  1f, strength:  10f, vibrato:  10, randomness:  90f, snapping:  false, fadeOut:  true);
    }
    private void SetPanelEnable(bool enable)
    {
        bool val_1 = enable;
        this.loginButton.interactable = val_1;
        this.createAccountButton.interactable = val_1;
    }
    public UserLoginPanel()
    {
    
    }
    private void <Show>b__10_0()
    {
        this.SetPanelEnable(enable:  true);
    }
    private void <GGModeClicked>b__12_0(MMOCClientUser.MMOCUserProfile profile)
    {
        DialogManager.HideLoading();
        if(profile != null)
        {
                this.OnLoginMMOCDone();
            return;
        }
        
        UnityEngine.Debug.Log(message:  "Getting MMOC User Profile.. ");
        MMOCUser.current.GetAuthCode(onLoginDone:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  this, method:  System.Void UserLoginPanel::<GGModeClicked>b__12_1(bool success, string info)));
    }
    private void <GGModeClicked>b__12_1(bool success, string info)
    {
        UnityEngine.Events.UnityAction<System.Boolean, System.String> val_9;
        object val_10;
        val_9 = success;
        UserLoginPanel.<>c__DisplayClass12_0 val_1 = null;
        val_10 = val_1;
        val_1 = new UserLoginPanel.<>c__DisplayClass12_0();
        if(val_10 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .info = info;
        if(val_9 != false)
        {
                DialogManager.ShowLoading();
            UnityEngine.Events.UnityAction<System.Boolean, System.String> val_3 = null;
            val_9 = val_3;
            val_3 = new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  val_1, method:  System.Void UserLoginPanel.<>c__DisplayClass12_0::<GGModeClicked>b__2(bool success2, string info2));
            MMOCUser.current.GetToken(onDone:  val_3);
        }
        else
        {
                if((System.String.IsNullOrEmpty(value:  info)) != true)
        {
                UnityEngine.Debug.LogError(message:  "Login MMOC Fail: "("Login MMOC Fail: ") + (UserLoginPanel.<>c__DisplayClass12_0)[1152921528266667520].info((UserLoginPanel.<>c__DisplayClass12_0)[1152921528266667520].info));
            val_10 = LanguageManager.GetText(key:  "LK.Error");
            DialogPanel val_8 = DialogManager.Show(title:  val_10, message:  LanguageManager.GetText(key:  "LK.LoginMMOCFailUnKnown"), cancelButtonTitle:  0, onCancelCallback:  0);
        }
        
        }
        
        DialogManager.HideLoading();
    }
    private void <OnNFLoginSuccess>b__18_0()
    {
        DialogManager.HideLoading();
        UnityEngine.Transform[] val_1 = new UnityEngine.Transform[1];
        UnityEngine.Transform val_2 = this.transform;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        bool val_3 = AnimToScene.ScaleOutThenLoad(sceneName:  "FetchData", objectListToScaleOut:  val_1, ease:  26, duration:  0.5f, beforeSceneActive:  0);
    }

}
