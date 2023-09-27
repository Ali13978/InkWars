using UnityEngine;
public class PublicLobbySuponic : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button backButton;
    private UnityEngine.GameObject wallpaper;
    private MotionPanelsControler pnlController;
    protected static PublicLobbySuponic _inst;
    
    // Properties
    protected static PublicLobbySuponic instance { get; }
    
    // Methods
    protected static PublicLobbySuponic get_instance()
    {
        var val_5;
        PublicLobbySuponic val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = PublicLobbySuponic._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            PublicLobbySuponic._inst = UnityEngine.Object.Instantiate<PublicLobbySuponic>(original:  UnityEngine.Resources.Load<PublicLobbySuponic>(path:  "DynamicUI/PublicLobbySuponic"));
            val_6 = PublicLobbySuponic._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (PublicLobbySuponic)PublicLobbySuponic._inst;
    }
    public static void Show(UnityEngine.Transform parent)
    {
        PublicLobbySuponic.instance.GetComponent<UnityEngine.RectTransform>().SetParent(p:  parent);
        PublicLobbySuponic.instance.gameObject.SetActive(value:  true);
    }
    public static void Hide()
    {
        DG.Tweening.Sequence val_2 = PublicLobbySuponic.instance.Close();
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_13;
        var val_14;
        DG.Tweening.TweenCallback val_16;
        var val_17;
        DG.Tweening.TweenCallback val_19;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.pnlController.m_preCondition = new MotionPanelsControler.PreCondition(object:  this, method:  public System.Boolean PublicLobbySuponic::CheckForEnoughCurrency());
        UnityEngine.Events.UnityAction val_5 = null;
        val_13 = val_5;
        val_5 = new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PublicLobbySuponic::ClosePopup());
        this.backButton.onClick.AddListener(call:  val_5);
        DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_6, interval:  3f);
        val_14 = null;
        val_14 = null;
        val_16 = PublicLobbySuponic.<>c.<>9__8_0;
        if(val_16 == null)
        {
                DG.Tweening.TweenCallback val_8 = null;
            val_16 = val_8;
            val_8 = new DG.Tweening.TweenCallback(object:  PublicLobbySuponic.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PublicLobbySuponic.<>c::<OnEnable>b__8_0());
            PublicLobbySuponic.<>c.<>9__8_0 = val_16;
        }
        
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_6, callback:  val_8);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_6, interval:  3f);
        val_17 = null;
        val_17 = null;
        val_19 = PublicLobbySuponic.<>c.<>9__8_1;
        if(val_19 == null)
        {
                DG.Tweening.TweenCallback val_11 = null;
            val_19 = val_11;
            val_11 = new DG.Tweening.TweenCallback(object:  PublicLobbySuponic.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PublicLobbySuponic.<>c::<OnEnable>b__8_1());
            PublicLobbySuponic.<>c.<>9__8_1 = val_19;
        }
        
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_6, callback:  val_11);
    }
    private void OnDisable()
    {
        this.backButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PublicLobbySuponic::ClosePopup()));
        this.pnlController.m_preCondition = 0;
    }
    public void ClosePopup()
    {
        DG.Tweening.Sequence val_1 = this.Close();
    }
    public void ClickSkillType(int type)
    {
        MultiplayerConnector val_1 = MultiplayerConnector.Instance;
        val_1.m_multiplayerManager.ClickSkillType(type:  type);
    }
    public bool CheckForEnoughCurrency()
    {
        WagerData val_1 = PublicWagerData.GetSelectedWagerData();
        if(val_1 != null)
        {
                return val_1.HasUserGotEnoughCurrency();
        }
        
        return val_1.HasUserGotEnoughCurrency();
    }
    public void ClickFindMatch()
    {
        PublicLobbySuponic.<>c__DisplayClass13_0 val_1 = new PublicLobbySuponic.<>c__DisplayClass13_0();
        WagerData val_2 = PublicWagerData.GetSelectedWagerData();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .wagerdata = val_2;
        if(val_2 != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        bool val_3 = val_2.HasUserGotEnoughCurrency();
        UnityEngine.GameObject val_4 = this.wallpaper.gameObject;
        if(val_4 == null)
        {
            goto label_4;
        }
        
        if(val_3 == false)
        {
            goto label_5;
        }
        
        label_10:
        val_4.SetActive(value:  false);
        MultiplayerConnector val_5 = MultiplayerConnector.Instance;
        val_5.m_multiplayerManager.Click_FindMatch();
        return;
        label_1:
        mem[16] = val_2;
        if(mem[16] != 0)
        {
            goto label_8;
        }
        
        goto label_9;
        label_4:
        if(val_3 == true)
        {
            goto label_10;
        }
        
        label_5:
        val_4.SetActive(value:  true);
        string val_7 = CurrencyCollection.Get(cur:  val_2.m_currency).TitleCasePluralName;
        object[] val_9 = new object[2];
        val_9[0] = val_2.m_wager;
        val_9[1] = val_7;
        DialogPanel val_17 = DialogManager.ShowConfirmDialog(title:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Title"), message:  System.String.Format(format:  LanguageManager.GetTextFormat(key:  "LK.wager.error1", list:  val_9), args:  System.Array.Empty<System.Object>()), confirmButtonTitle:  LanguageManager.GetText(key:  "LK.wager.get")(LanguageManager.GetText(key:  "LK.wager.get")) + " " + val_7, cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void PublicLobbySuponic.<>c__DisplayClass13_0::<ClickFindMatch>b__0()), onCancelCallback:  0);
    }
    public DG.Tweening.Sequence Close()
    {
        null = null;
        Character_GlobalInfo.isCryptoMMOCMode = false;
        GameAudio.PlayButtonSound();
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PublicLobbySuponic::<Close>b__14_0()));
        return val_1;
    }
    private void OnApplicationPause(bool isPause)
    {
        if(isPause != false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Refresh mmoc profile");
        MMOCUser.current.GetUserProfile(onGetUserProfileDone:  0);
    }
    public PublicLobbySuponic()
    {
    
    }
    private static PublicLobbySuponic()
    {
    
    }
    private void <Close>b__14_0()
    {
        UnityEngine.Time.timeScale = 1f;
        ActiveCanvasController.Instance.ShowLobby();
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
