using UnityEngine;
public class PrivateLobbyGGP : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button backButton;
    private UnityEngine.GameObject wallpaper;
    protected static PrivateLobbyGGP _inst;
    
    // Properties
    protected static PrivateLobbyGGP instance { get; }
    
    // Methods
    protected static PrivateLobbyGGP get_instance()
    {
        var val_5;
        PrivateLobbyGGP val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = PrivateLobbyGGP._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            PrivateLobbyGGP._inst = UnityEngine.Object.Instantiate<PrivateLobbyGGP>(original:  UnityEngine.Resources.Load<PrivateLobbyGGP>(path:  "DynamicUI/NetworkLobbyPrivateGGP"));
            val_6 = PrivateLobbyGGP._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (PrivateLobbyGGP)PrivateLobbyGGP._inst;
    }
    public static void Show(UnityEngine.Transform parent)
    {
        PrivateLobbyGGP.instance.GetComponent<UnityEngine.RectTransform>().SetParent(p:  parent);
        PrivateLobbyGGP.instance.gameObject.SetActive(value:  true);
    }
    public static void Hide()
    {
        DG.Tweening.Sequence val_2 = PrivateLobbyGGP.instance.Close();
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.backButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PrivateLobbyGGP::ClosePopup()));
    }
    private void OnDisable()
    {
        this.backButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void PrivateLobbyGGP::ClosePopup()));
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
        PrivateLobbyGGP.<>c__DisplayClass12_0 val_1 = new PrivateLobbyGGP.<>c__DisplayClass12_0();
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
        DialogPanel val_17 = DialogManager.ShowConfirmDialog(title:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Title"), message:  System.String.Format(format:  LanguageManager.GetTextFormat(key:  "LK.wager.error1", list:  val_9), args:  System.Array.Empty<System.Object>()), confirmButtonTitle:  LanguageManager.GetText(key:  "LK.wager.get")(LanguageManager.GetText(key:  "LK.wager.get")) + " " + val_7, cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Ads.Error.Close"), onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void PrivateLobbyGGP.<>c__DisplayClass12_0::<ClickFindMatch>b__0()), onCancelCallback:  0);
    }
    public DG.Tweening.Sequence Close()
    {
        GameAudio.PlayButtonSound();
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PrivateLobbyGGP::<Close>b__13_0()));
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
    public PrivateLobbyGGP()
    {
    
    }
    private static PrivateLobbyGGP()
    {
    
    }
    private void <Close>b__13_0()
    {
        UnityEngine.Time.timeScale = 1f;
        ActiveCanvasController.Instance.ShowLobby();
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
