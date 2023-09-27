using UnityEngine;
public class ServerSelectionPanel : DynamicUISingleton<ServerSelectionPanel>
{
    // Fields
    private UnityEngine.UI.ToggleGroup toggleGroup;
    private UnityEngine.CanvasGroup fadeCanvasGroup;
    private ServerSelectionItemUI itemTemplate;
    private UnityEngine.UI.Button confirmButton;
    private UnityEngine.GameObject loadingObj;
    private UnityEngine.GameObject loginText;
    private GameServerInfo selection;
    private bool isLoginMode;
    
    // Methods
    private void Awake()
    {
        this.confirmButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ServerSelectionPanel::<Awake>b__8_0()));
    }
    public static void Show(bool isLoginMode)
    {
        DynamicUISingleton<ServerSelectionPanel>.instance.GetComponent<ServerSelectionPanel>().EnableLoginHelperText(enabled:  isLoginMode);
        UnityEngine.RectTransform val_5 = DynamicUISingleton<ServerSelectionPanel>.instance.GetComponent<UnityEngine.RectTransform>();
        if((DialogManager.HasDialog(dialogRectTransform:  val_5)) != false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        DialogManager.ShowCustomDialog(dialog:  val_5, scale:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
    }
    public void EnableLoginHelperText(bool enabled)
    {
        bool val_1 = enabled;
        this.isLoginMode = val_1;
        this.loginText.SetActive(value:  val_1);
    }
    public void OnSelectServer(GameServerInfo server)
    {
        this.selection = server;
        UnityEngine.Debug.Log(message:  server.ToJson());
        this.confirmButton.gameObject.SetActive(value:  (this.selection != 0) ? 1 : 0);
    }
    private void SetSelectionToUser()
    {
        NFUser.current.SetupServer(serverInfo:  this.selection);
    }
    private void InitServerItems()
    {
        var val_4;
        List.Enumerator<T> val_2 = GameServerManager.GetAllDisplayServers().GetEnumerator();
        label_12:
        if(((-1367160992) & 1) == 0)
        {
            goto label_4;
        }
        
        ServerSelectionItemUI val_8 = UnityEngine.Object.Instantiate<ServerSelectionItemUI>(original:  this.itemTemplate, parent:  this.itemTemplate.transform.parent);
        val_8.gameObject.SetActive(value:  true);
        val_8.Setup(panel:  this, gameServerInfo:  val_4.InitialType);
        goto label_12;
        label_4:
        val_4.Add(driver:  public System.Void List.Enumerator<GameServerInfo>::Dispose(), rectTransform:  null, drivenProperties:  null);
        this.toggleGroup.SetAllTogglesOff();
        this.toggleGroup.allowSwitchOff = false;
    }
    protected override void PlayShowAnim()
    {
        this.loadingObj.gameObject.SetActive(value:  true);
        this.confirmButton.gameObject.SetActive(value:  false);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.25f);
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.confirmButton.transform, punch:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.5f, vibrato:  1, elasticity:  1f), loops:  0, loopType:  0);
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  this, method:  System.Void ServerSelectionPanel::<PlayShowAnim>b__14_0()), delay:  0f);
    }
    protected override void PlayHideAnim()
    {
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.fadeCanvasGroup, endValue:  0f, duration:  0.5f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void ServerSelectionPanel::<PlayHideAnim>b__15_0()));
    }
    public ServerSelectionPanel()
    {
    
    }
    private void <Awake>b__8_0()
    {
        this.SetSelectionToUser();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  (this.isLoginMode == true) ? "SignIn" : "SignUp");
        goto typeof(ServerSelectionPanel).__il2cppRuntimeField_198;
    }
    private void <PlayShowAnim>b__14_0()
    {
        GameServerManager.FetchGameServerIP(OnDone:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void ServerSelectionPanel::<PlayShowAnim>b__14_1()), showLoadingWhenProc:  false);
    }
    private void <PlayShowAnim>b__14_1()
    {
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  this, method:  System.Void ServerSelectionPanel::<PlayShowAnim>b__14_2()), delay:  0f);
    }
    private void <PlayShowAnim>b__14_2()
    {
        this.InitServerItems();
        this.loadingObj.gameObject.SetActive(value:  false);
    }
    private void <PlayHideAnim>b__15_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
