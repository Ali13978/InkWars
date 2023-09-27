using UnityEngine;
public class SignUpInstructionController : MonoBehaviour
{
    // Fields
    public static string userName;
    public static DataStructs.Flag userCountry;
    public static string ggpID;
    private SignUpInstructionController.SignUpInstructionStates <currentState>k__BackingField;
    private UnityEngine.CanvasGroup namePanel;
    private UnityEngine.CanvasGroup countryPanel;
    private UnityEngine.CanvasGroup selectionPanel;
    private UnityEngine.CanvasGroup emailSignUpPanel;
    private UnityEngine.CanvasGroup contentRoot;
    private UnityEngine.UI.Button nextButton;
    private DG.Tweening.Sequence stateSwitchAnim;
    
    // Properties
    public SignUpInstructionController.SignUpInstructionStates currentState { get; set; }
    
    // Methods
    public SignUpInstructionController.SignUpInstructionStates get_currentState()
    {
        return (SignUpInstructionStates)this.<currentState>k__BackingField;
    }
    private void set_currentState(SignUpInstructionController.SignUpInstructionStates value)
    {
        this.<currentState>k__BackingField = value;
    }
    public static void MoveToFetchData()
    {
        var val_16;
        UnityEngine.Events.UnityAction val_18;
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
        val_16 = null;
        val_16 = null;
        val_18 = SignUpInstructionController.<>c.<>9__15_0;
        if(val_18 == null)
        {
                UnityEngine.Events.UnityAction val_15 = null;
            val_18 = val_15;
            val_15 = new UnityEngine.Events.UnityAction(object:  SignUpInstructionController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SignUpInstructionController.<>c::<MoveToFetchData>b__15_0());
            SignUpInstructionController.<>c.<>9__15_0 = val_18;
        }
        
        NFServerTime.WaitUntilServerTimeActive(callback:  val_15);
    }
    private void OnEnable()
    {
        var val_14;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        goto label_23;
        label_30:
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_3.Current.Add(driver:  public System.Object System.Collections.IEnumerator::get_Current(), rectTransform:  null, drivenProperties:  null);
        if(1152921504628039679 > 3)
        {
            goto label_24;
        }
        
        var val_6 = mem[4611686018552987108] + 40828392;
        goto (mem[4611686018552987108] + 40828392);
        label_24:
        if(0 != mem[this.emailSignUpPanel])
        {
                mem[this.emailSignUpPanel].alpha = 0f;
            mem[this.emailSignUpPanel].gameObject.SetActive(value:  false);
        }
        
        label_23:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_3.MoveNext() == true)
        {
            goto label_30;
        }
        
        val_14 = 0;
        if(val_3 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_3.Dispose();
        }
        
