using UnityEngine;
public class NetworkLobbySuponic : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button privateLobby;
    private UnityEngine.UI.Button publicLobby;
    private UnityEngine.UI.Button ggpPublicLobby;
    private UnityEngine.UI.Button ggpPrivateLobby;
    protected static NetworkLobbySuponic _inst;
    
    // Properties
    protected static NetworkLobbySuponic instance { get; }
    
    // Methods
    protected static NetworkLobbySuponic get_instance()
    {
        var val_5;
        NetworkLobbySuponic val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = NetworkLobbySuponic._inst;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            NetworkLobbySuponic._inst = UnityEngine.Object.Instantiate<NetworkLobbySuponic>(original:  UnityEngine.Resources.Load<NetworkLobbySuponic>(path:  "DynamicUI/NetworkLobbyWithGGP"));
            val_6 = NetworkLobbySuponic._inst.gameObject;
            val_6.SetActive(value:  false);
        }
        
        val_8 = null;
        val_8 = null;
        return (NetworkLobbySuponic)NetworkLobbySuponic._inst;
    }
    public static void Show(UnityEngine.Transform parent)
    {
        NetworkLobbySuponic.instance.GetComponent<UnityEngine.RectTransform>().SetParent(p:  parent);
        NetworkLobbySuponic.instance.gameObject.SetActive(value:  true);
    }
    public static void Hide()
    {
        DG.Tweening.Sequence val_2 = NetworkLobbySuponic.instance.Close();
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.privateLobby.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbySuponic::PrivateLobbyClicked()));
        this.publicLobby.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbySuponic::PublicLobbyClicked()));
        this.ggpPublicLobby.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbySuponic::GGPPublicLobbyClicked()));
        this.ggpPrivateLobby.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbySuponic::GGPPrivateLobbyClicked()));
    }
    private void Start()
    {
    
    }
    private void PrivateLobbyClicked()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        PlayerBuff.enable = true;
        ActiveCanvasController.GetCanvasByName(name:  "PrivateLobby").gameObject.SetActive(value:  true);
        val_4 = null;
        val_4 = null;
        Character_GlobalInfo.isCryptoMMOCMode = false;
        NetworkLobbySuponic.Hide();
    }
    private void PublicLobbyClicked()
    {
        var val_3;
        var val_4;
        ActiveCanvasController val_1 = ActiveCanvasController.Instance;
        val_1.isCryptoPublicLobby = false;
        val_3 = null;
        val_3 = null;
        Character_GlobalInfo.isCryptoMMOCMode = false;
        val_4 = null;
        val_4 = null;
        PlayerBuff.enable = true;
        ActiveCanvasController.Instance.ShowPublicLobby();
        NetworkLobbySuponic.Hide();
    }
    private void GGPPublicLobbyClicked()
    {
        var val_2;
        ActiveCanvasController val_1 = ActiveCanvasController.Instance;
        val_1.isCryptoPublicLobby = true;
        val_2 = null;
        val_2 = null;
        PlayerBuff.enable = false;
        NetworkLobbySuponic.SetupGGPPublicLobby();
    }
    private void GGPPrivateLobbyClicked()
    {
        var val_2;
        ActiveCanvasController val_1 = ActiveCanvasController.Instance;
        val_1.isCryptoPublicLobby = true;
        val_2 = null;
        val_2 = null;
        PlayerBuff.enable = false;
        NetworkLobbySuponic.SetupGGPPrivateLobby();
    }
    private void GGModePublicClicked(bool isPublic)
    {
        DialogManager.ShowLoading();
        MMOCUser.current.GetUserProfile(onGetUserProfileDone:  new UnityEngine.Events.UnityAction<MMOCUserProfile>(object:  this, method:  System.Void NetworkLobbySuponic::<GGModePublicClicked>b__15_0(MMOCClientUser.MMOCUserProfile profile)));
    }
    public static void SetupGGPPublicLobby()
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
        UnityEngine.Debug.Log(message:  "isCryptoMMOCMode true");
        ActiveCanvasController.Instance.ShowPublicLobby();
    }
    public static void SetupGGPPrivateLobby()
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
        PostMatchCanvas.IsPrivateWagerMatch = true;
        CryptoCurrency.ListenToUserCurrencyChangeEvent();
        UnityEngine.Debug.Log(message:  "isCryptoMMOCMode true");
        ActiveCanvasController.Instance.ShowPrivateLobby();
    }
    private void OnLoginMMOCDone()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void OnDisable()
    {
        this.privateLobby.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbySuponic::PrivateLobbyClicked()));
        this.publicLobby.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbySuponic::PublicLobbyClicked()));
        this.ggpPublicLobby.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbySuponic::GGPPublicLobbyClicked()));
        this.ggpPrivateLobby.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkLobbySuponic::GGPPrivateLobbyClicked()));
    }
    public void ClosePopup()
    {
        DG.Tweening.Sequence val_1 = this.Close();
    }
    public DG.Tweening.Sequence Close()
    {
        GameAudio.PlayButtonSound();
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void NetworkLobbySuponic::<Close>b__21_0()));
        return val_1;
    }
    public NetworkLobbySuponic()
    {
    
    }
    private static NetworkLobbySuponic()
    {
    
    }
    private void <GGModePublicClicked>b__15_0(MMOCClientUser.MMOCUserProfile profile)
    {
        DialogManager.HideLoading();
        if(profile != null)
        {
                this.OnLoginMMOCDone();
            return;
        }
        
        MMOCUser.current.GetAuthCode(onLoginDone:  new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  this, method:  System.Void NetworkLobbySuponic::<GGModePublicClicked>b__15_1(bool success, string info)));
    }
    private void <GGModePublicClicked>b__15_1(bool success, string info)
    {
        UnityEngine.Events.UnityAction<System.Boolean, System.String> val_9;
        object val_10;
        val_9 = success;
        NetworkLobbySuponic.<>c__DisplayClass15_0 val_1 = null;
        val_10 = val_1;
        val_1 = new NetworkLobbySuponic.<>c__DisplayClass15_0();
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
            val_3 = new UnityEngine.Events.UnityAction<System.Boolean, System.String>(object:  val_1, method:  System.Void NetworkLobbySuponic.<>c__DisplayClass15_0::<GGModePublicClicked>b__2(bool success2, string info2));
            MMOCUser.current.GetToken(onDone:  val_3);
        }
        else
        {
                if((System.String.IsNullOrEmpty(value:  info)) != true)
        {
                UnityEngine.Debug.LogError(message:  "Login MMOC Fail: "("Login MMOC Fail: ") + (NetworkLobbySuponic.<>c__DisplayClass15_0)[1152921529063626480].info((NetworkLobbySuponic.<>c__DisplayClass15_0)[1152921529063626480].info));
            val_10 = LanguageManager.GetText(key:  "LK.Error");
            DialogPanel val_8 = DialogManager.Show(title:  val_10, message:  LanguageManager.GetText(key:  "LK.LoginMMOCFailUnKnown"), cancelButtonTitle:  0, onCancelCallback:  0);
        }
        
        }
        
        DialogManager.HideLoading();
    }
    private void <Close>b__21_0()
    {
        UnityEngine.Time.timeScale = 1f;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
