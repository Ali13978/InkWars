using UnityEngine;
public class QuickPlayCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button createAccountButton;
    private UnityEngine.UI.Button loginButton;
    private UnityEngine.UI.Button quickPlayButton;
    private UnityEngine.UI.Image BGImage;
    private UnityEngine.UI.Image logoImage;
    private TMPro.TextMeshProUGUI promoText;
    private TMPro.TextMeshProUGUI orText;
    private UnityEngine.CanvasGroup loginGroup;
    private UnityEngine.AudioClip bgm;
    private DG.Tweening.Sequence enterAnim;
    private DG.Tweening.Sequence promoAnim;
    private static bool playBGAnim;
    private System.Collections.Generic.List<QuickPlayPromoTextData> dataList;
    private QuickPlayPromoTextData currentDisplayPromoData;
    private DG.Tweening.Tweener textScaleTw;
    
    // Properties
    public UnityEngine.UI.Button buttonCreateAccount { get; }
    public UnityEngine.UI.Button buttonLogin { get; }
    
    // Methods
    public UnityEngine.UI.Button get_buttonCreateAccount()
    {
        return (UnityEngine.UI.Button)this.createAccountButton;
    }
    public UnityEngine.UI.Button get_buttonLogin()
    {
        return (UnityEngine.UI.Button)this.loginButton;
    }
    private void Awake()
    {
        this.createAccountButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void QuickPlayCanvas::<Awake>b__18_0()));
        this.loginButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void QuickPlayCanvas::<Awake>b__18_1()));
    }
    private void CheckGameVersionThenGoToServerSelection(bool isLoginMode)
    {
        .isLoginMode = isLoginMode;
        AzureRemoteConfig.FetchRemote(callback:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  new QuickPlayCanvas.<>c__DisplayClass19_0(), method:  System.Void QuickPlayCanvas.<>c__DisplayClass19_0::<CheckGameVersionThenGoToServerSelection>b__0(bool success, string info)));
    }
    private void OnEnable()
    {
        var val_4;
        UnityEngine.Object val_5;
        val_4 = null;
        val_4 = null;
        Character_GlobalInfo.isOfflineMode = false;
        GameAudio.SwitchMusic(clip:  this.bgm, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        QuickPlayAiSettings.RemoveQuickPlayBot();
        val_5 = this.quickPlayButton;
        if(0 != val_5)
        {
                UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void QuickPlayCanvas::OnQuickPlayClick());
            val_5 = val_3;
            this.quickPlayButton.onClick.AddListener(call:  val_3);
        }
        
        this.HideAllData();
        this.Enter(onDone:  val_3);
    }
    private void OnDisable()
    {
        if(0 != this.quickPlayButton)
        {
                this.quickPlayButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void QuickPlayCanvas::OnQuickPlayClick()));
        }
        
        if(this.enterAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.enterAnim, complete:  false);
            this.enterAnim = 0;
        }
        
        if(this.promoAnim == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.promoAnim, complete:  false);
        this.promoAnim = 0;
    }
    private void OnQuickPlayClick()
    {
        null = null;
        QuickPlayCanvas.playBGAnim = true;
        SetupQuickPlay();
        AsyncSceneLoader.LoadWithLoadingScreen(sceneName:  "MVC_GameScene", minimumDelayInSeconds:  0f, autoHideLoadingScreen:  true);
    }
    private void SetupQuickPlay()
    {
        var val_4;
        DataStructs.UserDataDictionary.ResetAndEnableSave();
        IWServerDB_Cache.EnableAddToCache(enable:  false);
        IWServerDB_Cache.EnableSaveRoutine(enable:  false);
        val_4 = null;
        val_4 = null;
        Character_GlobalInfo.gameMode = 8;
        float val_1 = UnityEngine.Random.value;
        Character_GlobalInfo.SetLeftPlayer(nameID:  (val_1 < 0) ? 20 : 7);
        Character_GlobalInfo.SetRightPlayer(nameID:  (val_1 < 0) ? 7 : 20);
        QuickPlayAiSettings.SetupQuickPlayBot();
    }
    public void Enter(System.Action onDone)
    {
        var val_35;
        var val_36;
        if(this.enterAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.enterAnim, complete:  false);
        }
        
        this.enterAnim = DG.Tweening.DOTween.Sequence();
        val_35 = null;
        val_35 = null;
        if(QuickPlayCanvas.playBGAnim != false)
        {
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.enterAnim, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.BGImage, endValue:  0f, duration:  0.5f)));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.enterAnim, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  this.logoImage, endValue:  0f, duration:  0.3f)));
            val_36 = null;
            val_36 = null;
            QuickPlayCanvas.playBGAnim = false;
        }
        
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.enterAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.createAccountButton.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.5f)), ease:  27));
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.enterAnim, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.orText.transform, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.5f)), ease:  27), delay:  0.2f));
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.enterAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.quickPlayButton.transform, endValue:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, duration:  0.5f)), ease:  27));
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.enterAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.loginGroup.transform, endValue:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, duration:  0.5f)), ease:  27));
        DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.enterAnim, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void QuickPlayCanvas::PlayPromoAnimation()));
    }
    private void PlayPromoAnimation()
    {
        if(0 != this.currentDisplayPromoData)
        {
                this.currentDisplayPromoData.gameObject.SetActive(value:  false);
        }
        
        System.Collections.Generic.List<T> val_4 = this.dataList.FindAll(match:  new System.Predicate<QuickPlayPromoTextData>(object:  this, method:  System.Boolean QuickPlayCanvas::<PlayPromoAnimation>b__25_0(QuickPlayPromoTextData x)));
        QuickPlayPromoTextData val_7 = val_4.Item[UnityEngine.Random.Range(min:  0, max:  val_4.Count)];
        this.currentDisplayPromoData = val_7;
        val_7.gameObject.SetActive(value:  true);
        this.PlayPromoAnim(data:  this.currentDisplayPromoData);
    }
    private void HideAllData()
    {
        var val_6;
        System.Collections.Generic.List<QuickPlayPromoTextData> val_8;
        val_6 = null;
        val_6 = null;
        if((QuickPlayCanvas.<>c.<>9__26_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        int val_1 = this.dataList.RemoveAll(match:  QuickPlayCanvas.<>c.<>9__26_0);
        val_8 = this.dataList;
        List.Enumerator<T> val_2 = val_8.GetEnumerator();
        label_9:
        if(((-1374477560) & 1) == 0)
        {
            goto label_6;
        }
        
        0.InitialType.gameObject.SetActive(value:  false);
        goto label_9;
        label_3:
        QuickPlayCanvas.<>c.<>9__26_0 = new System.Predicate<QuickPlayPromoTextData>(object:  QuickPlayCanvas.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean QuickPlayCanvas.<>c::<HideAllData>b__26_0(QuickPlayPromoTextData x));
        if(this.dataList != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<QuickPlayPromoTextData>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<QuickPlayPromoTextData>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
    }
    private void PlayPromoAnim(QuickPlayPromoTextData data)
    {
        var val_17;
        var val_105;
        DG.Tweening.Sequence val_106;
        DG.Tweening.TweenCallback val_107;
        var val_108;
        UnityEngine.RectTransform val_109;
        if(this.promoAnim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.promoAnim, complete:  false);
        }
        
        this.promoText.text = data.text;
        this.promoAnim = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        this.promoText.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2.5f);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.promoText.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.5f)), ease:  30));
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.From<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.promoText, endValue:  0f, duration:  0.3f)));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.promoAnim, interval:  0.1f);
        if(data.subObjects == null)
        {
            goto label_27;
        }
        
        List.Enumerator<T> val_15 = data.subObjects.GetEnumerator();
        label_17:
        if(((-1373889504) & 1) == 0)
        {
            goto label_12;
        }
        
        System.Type val_18 = val_17.InitialType;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
        val_18.transform.localScale = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_18, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  0.2f), ease:  27));
        goto label_17;
        label_12:
        val_17.Add(driver:  public System.Void List.Enumerator<UnityEngine.Transform>::Dispose(), rectTransform:  0, drivenProperties:  null);
        label_27:
        DG.Tweening.Sequence val_25 = this.AppendCreateAccountButtonBounce(seq:  this.promoAnim, duation:  0.2f, isJoin:  false, scale:  1.15f);
        DG.Tweening.Sequence val_26 = this.AppendCreateAccountButtonBounce(seq:  this.promoAnim, duation:  0.2f, isJoin:  false, scale:  1.15f);
        int val_27 = UnityEngine.Random.Range(min:  2, max:  3);
        val_106 = this.promoAnim;
        val_107 = 39776452;
        if(val_27 < 1)
        {
            goto label_28;
        }
        
        var val_105 = 0;
        val_108 = 0;
        label_71:
        val_107 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void QuickPlayCanvas::<PlayPromoAnim>b__27_2());
        DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_106, callback:  val_107);
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.promoAnim, interval:  2f);
        DG.Tweening.TweenCallback val_31 = 39776452;
        val_31 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void QuickPlayCanvas::<PlayPromoAnim>b__27_3());
        DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.promoAnim, callback:  val_31);
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  1.4f);
        DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.promoText.transform, endValue:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, duration:  0.5f), ease:  21));
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.promoText.transform, endValue:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, duration:  0.3f), ease:  20));
        if((data.subObjects == null) || (data.subObjects.Count == 0))
        {
            goto label_62;
        }
        
        List.Enumerator<T> val_45 = data.subObjects.GetEnumerator();
        label_45:
        if(((-1373889504) & 1) == 0)
        {
            goto label_37;
        }
        
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, d:  1.5f);
        DG.Tweening.Sequence val_51 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_17.InitialType, endValue:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, duration:  0.15f), ease:  21));
        if(0 == 0)
        {
            goto label_45;
        }
        
        UnityEngine.Vector3 val_53 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_56 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  0, endValue:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z}, duration:  0.15f), ease:  20));
        goto label_45;
        label_37:
        val_108 = val_108 + 1;
        mem2[0] = 693;
        val_17.Add(driver:  public System.Void List.Enumerator<UnityEngine.Transform>::Dispose(), rectTransform:  0, drivenProperties:  0);
        if(val_108 != 1)
        {
                var val_57 = ((-1373889568 + ((val_108 + 1)) << 2) == 693) ? 1 : 0;
            val_57 = ((val_108 >= 0) ? 1 : 0) & val_57;
            val_108 = val_108 - val_57;
        }
        
        if(0 != 0)
        {
                UnityEngine.Vector3 val_60 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_63 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  0, endValue:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z}, duration:  0.15f), delay:  0.15f));
        }
        
        label_62:
        UnityEngine.Vector3 val_65 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_66 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z}, d:  1.3f);
        DG.Tweening.Sequence val_70 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.createAccountButton.transform, endValue:  new UnityEngine.Vector3() {x = val_66.x, y = val_66.y, z = val_66.z}, duration:  0.225f), ease:  21), delay:  0.1f));
        UnityEngine.Vector3 val_72 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_75 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.createAccountButton.transform, endValue:  new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_72.z}, duration:  0.3f), ease:  20));
        UnityEngine.Vector3 val_77 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_78 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_77.x, y = val_77.y, z = val_77.z}, d:  1.1f);
        DG.Tweening.Sequence val_81 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.createAccountButton.transform, endValue:  new UnityEngine.Vector3() {x = val_78.x, y = val_78.y, z = val_78.z}, duration:  0.15f), ease:  21));
        UnityEngine.Vector3 val_83 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_86 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.createAccountButton.transform, endValue:  new UnityEngine.Vector3() {x = val_83.x, y = val_83.y, z = val_83.z}, duration:  0.18f), ease:  30));
        val_106 = this.promoAnim;
        val_105 = val_105 + 1;
        val_107 = 39776452;
        if(val_105 < val_27)
        {
            goto label_71;
        }
        
        goto label_72;
        label_28:
        val_108 = 0;
        label_72:
        val_107 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void QuickPlayCanvas::<PlayPromoAnim>b__27_0());
        DG.Tweening.Sequence val_88 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_106, callback:  val_107);
        UnityEngine.Vector3 val_90 = UnityEngine.Vector3.zero;
        val_109 = 0;
        DG.Tweening.Sequence val_93 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.promoText.transform, endValue:  new UnityEngine.Vector3() {x = val_90.x, y = val_90.y, z = val_90.z}, duration:  0.2f), ease:  26));
        DG.Tweening.Sequence val_94 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.promoAnim, interval:  0.1f);
        if(data.subObjects == null)
        {
            goto label_89;
        }
        
        List.Enumerator<T> val_95 = data.subObjects.GetEnumerator();
        val_107 = 1152921528493496752;
        float val_106 = 0f;
        goto label_78;
        label_81:
        UnityEngine.Vector3 val_97 = UnityEngine.Vector3.zero;
        val_109 = 0;
        DG.Tweening.Sequence val_101 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.promoAnim, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_17.InitialType, endValue:  new UnityEngine.Vector3() {x = val_97.x, y = val_97.y, z = val_97.z}, duration:  0.2f), ease:  26), delay:  val_106));
        val_106 = val_106 + 0.1f;
        label_78:
        if(((-1373889504) & 1) != 0)
        {
            goto label_81;
        }
        
        var val_102 = val_108 + 1;
        mem2[0] = 1165;
        val_17.Add(driver:  public System.Void List.Enumerator<UnityEngine.Transform>::Dispose(), rectTransform:  val_109, drivenProperties:  0);
        val_105 = 1152921504886558720;
        label_89:
        DG.Tweening.Sequence val_104 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.promoAnim, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void QuickPlayCanvas::<PlayPromoAnim>b__27_1()));
    }
    private DG.Tweening.Sequence AppendCreateAccountButtonBounce(DG.Tweening.Sequence seq, float duation = 0.2, bool isJoin = False, float scale = 1.15)
    {
        UnityEngine.Transform val_1 = this.createAccountButton.transform;
        if(isJoin != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  scale);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Join(s:  seq, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  duation), ease:  20));
        }
        else
        {
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  scale);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  seq, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  duation), ease:  21));
        }
        
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  seq, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.createAccountButton.transform, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  duation), ease:  20));
        return (DG.Tweening.Sequence)seq;
    }
    private void EnableTextScaleAnim(bool enable, float duration = 0.5, float scale = 1.2)
    {
        if(this.textScaleTw != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.textScaleTw, complete:  false);
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.promoText.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        if(enable == false)
        {
                return;
        }
        
        this.textScaleTw = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.promoText.transform, endValue:  scale, duration:  duration), loops:  0, loopType:  1);
    }
    public QuickPlayCanvas()
    {
        this.dataList = new System.Collections.Generic.List<QuickPlayPromoTextData>();
    }
    private static QuickPlayCanvas()
    {
        QuickPlayCanvas.playBGAnim = true;
    }
    private void <Awake>b__18_0()
    {
        this.CheckGameVersionThenGoToServerSelection(isLoginMode:  false);
    }
    private void <Awake>b__18_1()
    {
        this.CheckGameVersionThenGoToServerSelection(isLoginMode:  true);
    }
    private bool <PlayPromoAnimation>b__25_0(QuickPlayPromoTextData x)
    {
        if(x == this.currentDisplayPromoData)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  x, y:  0);
    }
    private void <PlayPromoAnim>b__27_2()
    {
        this.EnableTextScaleAnim(enable:  true, duration:  0.5f, scale:  1.15f);
    }
    private void <PlayPromoAnim>b__27_3()
    {
        this.EnableTextScaleAnim(enable:  false, duration:  0.5f, scale:  1.2f);
    }
    private void <PlayPromoAnim>b__27_0()
    {
        this.EnableTextScaleAnim(enable:  false, duration:  0.5f, scale:  1.2f);
    }
    private void <PlayPromoAnim>b__27_1()
    {
        this.PlayPromoAnimation();
    }

}
