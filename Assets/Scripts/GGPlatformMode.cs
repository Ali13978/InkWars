using UnityEngine;
public class GGPlatformMode : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button backButton;
    private UnityEngine.UI.Button GGModeButton;
    protected static GGPlatformMode _inst;
    
    // Properties
    protected static GGPlatformMode instance { get; }
    
    // Methods
    protected static GGPlatformMode get_instance()
    {
        var val_5;
        GGPlatformMode val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = GGPlatformMode._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            GGPlatformMode._inst = UnityEngine.Object.Instantiate<GGPlatformMode>(original:  UnityEngine.Resources.Load<GGPlatformMode>(path:  "DynamicUI/GGPlatformMode"));
            val_6 = GGPlatformMode._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (GGPlatformMode)GGPlatformMode._inst;
    }
    public static void Show()
    {
        GGPlatformMode.instance.gameObject.SetActive(value:  true);
    }
    private void OnEnable()
    {
        var val_7;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.backButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GGPlatformMode::ClosePopup()));
        this.GGModeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GGPlatformMode::GGModeClicked()));
        val_7 = null;
        val_7 = null;
        if(Character_GlobalInfo.isCryptoMMOCMode == false)
        {
                return;
        }
        
        this.GGModeClicked();
    }
    private void GGModeClicked()
    {
        DialogManager.ShowLoading();
        MMOCUser.current.GetUserProfile(onGetUserProfileDone:  new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  this, method:  System.Void GGPlatformMode::<GGModeClicked>b__7_0(MMOCClientUser.MMOCUserProfile profile)));
    }
    public static void SetupTOMMOCLobby()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        Character_GlobalInfo.gameMode = 6;
        Character_GlobalInfo.isCryptoMMOCMode = true;
        val_3 = null;
        val_3 = null;
        PostMatchCanvas.IsPublicMatch = true;
        PostMatchCanvas.IsPrivateWagerMatch = false;
        CryptoCurrency.ListenToUserCurrencyChangeEvent();
        ActiveCanvasController.Instance.ShowPublicLobby();
    }
    private void OnLoginMMOCDone()
    {
        GGPlatformMode.SetupTOMMOCLobby();
        GameAudio.PlayButtonSound();
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void OnDisable()
    {
        this.backButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GGPlatformMode::ClosePopup()));
        this.GGModeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GGPlatformMode::GGModeClicked()));
    }
    public void ClosePopup()
    {
        DG.Tweening.Sequence val_1 = this.Close();
    }
    public DG.Tweening.Sequence Close()
    {
        null = null;
        Character_GlobalInfo.isCryptoMMOCMode = false;
        GameAudio.PlayButtonSound();
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void GGPlatformMode::<Close>b__12_0()));
        return val_1;
    }
    public GGPlatformMode()
    {
    
    }
    private static GGPlatformMode()
    {
    
    }
    private void <GGModeClicked>b__7_0(MMOCClientUser.MMOCUserProfile profile)
    {
        DialogManager.HideLoading();
        if(profile != null)
        {
                this.OnLoginMMOCDone();
            return;
        }
        
        MMOCUser.current.GetAuthCode(onLoginDone:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  this, method:  System.Void GGPlatformMode::<GGModeClicked>b__7_1(bool success, string info)));
    }
    private void <GGModeClicked>b__7_1(bool success, string info)
    {
        UnityEngine.Events.UnityAction<System.Boolean, System.String> val_9;
        object val_10;
        val_9 = success;
        GGPlatformMode.<>c__DisplayClass7_0 val_1 = null;
        val_10 = val_1;
        val_1 = new GGPlatformMode.<>c__DisplayClass7_0();
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
            val_3 = new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  val_1, method:  System.Void GGPlatformMode.<>c__DisplayClass7_0::<GGModeClicked>b__2(bool success2, string info2));
            MMOCUser.current.GetToken(onDone:  val_3);
        }
        else
        {
                if((System.String.IsNullOrEmpty(value:  info)) != true)
        {
                UnityEngine.Debug.LogError(message:  "Login MMOC Fail: "("Login MMOC Fail: ") + (GGPlatformMode.<>c__DisplayClass7_0)[1152921529057807744].info((GGPlatformMode.<>c__DisplayClass7_0)[1152921529057807744].info));
            val_10 = LanguageManager.GetText(key:  "LK.Error");
            DialogPanel val_8 = DialogManager.Show(title:  val_10, message:  LanguageManager.GetText(key:  "LK.LoginMMOCFailUnKnown"), cancelButtonTitle:  0, onCancelCallback:  0);
        }
        
        }
        
        DialogManager.HideLoading();
    }
    private void <Close>b__12_0()
    {
        UnityEngine.Time.timeScale = 1f;
        ActiveCanvasController.Instance.ShowLobby();
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