        this.SwitchToState(nextState:  0, showAnim:  false);
        this.PlayFadeAnim(startFade:  0f, endFade:  1f, onDone:  0);
        this.SwitchToState(nextState:  1, showAnim:  true);
    }
    private void OnDisable()
    {
        this.PlayFadeAnim(startFade:  1f, endFade:  0f, onDone:  new System.Action(object:  this, method:  System.Void SignUpInstructionController::<OnDisable>b__17_0()));
    }
    public void OnNext()
    {
        this.SwitchToState(nextState:  (this.<currentState>k__BackingField) + 1, showAnim:  true);
    }
    public void OnBack()
    {
        var val_6;
        SignUpInstructionStates val_1 = (this.<currentState>k__BackingField) - 1;
        if(val_1 >= 1)
        {
                this.SwitchToState(nextState:  val_1, showAnim:  true);
            return;
        }
        
        val_6 = null;
        val_6 = null;
        UnityEngine.Transform[] val_3 = new UnityEngine.Transform[1];
        val_3[0] = this.contentRoot.transform;
        bool val_5 = AnimToScene.ScaleOutThenLoad(sceneName:  (Character_GlobalInfo.isOfflineMode == true) ? "OfflineTitleScreen" : "QuickPlay", objectListToScaleOut:  val_3, ease:  26, duration:  0.5f, beforeSceneActive:  0);
    }
    public void OnEmailClick()
    {
        this.SwitchToState(nextState:  (this.<currentState>k__BackingField) + 1, showAnim:  true);
    }
    public static void SetupNewUserData()
    {
        var val_14;
        var val_15;
        val_14 = null;
        val_14 = null;
        val_15 = null;
        val_15 = null;
        DataStructs.UserDataDictionary.Settings.UserName = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  SignUpInstructionController.userName);
        DataStructs.UserDataDictionary.Settings.UserFlag = SignUpInstructionController.userCountry;
        NFUser val_2 = NFUser.current;
        DataStructs.UserDataDictionary.Settings.FacebookID = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_2.loginUserInfo.account);
        NFUser val_5 = NFUser.current;
        DataStructs.UserDataDictionary.Settings.GGPID = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_5.loginUserInfo.account);
        System.DateTime val_8 = System.DateTime.UtcNow;
        DataStructs.UserDataDictionary.GameSave.SignUpDate = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_8.dateData);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        DataStructs.UserDataDictionary.Settings.MusicEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_10.currentCryptoKey, hiddenValue = val_10.hiddenValue, fakeValue = val_10.fakeValue & 4294967295, fakeValueChanged = val_10.fakeValue & 4294967295, inited = val_10.fakeValue & 4294967295};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        DataStructs.UserDataDictionary.Settings.SoundEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_12.currentCryptoKey, hiddenValue = val_12.hiddenValue, fakeValue = val_12.fakeValue & 4294967295, fakeValueChanged = val_12.fakeValue & 4294967295, inited = val_12.fakeValue & 4294967295};
    }
    public void GGModeLogin()
    {
        DialogManager.ShowLoading();
        MMOCUser.current.GetUserProfile(onGetUserProfileDone:  new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  this, method:  System.Void SignUpInstructionController::<GGModeLogin>b__22_0(MMOCClientUser.MMOCUserProfile profile)));
    }
    private void OnNFRegisterSuccess()
    {
        var val_17;
        var val_18;
        DialogManager.HideLoading();
        val_17 = null;
        val_17 = null;
        val_18 = null;
        val_18 = null;
        DataStructs.UserDataDictionary.Settings.UserName = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  SignUpInstructionController.userName);
        NFUser val_2 = NFUser.current;
        DataStructs.UserDataDictionary.Settings.Email = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_2.loginUserInfo.account);
        NFUser val_5 = NFUser.current;
        DataStructs.UserDataDictionary.Settings.GGPID = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_5.loginUserInfo.account);
        DataStructs.UserDataDictionary.Settings.UserFlag = SignUpInstructionController.userCountry;
        System.DateTime val_8 = System.DateTime.UtcNow;
        DataStructs.UserDataDictionary.GameSave.SignUpDate = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_8.dateData);
        NFUser val_10 = NFUser.current;
        DataStructs.UserDataDictionary.Settings.Password = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_10.loginUserInfo.password);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        DataStructs.UserDataDictionary.Settings.MusicEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_13.currentCryptoKey, hiddenValue = val_13.hiddenValue, fakeValue = val_13.fakeValue & 4294967295, fakeValueChanged = val_13.fakeValue & 4294967295, inited = val_13.fakeValue & 4294967295};
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_15 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
        DataStructs.UserDataDictionary.Settings.SoundEnabled = new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_15.currentCryptoKey, hiddenValue = val_15.hiddenValue, fakeValue = val_15.fakeValue & 4294967295, fakeValueChanged = val_15.fakeValue & 4294967295, inited = val_15.fakeValue & 4294967295};
        SignUpInstructionController.MoveToFetchData();
    }
    private void CreateGGPUser()
    {
        var val_16;
        DialogManager.ShowLoading();
        DataStructs.UserDataDictionary.ResetAndEnableSave();
        val_16 = null;
        val_16 = null;
        DataStructs.UserDataDictionary.Settings.UserName = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  SignUpInstructionController.userName);
        NFUser val_2 = NFUser.current;
        DataStructs.UserDataDictionary.Settings.Email = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_2.loginUserInfo.account);
        NFUser val_5 = NFUser.current;
        DataStructs.UserDataDictionary.Settings.GGPID = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_5.loginUserInfo.account);
        DataStructs.UserDataDictionary.Settings.UserFlag = SignUpInstructionController.userCountry;
        System.DateTime val_8 = System.DateTime.UtcNow;
        DataStructs.UserDataDictionary.GameSave.SignUpDate = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_8.dateData);
        NFUser val_11 = NFUser.current;
        NFUser val_13 = NFUser.current;
        NFUser.current.CreateAccount(userNameTxt:  val_11.loginUserInfo.account, passwordTxt:  val_13.loginUserInfo.password, OnRegisterDone:  new System.Action(object:  this, method:  System.Void SignUpInstructionController::OnNFRegisterSuccess()));
    }
    private void SwitchToState(SignUpInstructionController.SignUpInstructionStates nextState, bool showAnim = False)
    {
        SignUpInstructionStates val_23;
        DG.Tweening.Sequence val_24;
        SignUpInstructionStates val_25;
        System.Object[] val_26;
        UnityEngine.CanvasGroup val_28;
        var val_29;
        val_23 = nextState;
        val_24 = this;
        SignUpInstructionController.<>c__DisplayClass25_0 val_1 = new SignUpInstructionController.<>c__DisplayClass25_0();
        val_25 = this.<currentState>k__BackingField;
        if(val_25 == val_23)
        {
                return;
        }
        
        this.<currentState>k__BackingField = val_23;
        this.nextButton.gameObject.SetActive(value:  (((this.<currentState>k__BackingField) - 3) > 1) ? 1 : 0);
        object[] val_5 = new object[2];
        val_26 = val_5;
        val_26[0] = val_25;
        val_26[1] = this.<currentState>k__BackingField;
        UnityEngine.Debug.LogFormat(format:  "{0} - {1}", args:  val_5);
        if(showAnim == false)
        {
                return;
        }
        
        if(this.stateSwitchAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.stateSwitchAnim, complete:  false);
        }
        
        this.stateSwitchAnim = DG.Tweening.DOTween.Sequence();
        if((val_25 - 1) <= 3)
        {
                var val_23 = 40828424 + ((this.<currentState>k__BackingField - 1)) << 2;
            val_23 = val_23 + 40828424;
        }
        else
        {
                val_28 = 0;
            if(val_1 == null)
        {
                val_29 = 16;
            mem[16] = val_28;
            val_28 = mem[16];
        }
        else
        {
                val_29 = val_1;
            .prevPanel = ;
        }
        
            val_25 = 1152921504858337280;
            if(0 != )
        {
                UnityEngine.Debug.Log(message:  .prevPanel.gameObject.name);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.stateSwitchAnim, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  .prevPanel, endValue:  0f, duration:  0.5f));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.stateSwitchAnim, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void SignUpInstructionController.<>c__DisplayClass25_0::<SwitchToState>b__0()));
        }
        
            if((val_23 - 1) <= 3)
        {
                var val_24 = 40828440 + ((nextState - 1)) << 2;
            val_24 = val_24 + 40828440;
        }
        else
        {
                val_23 = 0;
            if(val_1 == null)
        {
                val_26 = 24;
            mem[24] = val_23;
            val_23 = mem[24];
        }
        else
        {
                val_26 = val_1;
            .nextPanel = ;
        }
        
            if(0 == )
        {
                return;
        }
        
            UnityEngine.Debug.Log(message:  .nextPanel.gameObject.name);
            val_23 = this.stateSwitchAnim;
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_23, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void SignUpInstructionController.<>c__DisplayClass25_0::<SwitchToState>b__1()));
            val_24 = this.stateSwitchAnim;
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_24, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  .nextPanel, endValue:  1f, duration:  0.5f));
        }
        
        }
    
    }
    private void PlayFadeAnim(float startFade, float endFade, System.Action onDone)
    {
        .onDone = onDone;
        this.contentRoot.alpha = startFade;
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.contentRoot, endValue:  endFade, duration:  0.5f), action:  new DG.Tweening.TweenCallback(object:  new SignUpInstructionController.<>c__DisplayClass26_0(), method:  System.Void SignUpInstructionController.<>c__DisplayClass26_0::<PlayFadeAnim>b__0()));
    }
    private UnityEngine.CanvasGroup GetStatePanel(SignUpInstructionController.SignUpInstructionStates aState)
    {
        if((aState - 1) > 3)
        {
                return 0;
        }
        
        var val_2 = 40828408 + ((aState - 1)) << 2;
        val_2 = val_2 + 40828408;
        goto (40828408 + ((aState - 1)) << 2 + 40828408);
    }
    private SignUpInstructionController.SignUpInstructionStates GetNextState()
    {
        return (SignUpInstructionStates)(this.<currentState>k__BackingField) + 1;
    }
    private SignUpInstructionController.SignUpInstructionStates GetPrevState()
    {
        SignUpInstructionStates val_2 = this.<currentState>k__BackingField;
        val_2 = val_2 - 1;
        return (SignUpInstructionStates)val_2 & (~(val_2 >> 31));
    }
    public SignUpInstructionController()
    {
    
    }
    private static SignUpInstructionController()
    {
        SignUpInstructionController.userCountry = 125;
    }
    private void <OnDisable>b__17_0()
    {
        this.SwitchToState(nextState:  0, showAnim:  false);
        this.gameObject.SetActive(value:  false);
    }
    private void <GGModeLogin>b__22_0(MMOCClientUser.MMOCUserProfile profile)
    {
        DialogManager.HideLoading();
        if(profile != null)
        {
                this.CreateGGPUser();
            return;
        }
        
        MMOCUser.current.GetAuthCode(onLoginDone:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  this, method:  System.Void SignUpInstructionController::<GGModeLogin>b__22_1(bool success, string info)));
    }
    private void <GGModeLogin>b__22_1(bool success, string info)
    {
        UnityEngine.Events.UnityAction<System.Boolean, System.String> val_9;
        object val_10;
        val_9 = success;
        SignUpInstructionController.<>c__DisplayClass22_0 val_1 = null;
        val_10 = val_1;
        val_1 = new SignUpInstructionController.<>c__DisplayClass22_0();
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
            val_3 = new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  val_1, method:  System.Void SignUpInstructionController.<>c__DisplayClass22_0::<GGModeLogin>b__2(bool success2, string info2));
            MMOCUser.current.GetToken(onDone:  val_3);
        }
        else
        {
                if((System.String.IsNullOrEmpty(value:  info)) != true)
        {
                UnityEngine.Debug.LogError(message:  "Login MMOC Fail: "("Login MMOC Fail: ") + (SignUpInstructionController.<>c__DisplayClass22_0)[1152921528258078832].info((SignUpInstructionController.<>c__DisplayClass22_0)[1152921528258078832].info));
            val_10 = LanguageManager.GetText(key:  "LK.Error");
            DialogPanel val_8 = DialogManager.Show(title:  val_10, message:  LanguageManager.GetText(key:  "LK.LoginMMOCFailUnKnown"), cancelButtonTitle:  0, onCancelCallback:  0);
        }
        
        }
        
        DialogManager.HideLoading();
    }

}
